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
    public partial class FrmSubCategory : Form
    {
        FrmMain _frmMain;
        Models.SubCategoryInfo subCategoryInfo;
        Controllers.SubCateogryController subCategoryController;
        DataTable dt;
        public FrmSubCategory()
        {
            InitializeComponent();
        }
        public FrmSubCategory(FrmMain frmMain)
        {
            _frmMain = frmMain;
            dt = new DataTable();
            subCategoryInfo = new Models.SubCategoryInfo();
            subCategoryController = new Controllers.SubCateogryController();
            InitializeComponent();
        }
        private void Bind_AutoComplete()
        {
            Controllers.ControllerBase controllerBase = new Controllers.ControllerBase();

            cbCategoryID.DataSource = controllerBase.SelectAllActive("sp_Category");
            cbCategoryID.DisplayMember = "Name";
            cbCategoryID.ValueMember = "CategoryID";
        }
        private void ClearControls()
        {
            subCategoryInfo = new Models.SubCategoryInfo();
            txtCode.Text = subCategoryController.AutoGenerateCode("sp_SubCategory"); ;
            txtName.Text = "";
            cbInactive.Checked = false;
            btnSave.Text = "သိမ်းမည်";
            txtName.Focus();
        }
        private void Bind_dgvSubCategory()
        {
            Base.UIBaseFunctions ubFunctions = new Base.UIBaseFunctions();
            ubFunctions.BindDGV(dgvSubCategory, "sp_SubCategory", new string[] { "SubCategoryID", "CategoryID" });
            if (cboSearchOptions.Items.Count < 1)
            {
                ubFunctions.BindSearchOptions(dgvSubCategory, cboSearchOptions);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            _frmMain.showMainScreen();
        }

        private void FrmSubCategory_Load(object sender, EventArgs e)
        {
            Bind_dgvSubCategory();
            Bind_AutoComplete();
            ClearControls();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Base.UIBaseFunctions ubFunctions = new Base.UIBaseFunctions();
            if (!ubFunctions.Validation(txtName))
            {
                Base.FrmMsg frmMsg = new Base.FrmMsg("ဖြည့်ရန်လိုအပ်", "အမည် ဖြည့်ပါ", "", 2);
                frmMsg.ShowDialog();
                txtName.Focus();
                return;
            }
            subCategoryInfo.CategoryID = cbCategoryID.SelectedValue.ToString();
            subCategoryInfo.Code = txtCode.Text;
            subCategoryInfo.Name = txtName.Text;
            if (cbInactive.Checked)
            {
                subCategoryInfo.Inactive = true;
            }
            else
            {
                subCategoryInfo.Inactive = false;
            }
            if (btnSave.Text != "ပြုပြင်မည်")
            {
                subCategoryController.Insert(subCategoryInfo, "sp_SubCategory");
            }
            else
            {
                subCategoryController.Update(subCategoryInfo, "sp_SubCategory");
            }
            ClearControls();
            Bind_dgvSubCategory();
        }

        private void DgvSubCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dt = subCategoryController.SelectAll("sp_SubCategory");
            if (dt.Rows.Count > 0)
            {
                string countID = dgvSubCategory.Rows[dgvSubCategory.CurrentCell.RowIndex].Cells["SubCategoryID"].Value.ToString();
                dt = subCategoryController.SelectByID("sp_SubCategory", "SubCategoryID", countID);
                subCategoryInfo.SubCategoryID = dt.Rows[0]["SubCategoryID"].ToString();
                txtCode.Text = dt.Rows[0]["Code"].ToString();
                txtName.Text = dt.Rows[0]["Name"].ToString();
                cbCategoryID.SelectedValue = dt.Rows[0]["CategoryID"].ToString();
                cbInactive.Checked = Convert.ToBoolean(dt.Rows[0]["Inactive"]);
                btnSave.Text = "ပြုပြင်မည်";
            }
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frmCategory.StartPosition = FormStartPosition.CenterScreen;
            frmCategory.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void cboSearchOptions_TextChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            for (int j = 0; j < dgvSubCategory.RowCount; j++)
            {
                dgvSubCategory.Rows[j].Visible = true;
            }
            txtSearch.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Base.UIBaseFunctions ubFunctions = new Base.UIBaseFunctions();
            CurrencyManager cm = (CurrencyManager)BindingContext[dgvSubCategory.DataSource];
            cm.SuspendBinding();
            ubFunctions.SearchTextChanged(dgvSubCategory, cboSearchOptions, txtSearch);
            cm.ResumeBinding();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                for (int j = 0; j < dgvSubCategory.RowCount; j++)
                {
                    dgvSubCategory.Rows[j].Visible = true;
                }
            }
        }
    }
}
