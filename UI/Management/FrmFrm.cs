using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Management
{
    public partial class FrmFrm : Form
    {
        Models.FrmInfo frmInfo;
        Models.FrmCategoryInfo frmCategoryInfo;

        Controllers.ControllerBase controllerBase;
        Controllers.FrmController frmController;
        Controllers.FrmCategoryController frmCategoryController;

        DataTable dt;
        public FrmFrm()
        {
            frmInfo = new Models.FrmInfo();
            frmCategoryInfo = new Models.FrmCategoryInfo();

            controllerBase = new Controllers.ControllerBase();
            frmController = new Controllers.FrmController();
            frmCategoryController = new Controllers.FrmCategoryController();
            
            InitializeComponent();
        }
        private void Bind_Autocomplete()
        {
            cbFrmCategory.DataSource = controllerBase.SelectAllActive("sp_FrmCategory");
            cbFrmCategory.DisplayMember = "CategoryMyan";
            cbFrmCategory.ValueMember = "FrmCategoryID";
        }
        private void btnAddFrmCategory_Click(object sender, EventArgs e)
        {
            FrmFrmCategory frmCategory = new FrmFrmCategory();
            frmCategory.ShowDialog();
            Bind_Autocomplete();
        }

        private void FrmFrm_Load(object sender, EventArgs e)
        {
            Bind_Autocomplete();
        }
        private void ClearControls()
        {
            txtFrmName.Text = "";
            txtFrmMyan.Text = "";
            txtDescription.Text = "";
            cbInactive.Checked = false;
            txtFrmName.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFrmName.Text.Trim() == "")
            {
                Base.FrmMsg frmMsg = new Base.FrmMsg("ဖြည့်ရန်လိုအပ်", "အမည် ဖြည့်ပါ", "", 2);
                frmMsg.ShowDialog();
                txtFrmName.Focus();
                return;
            }
            if (txtFrmMyan.Text.Trim() == "")
            {
                Base.FrmMsg frmMsg = new Base.FrmMsg("ဖြည့်ရန်လိုအပ်", "စာသားဖြင့်ဖော်ပြရန် ဖြည့်ပါ", "", 2);
                frmMsg.ShowDialog();
                txtFrmMyan.Focus();
                return;
            }
            frmInfo.FrmCategoryID = cbFrmCategory.SelectedValue.ToString();
            frmInfo.FrmName = txtFrmName.Text;
            frmInfo.FrmMyan = txtFrmMyan.Text;
            frmInfo.FrmDescription = txtDescription.Text;
            if (cbInactive.Checked)
            {
                frmInfo.Inactive = true;
            }
            else
            {
                frmInfo.Inactive = false;
            }
            if (btnSave.Text != "ပြုပြင်မည်")
            {
                frmController.Insert(frmInfo,"sp_Frm");
                ClearControls();
            }
            else
            {
                frmController.Update(frmInfo, "sp_Frm");
                ClearControls();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Base.FrmSearch frmSearch = new Base.FrmSearch("sp_Frm", new string[] { "FrmID","FrmCategoryID" });
            frmSearch.ShowDialog();
            string ID = frmSearch.ID;
            if (ID != "")
            {
                dt = frmController.SelectByID("sp_Frm", "FrmID", ID);
                frmInfo.FrmID = ID;
                cbFrmCategory.SelectedValue = dt.Rows[0]["frmCategoryID"].ToString();
                txtFrmName.Text = dt.Rows[0]["FrmName"].ToString();
                txtFrmMyan.Text = dt.Rows[0]["FrmMyan"].ToString();
                txtDescription.Text = dt.Rows[0]["FrmDescription"].ToString();
                cbInactive.Checked = Convert.ToBoolean(dt.Rows[0]["Inactive"]);
                btnSave.Text = "ပြုပြင်မည်";
            }
        }
    }
}
