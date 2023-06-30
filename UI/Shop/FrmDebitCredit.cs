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
    public partial class FrmDebitCredit : Form
    {
        FrmMain _frmMain;
        Models.DebitCreditInfo debitCreditInfo;
        Controllers.DebitCreditController debitCreditController;
        DataTable dt;
        public FrmDebitCredit()
        {
            InitializeComponent();
        }
        public FrmDebitCredit(FrmMain frmMain)
        {
            _frmMain = frmMain;
            dt = new DataTable();
            debitCreditInfo = new Models.DebitCreditInfo();
            debitCreditController = new Controllers.DebitCreditController();
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            _frmMain.showMainScreen();
        }
        private void ClearControls()
        {
            debitCreditInfo = new Models.DebitCreditInfo();
            txtCode.Text = debitCreditController.AutoGenerateCode("sp_DebitCredit");
            txtName.Text = "";
            rbIncome.Checked = true;
            rbOutcome.Checked = false;
            btnSave.Text = "သိမ်းမည်";
            txtName.Focus();
        }
        private void Bind_dgv()
        {
            Base.UIBaseFunctions ubFunctions = new Base.UIBaseFunctions();
            ubFunctions.BindDGV(dgvDebitCredit, "sp_DebitCredit", new string[] { "DebitCreditID" });
            if (cboSearchOptions.Items.Count < 1)
            {
                ubFunctions.BindSearchOptions(dgvDebitCredit, cboSearchOptions);
            }
        }

        private void FrmDebitCredit_Load(object sender, EventArgs e)
        {
            ClearControls();
            Bind_dgv();
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
            debitCreditInfo.Code = txtCode.Text;
            debitCreditInfo.Name = txtName.Text;
            if (rbIncome.Checked)
            {
                debitCreditInfo.Income = true;
            }
            else
            {
                debitCreditInfo.Income = false;
            }
            if (rbOutcome.Checked)
            {
                debitCreditInfo.Outcome = true;
            }
            else
            {
                debitCreditInfo.Outcome = false;
            }
            if (btnSave.Text != "ပြုပြင်မည်")
            {
                debitCreditController.Insert(debitCreditInfo, "sp_DebitCredit");
            }
            else
            {
                debitCreditController.Update(debitCreditInfo, "sp_DebitCredit");
            }
            ClearControls();
            Bind_dgv();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void DgvDebitCredit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dt = debitCreditController.SelectAll("sp_DebitCredit");
            if (dt.Rows.Count > 0)
            {
                string DebitCreditID = dgvDebitCredit.Rows[dgvDebitCredit.CurrentCell.RowIndex].Cells["DebitCreditID"].Value.ToString();
                dt = debitCreditController.SelectByID("sp_DebitCredit", "DebitCreditID", DebitCreditID);
                debitCreditInfo.DebitCreditID = dt.Rows[0]["DebitCreditID"].ToString();
                txtCode.Text = dt.Rows[0]["Code"].ToString();
                txtName.Text = dt.Rows[0]["Name"].ToString();
                rbIncome.Checked = Convert.ToBoolean(dt.Rows[0]["Income"]);
                rbOutcome.Checked = Convert.ToBoolean(dt.Rows[0]["Outcome"]);
                btnSave.Text = "ပြုပြင်မည်";
            }
        }

        private void cboSearchOptions_TextChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            for (int j = 0; j < dgvDebitCredit.RowCount; j++)
            {
                dgvDebitCredit.Rows[j].Visible = true;
            }
            txtSearch.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Base.UIBaseFunctions ubFunctions = new Base.UIBaseFunctions();
            CurrencyManager cm = (CurrencyManager)BindingContext[dgvDebitCredit.DataSource];
            cm.SuspendBinding();
            ubFunctions.SearchTextChanged(dgvDebitCredit, cboSearchOptions, txtSearch);
            cm.ResumeBinding();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                for (int j = 0; j < dgvDebitCredit.RowCount; j++)
                {
                    dgvDebitCredit.Rows[j].Visible = true;
                }
            }
        }
    }
}
