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
    public partial class FrmOpeningStock : Form
    {
        FrmMain _frmMain;
        Controllers.ControllerBase controllerBase = new Controllers.ControllerBase();
        Models.SupplierInfo supplierInfo = new Models.SupplierInfo();
        public FrmOpeningStock()
        {
            InitializeComponent();
        }
        public FrmOpeningStock(FrmMain frmMain)
        {
            _frmMain = frmMain;
            InitializeComponent();

        }
        private void dgv_Header()
        {
            dgvOpeningStock.Columns.Add("Sr", "Sr");
            dgvOpeningStock.Columns.Add("Counter", "Counter");
            dgvOpeningStock.Columns.Add("CounterID", "CounterID");
            dgvOpeningStock.Columns.Add("ItemID", "ItemID");
            dgvOpeningStock.Columns.Add("Code", "Code");
            dgvOpeningStock.Columns.Add("ItemName", "ItemName");
            DataGridViewComboBoxColumn countColumn = new DataGridViewComboBoxColumn();
            countColumn.DataSource = controllerBase.SelectAll("sp_Count");
            countColumn.DisplayMember = "Name";
            countColumn.ValueMember = "CountID";
            countColumn.Name = "Count";
            dgvOpeningStock.Columns.Add(countColumn);
            dgvOpeningStock.Columns.Add("BuyPrice", "BuyPrice");
            dgvOpeningStock.Columns.Add("SalePrice", "SalePrice");
            dgvOpeningStock.Columns.Add("Amount", "Amount");
            dgvOpeningStock.Columns.Add("Total", "Total");
            dgvOpeningStock.Columns["Sr"].ReadOnly = true;
            dgvOpeningStock.Columns["Counter"].ReadOnly = true;
            dgvOpeningStock.Columns["CounterID"].ReadOnly = true;
            dgvOpeningStock.Columns["ItemID"].ReadOnly = true;
            dgvOpeningStock.Columns["Code"].ReadOnly = true;
            dgvOpeningStock.Columns["ItemName"].ReadOnly = true;
            dgvOpeningStock.Columns["Total"].ReadOnly = true;
            dgvOpeningStock.Columns["CounterID"].Visible = false;
            dgvOpeningStock.Columns["ItemID"].Visible = false;
            dgvOpeningStock.ColumnHeadersHeight = 40;
            dgvOpeningStock.RowTemplate.Height = 35;
            dgvOpeningStock.Rows.Add();
            dgvOpeningStock.Rows[0].Cells[0].Value = 1;
            //dgvOpeningStock.Rows[0].Cells["Count"].Value = "016CAA51-0C00-4C72-8BA7-8A30B8F6423C";
        }

        private void FrmOpeningStock_Load(object sender, EventArgs e)
        {
            Bind_Autocomplete();
            dgv_Header();
        }
        private void Bind_Autocomplete()
        {
            Controllers.ControllerBase controllerBase = new Controllers.ControllerBase();

            cboSupplier.DataSource = controllerBase.SelectAllActive("sp_Supplier");
            cboSupplier.DisplayMember = "Code";
            cboSupplier.ValueMember = "SupplierID";


            cboWarehouse.DataSource = controllerBase.SelectAllActive("sp_Warehouse");
            cboWarehouse.DisplayMember = "Name";
            cboWarehouse.ValueMember = "WarehouseID";
            if (cboWarehouse.Items.Count > 0)
                cboWarehouse.SelectedValue = controllerBase.DefaultID("sp_Warehouse");


            cboCurrencyType.DataSource = controllerBase.SelectAll("sp_CurrencyType");
            cboCurrencyType.DisplayMember = "Name";
            cboCurrencyType.ValueMember = "CurrencyTypeID";
            if(cboCurrencyType.Items.Count>0)
                cboCurrencyType.SelectedValue = controllerBase.DefaultID("sp_CurrencyType");

            cboPaymentType.DataSource = controllerBase.SelectAll("sp_PaymentType");
            cboPaymentType.DisplayMember = "Name";
            cboPaymentType.ValueMember = "PaymentTypeID";
            //cboPaymentType.SelectedValue = controllerBase.DefaultID("sp_PaymentType");

        }
        private void dgvOpeningStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvOpeningStock.CurrentCell.ColumnIndex == 1)
            {
                showCounter();
            }
            if (dgvOpeningStock.CurrentCell.ColumnIndex == 4 || dgvOpeningStock.CurrentCell.ColumnIndex == 5) 
            {
                showItem();
            }
        }

        private void btnSupplierSearch_Click(object sender, EventArgs e)
        {
            Base.FrmSearch frmSearch = new Base.FrmSearch("sp_Supplier", new string[] { "SupplierID", "Inactive" });
            frmSearch.ShowDialog();
            cboSupplier.SelectedValue = frmSearch.ID;
        }

        private void cboSupplier_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cboSupplier.SelectedValue == null)
            {
                txtSupplierName.Text = "";
            }
            else
            {
                Controllers.SupplierController supplierController = new Controllers.SupplierController();
                DataTable dt = supplierController.SelectByID("sp_Supplier", "SupplierID", cboSupplier.SelectedValue.ToString());
                if (dt.Rows.Count > 0)
                {
                    txtSupplierName.Text = dt.Rows[0]["Name"].ToString();
                }
            }
            
        }

        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            Shop.FrmSupplier frmSupplier = new Shop.FrmSupplier();
            frmSupplier.ShowDialog();
            cboSupplier.DataSource = controllerBase.SelectAll("sp_Supplier");
            cboSupplier.DisplayMember = "Code";
            cboSupplier.ValueMember = "SupplierID";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _frmMain.showMainScreen();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void ClearControls()
        {
            cboSupplier.SelectedValue = "";
            dtpInDate.Value = DateTime.Now;
        }

        private void cboCurrencyType_SelectedValueChanged(object sender, EventArgs e)
        {
            //Controllers.SupplierController supplierController = new Controllers.SupplierController();
            //DataTable dt = supplierController.SelectByID("sp_Supplier", "SupplierID", cboSupplier.SelectedValue.ToString());
            //if (dt.Rows.Count > 0)
            //{
            //    txtSupplierName.Text = dt.Rows[0]["Name"].ToString();
            //}
        }

        private void dgvOpeningStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvOpeningStock.SelectedRows.Count > 0)
            {
                if(dgvOpeningStock.CurrentCell.ColumnIndex == 1 && e.KeyCode == Keys.Enter)
                {
                    showCounter();
                }
                if ((dgvOpeningStock.CurrentCell.ColumnIndex == 4 || dgvOpeningStock.CurrentCell.ColumnIndex == 5) && e.KeyCode == Keys.Enter)
                {
                    showItem();
                }
                if ((dgvOpeningStock.CurrentCell.ColumnIndex == 6 || dgvOpeningStock.CurrentCell.ColumnIndex == 7 || dgvOpeningStock.CurrentCell.ColumnIndex == 8) && e.KeyCode == Keys.Enter)
                {
                    SendKeys.Send("{TAB}");
                }
                if (dgvOpeningStock.CurrentCell.ColumnIndex == 9 && e.KeyCode == Keys.Enter)
                {
                    if (dgvOpeningStock.CurrentRow.Cells["CounterID"].Value == null)
                    {
                        dgvOpeningStock.CurrentCell = dgvOpeningStock.CurrentRow.Cells["Counter"];
                    }
                    else if (dgvOpeningStock.CurrentRow.Cells["ItemID"].Value == null)
                    {
                        dgvOpeningStock.CurrentCell = dgvOpeningStock.CurrentRow.Cells["Code"];
                    }
                    else if (dgvOpeningStock.CurrentRow.Cells["BuyPrice"].Value == null)
                    {
                        dgvOpeningStock.CurrentCell = dgvOpeningStock.CurrentRow.Cells["BuyPrice"];
                    }
                    else if (dgvOpeningStock.CurrentRow.Cells["SalePrice"].Value == null)
                    {
                        dgvOpeningStock.CurrentCell = dgvOpeningStock.CurrentRow.Cells["SalePrice"];
                    }
                    else if (dgvOpeningStock.CurrentRow.Cells["Amount"].Value == null)
                    {
                        dgvOpeningStock.CurrentCell = dgvOpeningStock.CurrentRow.Cells["Amount"];
                    }
                    else
                    {
                        dgvOpeningStock.CurrentRow.Cells["Total"].Value = Convert.ToInt32(dgvOpeningStock.CurrentRow.Cells["BuyPrice"].Value) * Convert.ToInt32(dgvOpeningStock.CurrentRow.Cells["Amount"].Value);
                        getTotal();
                        SendKeys.Send("{TAB}");
                    }
                }
                if (dgvOpeningStock.CurrentCell.ColumnIndex == 10 && e.KeyCode == Keys.Enter)
                {
                    
                    dgvOpeningStock.Rows.Add();
                    dgvOpeningStock.Rows[dgvOpeningStock.Rows.Count - 1].Cells[0].Value = dgvOpeningStock.Rows.Count;
                    dgvOpeningStock.CurrentCell = dgvOpeningStock.CurrentRow.Cells[1];
                    dgvOpeningStock.Rows[dgvOpeningStock.Rows.Count - 1].Cells["Count"].Value = "016CAA51-0C00-4C72-8BA7-8A30B8F6423C";
                }
                    if (e.KeyCode == Keys.Escape)
                {
                    if (dgvOpeningStock.Rows.Count > 1)
                    {
                        dgvOpeningStock.Rows.RemoveAt(dgvOpeningStock.Rows.Count - 1);
                        getTotal();
                    }
                }
            }
        }
        private void showCounter()
        {
            Base.FrmSearch frmSearch = new Base.FrmSearch("sp_Counter", new string[] { "CounterID", "UsedDefault", "Inactive" });
            frmSearch.ShowDialog();
            string ID = frmSearch.ID;
            if (ID != "")
            {
                DataTable dt = controllerBase.SelectByID("sp_Counter", "CounterID", ID);
                dgvOpeningStock.CurrentRow.Cells[2].Value = ID;
                dgvOpeningStock.CurrentRow.Cells[1].Value = dt.Rows[0]["Name"].ToString();
                SendKeys.Send("{TAB}");
            }
        }
        private void showItem()
        {
            Base.FrmSearch frmSearch = new Base.FrmSearch("sp_Stock", new string[] { "StockID", "SubCategoryID", "CategoryID", "Inactive", "ToReOrder", "ToAddPhoto" });
            frmSearch.ShowDialog();
            string ID = frmSearch.ID;
            if (ID != "")
            {
                DataTable dt = controllerBase.SelectByID("sp_Stock", "StockID", ID);
                dgvOpeningStock.CurrentRow.Cells[3].Value = ID;
                dgvOpeningStock.CurrentRow.Cells[4].Value = dt.Rows[0]["Code"].ToString();
                dgvOpeningStock.CurrentRow.Cells[5].Value = dt.Rows[0]["Name"].ToString();
                SendKeys.Send("{TAB}");
                SendKeys.Send("{TAB}");
            }
        }
        private void getTotal()
        {
            int sum = 0;
            for(int i =0; i< dgvOpeningStock.RowCount; i++)
            {
                sum += Convert.ToInt32(dgvOpeningStock.Rows[i].Cells["Total"].Value.ToString());
            }
            txtGrandTotal.Text = sum.ToString();
        }

        private void dgvOpeningStock_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvOpeningStock.CurrentCell.ColumnIndex == 7 || dgvOpeningStock.CurrentCell.ColumnIndex == 9)
            {
                dgvOpeningStock.CurrentRow.Cells["Total"].Value = Convert.ToInt32(dgvOpeningStock.CurrentRow.Cells["BuyPrice"].Value) * Convert.ToInt32(dgvOpeningStock.CurrentRow.Cells["Amount"].Value);
                getTotal();
            }
        }

        private void txtExchangeRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (Base.UIBaseFunctions.CheckNumeric(e))
            {
                base.OnKeyDown(e);
            }
            else
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
