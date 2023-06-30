using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.StockList
{
    public partial class FrmStock : Form
    {
        FrmMain _frmMain;
        Models.StockInfo stockInfo;
        Controllers.StockController stockController;
        Models.ReOrderInfo reOrderInfo;
        Controllers.ReOrderController reOrderController;
        Controllers.ControllerBase controllerBase = new Controllers.ControllerBase();
        DataTable dt;
        DataTable reOrderDT;
        public FrmStock()
        {
            InitializeComponent();
        }
        public FrmStock(FrmMain frmMain)
        {
            _frmMain = frmMain;
            stockInfo = new Models.StockInfo();
            reOrderInfo = new Models.ReOrderInfo();
            reOrderDT = new DataTable();
            InitializeComponent();

        }
        private void Bind_Autocomplete()
        {
            Controllers.ControllerBase controllerBase = new Controllers.ControllerBase();

            cbCategory.DataSource = controllerBase.SelectAll("sp_Category");
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "CategoryID";
            
            cbSubCategory.DataSource = controllerBase.SelectAll("sp_SubCategory");
            cbSubCategory.DisplayMember = "Name";
            cbSubCategory.ValueMember = "SubCategoryID";

        }
        private void dgv_Header()
        {
            dgvReorder.Columns.Add("Sr", "Sr");
            DataGridViewComboBoxColumn countColumn = new DataGridViewComboBoxColumn();
            countColumn.DataSource = controllerBase.SelectAll("sp_Count");
            countColumn.DisplayMember = "Name";
            countColumn.ValueMember = "CountID";
            countColumn.Name = "CountID";
            dgvReorder.Columns.Add(countColumn);
            dgvReorder.Columns["CountID"].HeaderText = "Count Unit";
            dgvReorder.ColumnHeadersHeight = 40;
            dgvReorder.Columns.Add("Amount", "Amount");
            dgvReorder.Columns["Sr"].ReadOnly = true;
            dgvReorder.Rows.Clear();

            dgvMultiUnit.Columns.Add("Sr", "Sr");
            DataGridViewComboBoxColumn countColumnMulti = new DataGridViewComboBoxColumn();
            countColumnMulti.DataSource = controllerBase.SelectAll("sp_Count");
            countColumnMulti.DisplayMember = "Name";
            countColumnMulti.ValueMember = "CountID";
            countColumnMulti.Name = "CountID";
            
            dgvMultiUnit.Columns.Add(countColumnMulti);
            dgvMultiUnit.Columns["CountID"].HeaderText = "Count Unit";
            dgvMultiUnit.ColumnHeadersHeight = 40;
            dgvMultiUnit.RowTemplate.Height = 40;
            dgvMultiUnit.Columns.Add("Amount", "Amount");
            DataGridViewCheckBoxColumn dgvDefault = new DataGridViewCheckBoxColumn();
            dgvDefault.Name = "UseDefault";
            dgvDefault.HeaderText = "Use Default";
            dgvMultiUnit.Columns.Add(dgvDefault);
            DataGridViewCheckBoxColumn dgvActive = new DataGridViewCheckBoxColumn();
            dgvActive.Name = "Isactive";
            dgvActive.HeaderText = "Active";
            dgvMultiUnit.Columns.Add(dgvActive);
            dgvMultiUnit.Columns["Sr"].ReadOnly = true;
            dgvMultiUnit.Rows.Clear();
        }
        private void Bind_dgvDefaultStyle()
        {
            Base.UIBaseFunctions ubFunctions = new Base.UIBaseFunctions();
            //ubFunctions.BindDGVWithHeaderID(dgvDefaultStyle, "sp_ReOrder","", new string[] { "ReOrderID","StockID" });
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            _frmMain.showMainScreen();
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            Bind_Autocomplete();
            Bind_dgvDefaultStyle();
            dgv_Header();
            ClearControls();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            stockInfo.Code = txtCode.Text;
            if(txtName.Text.Trim() == "")
            {
                Base.FrmMsg frmMsg = new Base.FrmMsg("ဖြည့်ရန်လိုအပ်", "အမည် ဖြည့်ပါ", "", 2);
                frmMsg.ShowDialog();
                txtName.Focus();
                return;
            }
            stockInfo.Name = txtName.Text;
            stockInfo.CategoryID = cbCategory.SelectedValue.ToString();
            stockInfo.SubCategoryID = cbSubCategory.SelectedValue.ToString();
            if (cbMultiUnit.Checked)
            {
                for(int i = 0; i < dgvMultiUnit.Rows.Count; i++)
                {
                    if (dgvMultiUnit.Rows[i].Cells["Amount"].Value == null)
                    {
                        dgvMultiUnit.CurrentCell = dgvMultiUnit.Rows[i].Cells["Amount"];
                        dgvMultiUnit.BeginEdit(true);
                        return;
                    }
                }
            }
            stockInfo.Inactive = cbInactive.Checked;
            stockInfo.ToReOrder = cbReOrder.Checked;
            stockInfo.ToAddPhoto = cbInsertImage.Checked;
            stockController = new Controllers.StockController();
            if (btnSave.Text != "ပြုပြင်မည်")
            {
                string stockID = stockController.Insert(stockInfo, "sp_Stock");
                string result = "";
                if (dgvReorder.Rows.Count > 0)
                {
                    result = reOrderInsert(stockID);
                }

                ClearControls();
            }
            else
            {
                string spResult = stockController.Update(stockInfo, "sp_Stock");
                reOrderController = new Controllers.ReOrderController();
                if (reOrderDT.Rows.Count > 0)
                {
                    for (int i = 0; i < reOrderDT.Rows.Count; i++)
                    {
                        reOrderController.DeleteByID("sp_ReOrder", "ReOrderID", reOrderDT.Rows[i]["ReOrderID"].ToString());
                    }
                }

                string result = "";
                if (dgvReorder.Rows.Count > 0)
                {
                    result = reOrderInsert(stockInfo.StockID);
                }

                ClearControls();
            }
        }
        private string reOrderInsert(string stockID)
        {
            string result = "";
            
                if (dgvReorder.Rows.Count < 2)
                {
                    reOrderInfo.StockID = stockID;
                    reOrderInfo.Sr = Convert.ToInt32(dgvReorder.Rows[0].Cells["Sr"].Value.ToString());
                    reOrderInfo.CountID = dgvReorder.Rows[0].Cells["CountID"].Value.ToString();
                    reOrderInfo.Amount = Convert.ToInt32(dgvReorder.Rows[0].Cells["Amount"].Value.ToString());
                    reOrderController = new Controllers.ReOrderController();
                    result = reOrderController.Insert(reOrderInfo, "sp_ReOrder");
                }
                else
                {
                    for (int i = 0; i < dgvReorder.Rows.Count; i++)
                    {
                        reOrderInfo.StockID = stockID;
                        reOrderInfo.Sr = Convert.ToInt32(dgvReorder.Rows[i].Cells["Sr"].Value.ToString());
                        reOrderInfo.CountID = dgvReorder.Rows[i].Cells["CountID"].Value.ToString();
                        reOrderInfo.Amount = Convert.ToInt32(dgvReorder.Rows[i].Cells["Amount"].Value.ToString());
                        reOrderController = new Controllers.ReOrderController();
                        result = reOrderController.Insert(reOrderInfo, "sp_ReOrder");
                    }
                }
            
            return result;
        }
        private void cbReOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReOrder.Checked)
            {
                if (dgvReorder.Rows.Count < 1)
                {
                    dgvReorder.Rows.Add();
                    dgvReorder.Rows[0].Cells["Sr"].Value = 1;
                    dgvReorder.Rows[0].Cells["CountID"].Value = (object)controllerBase.DefaultID("sp_Count");
                    dgvReorder.CurrentCell = dgvReorder.Rows[0].Cells["Amount"];
                    dgvReorder.BeginEdit(true);
                    return;
                }
            }
        }

        private void dgvReorder_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvReorder.SelectedRows.Count > 0)
            {
                if (dgvReorder.CurrentCell.ColumnIndex == 2 && e.KeyCode == Keys.Enter)
                {
                    if (!(dgvReorder.Rows[dgvReorder.CurrentRow.Index].Cells["CountID"].Value == null) && !(dgvReorder.Rows[dgvReorder.CurrentRow.Index].Cells["Amount"].Value == null))
                    {
                        //Base.FrmMsg frmMsgReorder = new Base.FrmMsg("Waranty","Should Only1","aa");
                        //frmMsgReorder.ShowDialog();
                        //dgvReorder.Rows.Add();
                        //dgvReorder.Rows[dgvReorder.Rows.Count - 1].Cells[0].Value = dgvReorder.Rows.Count;
                        //dgvReorder.Rows[dgvReorder.Rows.Count - 1].Cells[0].Value = dgvReorder.Rows.Count;
                        //dgvReorder.Rows[dgvReorder.Rows.Count - 1].Cells["CountID"].Value = (object)controllerBase.DefaultID("sp_Count");
                        //SendKeys.Send("{F2}");
                    }
                }
                if (e.KeyCode == Keys.Escape)
                {
                    dgvReorder.Rows.RemoveAt(dgvReorder.Rows.Count - 1);
                    if (dgvReorder.Rows.Count < 1)
                    {
                        cbReOrder.Checked = false;
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void ClearControls()
        {
            stockInfo = new Models.StockInfo();
            reOrderInfo = new Models.ReOrderInfo();
            reOrderDT  = new DataTable();
            DataTable dt = controllerBase.SelectAll("sp_Settings");
            if(Convert.ToBoolean(dt.Rows[0][1].ToString()))
            {
                txtCode.Enabled = false;
                txtCode.Text = controllerBase.AutoGenerateCode("sp_Stock");
            }
            else
            {
                txtCode.Text = "";
            }
            
            txtName.Text = "";
            if (cbCategory.Items.Count > 0)
            {
                cbCategory.SelectedIndex = 0;
                Controllers.SubCateogryController subCategory = new Controllers.SubCateogryController();
                cbSubCategory.DataSource = subCategory.GetSubCategoryWithCategoryID("sp_SubCategory", cbCategory.SelectedValue.ToString());
                cbSubCategory.DisplayMember = "Name";
                cbSubCategory.ValueMember = "SubCategoryID";
            }
                
                
            if (cbSubCategory.Items.Count > 0)
                cbSubCategory.SelectedIndex = 0;
            cbInactive.Checked = false;
            cbReOrder.Checked = false;
            cbInsertImage.Checked = false;
            dgvReorder.Rows.Clear();
            dgvMultiUnit.Rows.Clear();
            btnSave.Text = "သိမ်းမည်";
            txtName.Focus();
        }

        private void btnSupplierSearch_Click(object sender, EventArgs e)
        {
            Base.FrmSearch frmSearch = new Base.FrmSearch("sp_Stock", new string[] { "StockID","CategoryID","SubCategoryID" });
            frmSearch.ShowDialog();
            string ID = frmSearch.ID;
            if (ID != "")
            {
                dgvReorder.Rows.Clear();
                stockController = new Controllers.StockController();
                dt = stockController.SelectByID("sp_Stock", "StockID", ID);
                
                stockInfo.StockID = dt.Rows[0]["StockID"].ToString();
                txtCode.Text = dt.Rows[0]["Code"].ToString();
                txtName.Text = dt.Rows[0]["Name"].ToString();
                cbCategory.SelectedValue = dt.Rows[0]["CategoryID"].ToString();
                cbSubCategory.SelectedValue = dt.Rows[0]["SubCategoryID"].ToString();
                cbInactive.Checked = Convert.ToBoolean(dt.Rows[0]["Inactive"]);
                bool reOrderStatus = Convert.ToBoolean(dt.Rows[0]["ToReOrder"]);
                cbInsertImage.Checked = Convert.ToBoolean(dt.Rows[0]["ToAddPhoto"]);
                btnSave.Text = "ပြုပြင်မည်";

                reOrderController = new Controllers.ReOrderController();
                dt = reOrderController.SelectByID("sp_ReOrder", "StockID", stockInfo.StockID);
                if (dt.Rows.Count > 0)
                {
                    reOrderDT = dt;
                    for(int i = 0; i < dt.Rows.Count; i++)
                    {
                        dgvReorder.Rows.Add();
                        dgvReorder.Rows[i].Cells["Sr"].Value = dt.Rows[i]["Sr"].ToString();
                        dgvReorder.Rows[i].Cells["CountID"].Value = dt.Rows[i]["CountID"].ToString();
                        dgvReorder.Rows[i].Cells["Amount"].Value = dt.Rows[i]["Amount"].ToString();
                    }
                }

                cbReOrder.Checked = reOrderStatus;
            }
        }

        private void cbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            Controllers.SubCateogryController subCategory = new Controllers.SubCateogryController();
            cbSubCategory.DataSource = subCategory.GetSubCategoryWithCategoryID("sp_SubCategory",cbCategory.SelectedValue.ToString());
            cbSubCategory.DisplayMember = "Name";
            cbSubCategory.ValueMember = "SubCategoryID";
        }

        private void dgvMultiUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvMultiUnit.SelectedRows.Count > 0)
            {
                if (dgvMultiUnit.CurrentCell.ColumnIndex >= 2 )
                {
                    if(e.KeyCode == Keys.Enter)
                    {
                        if (!(dgvMultiUnit.Rows[dgvMultiUnit.CurrentRow.Index].Cells["CountID"].Value == null) && !(dgvMultiUnit.Rows[dgvMultiUnit.CurrentRow.Index].Cells["Amount"].Value == null))
                        {
                            dgvMultiUnit.Rows.Add();
                            dgvMultiUnit.Rows[dgvMultiUnit.Rows.Count - 1].Cells["Isactive"].Value = true;
                            dgvMultiUnit.Rows[dgvMultiUnit.Rows.Count - 1].Cells[0].Value = dgvMultiUnit.Rows.Count;
                            dgvMultiUnit.Rows[dgvMultiUnit.Rows.Count - 1].Cells["CountID"].Value = (object)controllerBase.DefaultID("sp_Count");
                            SendKeys.Send("{F2}");
                        }
                    }
                    
                }
                if (e.KeyCode == Keys.Escape)
                {
                    dgvMultiUnit.Rows.RemoveAt(dgvMultiUnit.Rows.Count - 1);
                    if (dgvMultiUnit.Rows.Count < 1)
                    {
                        cbMultiUnit.Checked = false;
                    }
                }
            }
        }

        private void cbMultiUnit_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMultiUnit.Checked)
            {
                if (dgvMultiUnit.Rows.Count < 1)
                {
                    dgvMultiUnit.Rows.Add();
                    dgvMultiUnit.Rows[0].Cells["Sr"].Value = 1;
                    dgvMultiUnit.Rows[0].Cells["CountID"].Value = (object)controllerBase.DefaultID("sp_Count");
                    dgvMultiUnit.CurrentCell = dgvMultiUnit.Rows[0].Cells["Amount"];
                    dgvMultiUnit.Rows[0].Cells["Amount"].Value = 1;
                    dgvMultiUnit.Rows[0].Cells["UseDefault"].Value = true;
                    dgvMultiUnit.Rows[0].Cells["Isactive"].Value = true;
                    dgvMultiUnit.BeginEdit(true);
                    return;
                }
            }
        }

        private void dgvMultiUnit_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(dgvColumnOnlyNumber);
            if(dgvMultiUnit.CurrentCell.ColumnIndex == 2)
            {
                TextBox tb = e.Control as TextBox;
                if(tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(dgvColumnOnlyNumber);
                }
            }
        }
        private void dgvColumnOnlyNumber(object sender,KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvReorder_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(dgvColumnOnlyNumber);
            if (dgvReorder.CurrentCell.ColumnIndex == 2)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(dgvColumnOnlyNumber);
                }
            }
        }

        private void dgvMultiUnit_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
}
