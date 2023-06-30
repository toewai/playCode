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
    public partial class FrmSalePerson : Form
    {
        FrmMain _frmMain;
        Models.SalePersonInfo salePersonInfo;
        Controllers.SalePersonController salePersonController;
        DataTable dt;
        public FrmSalePerson()
        {
            InitializeComponent();
        }
        public FrmSalePerson(FrmMain frmMain)
        {
            _frmMain = frmMain;
            dt = new DataTable();
            salePersonInfo = new Models.SalePersonInfo();
            salePersonController = new Controllers.SalePersonController();
            InitializeComponent();
        }
        private void ClearControls()
        {
            salePersonInfo = new Models.SalePersonInfo();
            txtCode.Text = salePersonController.AutoGenerateCode("sp_SalePerson");
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
            if (!baseFunctions.Validation(txtNRCNO))
            {
                Base.FrmMsg frmMsg = new Base.FrmMsg("ဖြည့်ရန်လိုအပ်", "မှတ်ပုံတင် နံပါတ် ဖြည့်ပါ", "", 2);
                frmMsg.ShowDialog();
                txtNRCNO.Focus();
                return;
            }
            if (!baseFunctions.Validation(txtPerAddress))
            {
                Base.FrmMsg frmMsg = new Base.FrmMsg("ဖြည့်ရန်လိုအပ်", "လိပ်စာ ဖြည့်ပါ", "", 2);
                frmMsg.ShowDialog();
                txtPerAddress.Focus();
                return;
            }
            if (!baseFunctions.Validation(txtPhone1))
            {
                Base.FrmMsg frmMsg = new Base.FrmMsg("ဖြည့်ရန်လိုအပ်", "ဖုန်းနံပါတ် ဖြည့်ပါ", "", 2);
                frmMsg.ShowDialog();
                txtPhone1.Focus();
                return;
            }
            salePersonInfo.Code = txtCode.Text;
            salePersonInfo.Name = txtName.Text;
            salePersonInfo.NRCNO = txtNRCNO.Text;
            salePersonInfo.PerAddress = txtPerAddress.Text;
            salePersonInfo.ContAddress = txtContAddress.Text;
            salePersonInfo.State = txtState.Text;
            salePersonInfo.City = txtCity.Text;
            salePersonInfo.Phone1 = txtPhone1.Text;
            salePersonInfo.Phone2 = txtPhone2.Text;
            salePersonInfo.Email = txtEmail.Text;
            if (cbInactive.Checked)
            {
                salePersonInfo.Inactive = true;
            }
            else
            {
                salePersonInfo.Inactive = false;
            }
            if (btnSave.Text != "ပြုပြင်မည်")
            {
                salePersonController.Insert(salePersonInfo, "sp_SalePerson");
            }
            else
            {
                salePersonController.Update(salePersonInfo, "sp_SalePerson");
            }
            ClearControls();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void BtnSalePerson_Click(object sender, EventArgs e)
        {
            Base.FrmSearch frmSearch = new Base.FrmSearch("sp_SalePerson", new string[] { "SalePersonID" });
            frmSearch.ShowDialog();
            string ID = frmSearch.ID;
            if(ID != "")
            {
                dt = salePersonController.SelectByID("sp_SalePerson", "SalePersonID", ID);
                salePersonInfo.SalePersonID = dt.Rows[0]["SalePersonID"].ToString();
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

        private void FrmSalePerson_Load(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}
