using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Shop
{
    public partial class FrmCategory : Form
    {
        FrmMain _frmMain;
        Models.CategoryInfo categoryInfo;
        Controllers.CategoryController categoryController;
        DataTable dt;
        public FrmCategory()
        {
            dt = new DataTable();
            categoryInfo = new Models.CategoryInfo();
            categoryController = new Controllers.CategoryController();
            InitializeComponent();
        }
        public FrmCategory(FrmMain frmMain)
        {
            _frmMain = frmMain;
            dt = new DataTable();
            categoryInfo = new Models.CategoryInfo();
            categoryController = new Controllers.CategoryController();
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if ((_frmMain) == null)
            {
                this.Close();
            }
            else
            {
                _frmMain.showMainScreen();
            }
        }
        private void ClearControls()
        {
            categoryInfo = new Models.CategoryInfo();
            txtCode.Text = categoryController.AutoGenerateCode("sp_Category");
            txtName.Text = "";
            cbInactive.Checked = false;
            btnSave.Text = "သိမ်းမည်";
            txtName.Focus();
        }
        private void Bind_dgvCategory()
        {
            Base.UIBaseFunctions ubFunctions = new Base.UIBaseFunctions();
            ubFunctions.BindDGV(dgvCategory, "sp_Category", new string[] { "CategoryID" });
            if (cboSearchOptions.Items.Count < 1)
            {
                ubFunctions.BindSearchOptions(dgvCategory, cboSearchOptions);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Base.UIBaseFunctions baseFunctions = new Base.UIBaseFunctions();
            if (!baseFunctions.Validation(txtName))
            {
                Base.FrmMsg frmMsg = new Base.FrmMsg("ဖြည့်ရန်လိုအပ်", "အမည် ဖြည့်ပါ", "", 2);
                frmMsg.ShowDialog();
                txtName.Focus();
                return;
            }
            else
            {
                categoryInfo.Code = txtCode.Text;
                categoryInfo.Name = txtName.Text;
                if (cbInactive.Checked)
                {
                    categoryInfo.Inactive = true;
                }
                else
                {
                    categoryInfo.Inactive = false;
                }
                if (btnSave.Text != "ပြုပြင်မည်")
                {
                    categoryController.Insert(categoryInfo, "sp_Category");
                }
                else
                {
                    categoryController.Update(categoryInfo, "sp_Category");
                }
                ClearControls();
                Bind_dgvCategory();
            }
            
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            ClearControls();
            Bind_dgvCategory();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void DgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dt = categoryController.SelectAll("sp_Category");
            if (dt.Rows.Count > 0)
            {
                int cRow = dgvCategory.CurrentCell.RowIndex;
                string categoryID = dgvCategory.Rows[cRow].Cells["CategoryID"].Value.ToString();
                dt = categoryController.SelectByID("sp_Category", "CategoryID", categoryID);
                categoryInfo.CategoryID = dt.Rows[0]["CategoryID"].ToString();
                txtCode.Text = dt.Rows[0]["Code"].ToString();
                txtName.Text = dt.Rows[0]["Name"].ToString();
                cbInactive.Checked = Convert.ToBoolean(dt.Rows[0]["Inactive"]);
                btnSave.Text = "ပြုပြင်မည်";
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            Base.UIBaseFunctions ubFunctions = new Base.UIBaseFunctions();
            CurrencyManager cm = (CurrencyManager)BindingContext[dgvCategory.DataSource];
            cm.SuspendBinding();
            ubFunctions.SearchTextChanged(dgvCategory, cboSearchOptions,txtSearch);
            cm.ResumeBinding();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                for (int j = 0; j < dgvCategory.RowCount; j++)
                {
                    dgvCategory.Rows[j].Visible = true;
                }
            }
        }

        private void cboSearchOptions_TextChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            for (int j = 0; j < dgvCategory.RowCount; j++)
            {
                dgvCategory.Rows[j].Visible = true;
            }
            txtSearch.Focus();
        }
    }
}
