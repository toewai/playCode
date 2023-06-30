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
    public partial class FrmSupplier : Form
    {
        FrmMain _frmMain;
        Models.SupplierInfo supplierInfo;
        Controllers.SupplierController supplierController;
        DataTable dt;
        public FrmSupplier()
        {
            dt = new DataTable();
            supplierInfo = new Models.SupplierInfo();
            supplierController = new Controllers.SupplierController();
            InitializeComponent();
        }
        public FrmSupplier(FrmMain frmMain)
        {
            _frmMain = frmMain;
            dt = new DataTable();
            supplierInfo = new Models.SupplierInfo();
            supplierController = new Controllers.SupplierController();
            InitializeComponent();
        }
        private void ClearControls()
        {
            supplierInfo = new Models.SupplierInfo();
            txtCode.Text = supplierController.AutoGenerateCode("sp_Supplier");
            txtName.Text = "";
            txtNRCNO.Text = "";
            txtPerAddress.Text = "";
            txtContAddress.Text = "";
            txtState.Text = "";
            txtCity.Text = "";
            txtPhone1.Text = "";
            txtPhone2.Text = "";
            txtEmail.Text = "";
            cbInactive.Checked = false;
            btnSave.Text = "သိမ်းမည်";
            txtName.Focus();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            if(_frmMain != null)
            {
                _frmMain.showMainScreen();
            }
            else
            {
                this.Close();
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
            if (!baseFunctions.Validation(txtPhone1))
            {
                Base.FrmMsg frmMsg = new Base.FrmMsg("ဖြည့်ရန်လိုအပ်", "ဖုန်းနံပါတ် ဖြည့်ပါ", "", 2);
                frmMsg.ShowDialog();
                txtPhone1.Focus();
                return;
            }
            supplierInfo.Code = txtCode.Text;
            supplierInfo.Name = txtName.Text;
            supplierInfo.NRCNO = txtNRCNO.Text;
            supplierInfo.PerAddress = txtPerAddress.Text;
            supplierInfo.ContAddress = txtContAddress.Text;
            supplierInfo.State = txtState.Text;
            supplierInfo.City = txtCity.Text;
            supplierInfo.Phone1 = txtPhone1.Text;
            supplierInfo.Phone2 = txtPhone2.Text;
            supplierInfo.Email = txtEmail.Text;
            if (cbInactive.Checked)
            {
                supplierInfo.Inactive = true;
            }
            else
            {
                supplierInfo.Inactive = false;
            }
            if (btnSave.Text != "ပြုပြင်မည်")
            {
                supplierController.Insert(supplierInfo, "sp_Supplier");
            }
            else
            {
                supplierController.Update(supplierInfo, "sp_Supplier");
            }
            ClearControls();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void BtnSupplierSearch_Click(object sender, EventArgs e)
        {
            Base.FrmSearch frmSearch = new Base.FrmSearch("sp_Supplier", new string[] { "SupplierID" });
            frmSearch.ShowDialog();
            string ID = frmSearch.ID;
            if (ID != "")
            {
                dt = supplierController.SelectByID("sp_Supplier", "SupplierID", ID);
                supplierInfo.SupplierID = dt.Rows[0]["SupplierID"].ToString();
                txtCode.Text = dt.Rows[0]["Code"].ToString();
                txtName.Text = dt.Rows[0]["Name"].ToString();
                txtNRCNO.Text = dt.Rows[0]["NRCNO"].ToString();
                txtPerAddress.Text = dt.Rows[0]["PerAddress"].ToString();
                txtContAddress.Text = dt.Rows[0]["ContAddress"].ToString();
                txtState.Text = dt.Rows[0]["State"].ToString();
                txtCity.Text = dt.Rows[0]["City"].ToString();
                txtPhone1.Text = dt.Rows[0]["Phone1"].ToString();
                txtPhone2.Text = dt.Rows[0]["Phone2"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                cbInactive.Checked = Convert.ToBoolean(dt.Rows[0]["Inactive"]);
                btnSave.Text = "ပြုပြင်မည်";
            }
        }

        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}
