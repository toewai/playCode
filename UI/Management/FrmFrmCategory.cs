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
    public partial class FrmFrmCategory : Form
    {
        Models.FrmCategoryInfo frmCategoryInfo;
        Controllers.FrmCategoryController frmCategoryController;
        DataTable dt;
        public FrmFrmCategory()
        {
            frmCategoryInfo = new Models.FrmCategoryInfo();
            frmCategoryController = new Controllers.FrmCategoryController();
            dt = new DataTable();
            InitializeComponent();
        }

        private void ClearControls()
        {
            txtCategoryName.Text = "";
            txtCategoryMyan.Text = "";
            cbInactive.Checked = false;
            btnSave.Text = "သိမ်းမည်";
            txtCategoryName.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text.Trim() == "")
            {
                Base.FrmMsg frmMsg = new Base.FrmMsg("ဖြည့်ရန်လိုအပ်", "အမည် ဖြည့်ပါ", "", 2);
                frmMsg.ShowDialog();
                txtCategoryName.Focus();
                return;
            }
            if (txtCategoryMyan.Text.Trim() == "")
            {
                Base.FrmMsg frmMsg = new Base.FrmMsg("ဖြည့်ရန်လိုအပ်", "စာဖြင့်ဖော်ပြရန် ဖြည့်ပါ", "", 2);
                frmMsg.ShowDialog();
                txtCategoryMyan.Focus();
                return;
            }
            frmCategoryInfo.CategoryName = txtCategoryName.Text;
            frmCategoryInfo.CategoryMyan = txtCategoryMyan.Text;
            if (cbInactive.Checked)
            {
                frmCategoryInfo.Inactive = true;
            }
            else
            {
                frmCategoryInfo.Inactive = false;
            }
            frmCategoryController = new Controllers.FrmCategoryController();
            if (btnSave.Text != "ပြုပြင်မည်")
            {
                string frmCategoryID = frmCategoryController.Insert(frmCategoryInfo, "sp_FrmCategory");
                ClearControls();
            }
            else
            {
                string frmCategoryID = frmCategoryController.Update(frmCategoryInfo, "sp_FrmCategory");
                ClearControls();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Base.FrmSearch frmSearch = new Base.FrmSearch("sp_FrmCategory", new string[] { "FrmCategoryID"});
            frmSearch.ShowDialog();
            string ID = frmSearch.ID;
            btnSave.Text = "ပြုပြင်မည်";
            if (ID != "")
            {
                dt =frmCategoryController.SelectByID("sp_FrmCategory", "FrmCategoryID", ID);
                frmCategoryInfo.FrmCategoryID = dt.Rows[0]["FrmCategoryID"].ToString();
                txtCategoryName.Text = dt.Rows[0]["CategoryName"].ToString();
                txtCategoryMyan.Text = dt.Rows[0]["CategoryMyan"].ToString();
                cbInactive.Checked = Convert.ToBoolean(dt.Rows[0]["Inactive"]);
            }
        }
    }
}
