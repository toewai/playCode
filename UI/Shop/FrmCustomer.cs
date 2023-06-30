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
    public partial class FrmCustomer : Form
    {
        FrmMain _frmMain;
        Models.CustomerInfo customerInfo;
        Controllers.CustomerController customerController;
        DataTable dt;
        public FrmCustomer()
        {
            InitializeComponent();
        }
        public FrmCustomer(FrmMain frmMain)
        {
            _frmMain = frmMain;
            dt = new DataTable();
            customerInfo = new Models.CustomerInfo();
            customerController = new Controllers.CustomerController();
            InitializeComponent();
        }
        private void ClearControls()
        {
            customerInfo = new Models.CustomerInfo();
            txtCode.Text = customerController.AutoGenerateCode("sp_Customer");
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
            _frmMain.showMainScreen();
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
            customerInfo.Code = txtCode.Text;
            customerInfo.Name = txtName.Text;
            customerInfo.NRCNO = txtNRCNO.Text;
            customerInfo.PerAddress = txtPerAddress.Text;
            customerInfo.ContAddress = txtContAddress.Text;
            customerInfo.State = txtState.Text;
            customerInfo.City = txtCity.Text;
            customerInfo.Phone1 = txtPhone1.Text;
            customerInfo.Phone2 = txtPhone2.Text;
            customerInfo.Email = txtEmail.Text;
            if (cbInactive.Checked)
            {
                customerInfo.Inactive = true;
            }
            else
            {
                customerInfo.Inactive = false;
            }
            if (btnSave.Text != "ပြုပြင်မည်")
            {
                customerController.Insert(customerInfo, "sp_Customer");
            }
            else
            {
                customerController.Update(customerInfo, "sp_Customer");
            }
            ClearControls();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void BtnCustomerSearch_Click(object sender, EventArgs e)
        {
            Base.FrmSearch frmSearch = new Base.FrmSearch("sp_Customer", new string[] { "CustomerID" });
            frmSearch.ShowDialog();
            string ID = frmSearch.ID;
            if (ID != "")
            {
                dt = customerController.SelectByID("sp_Customer", "CustomerID", ID);
                customerInfo.CustomerID = dt.Rows[0]["CustomerID"].ToString();
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

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}
