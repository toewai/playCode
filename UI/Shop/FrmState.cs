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
    public partial class FrmState : Form
    {
        FrmMain _frmMain;
        Models.StateInfo stateInfo;
        Controllers.StateController stateController;
        DataTable dt;
        public FrmState()
        {
            InitializeComponent();
        }
        public FrmState(FrmMain frmMain)
        {
            _frmMain = frmMain;
            dt = new DataTable();
            stateInfo = new Models.StateInfo();
            stateController = new Controllers.StateController();
            InitializeComponent();
        }
        private void ClearControls()
        {
            stateInfo = new Models.StateInfo();
            txtCode.Text = stateController.AutoGenerateCode("sp_State");
            txtStateName.Text = "";
            txtCityName.Text = "";
            btnSave.Text = "သိမ်းမည်";
            txtStateName.Focus();
        }
        private void Bind_dgv()
        {
            Base.UIBaseFunctions ubFunctions = new Base.UIBaseFunctions();
            ubFunctions.BindDGV(dgvDefaultStyle, "sp_State", new string[] { "StateID" });
            if (cboSearchOptions.Items.Count < 1)
            {
                ubFunctions.BindSearchOptions(dgvDefaultStyle, cboSearchOptions);
            }
        }
        private void FrmState_Load(object sender, EventArgs e)
        {
            Bind_dgv();
            ClearControls();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            _frmMain.showMainScreen();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Base.UIBaseFunctions baseFunctions = new Base.UIBaseFunctions();
            if (!baseFunctions.Validation(txtStateName))
            {
                Base.FrmMsg frmMsg = new Base.FrmMsg("ဖြည့်ရန်လိုအပ်", "တိုင်း/ပြည်နယ် အမည် ဖြည့်ပါ", "", 2);
                frmMsg.ShowDialog();
                txtStateName.Focus();
                return;
            }
            if (!baseFunctions.Validation(txtCityName))
            {
                Base.FrmMsg frmMsg = new Base.FrmMsg("ဖြည့်ရန်လိုအပ်", "မြို့ အမည် ဖြည့်ပါ", "", 2);
                frmMsg.ShowDialog();
                txtCityName.Focus();
                return;
            }
            stateInfo.Code = txtCode.Text;
            stateInfo.State = txtStateName.Text;
            stateInfo.City = txtCityName.Text;
            if (btnSave.Text != "ပြုပြင်မည်")
            {
                stateController.Insert(stateInfo, "sp_State");
            }
            else
            {
                stateController.Update(stateInfo, "sp_State");
            }
            ClearControls();
            Bind_dgv();
        }

        private void DgvDefaultStyle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dt = stateController.SelectAll("sp_State");
            if (dt.Rows.Count > 0)
            {
                string DebitCreditID = dgvDefaultStyle.Rows[dgvDefaultStyle.CurrentCell.RowIndex].Cells["StateID"].Value.ToString();
                dt = stateController.SelectByID("sp_State", "StateID", DebitCreditID);
                stateInfo.StateID = dt.Rows[0]["StateID"].ToString();
                txtCode.Text = dt.Rows[0]["Code"].ToString();
                txtStateName.Text = dt.Rows[0]["State"].ToString();
                txtCityName.Text = dt.Rows[0]["City"].ToString();
                btnSave.Text = "ပြုပြင်မည်";
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void cboSearchOptions_TextChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            for (int j = 0; j < dgvDefaultStyle.RowCount; j++)
            {
                dgvDefaultStyle.Rows[j].Visible = true;
            }
            txtSearch.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Base.UIBaseFunctions ubFunctions = new Base.UIBaseFunctions();
            CurrencyManager cm = (CurrencyManager)BindingContext[dgvDefaultStyle.DataSource];
            cm.SuspendBinding();
            ubFunctions.SearchTextChanged(dgvDefaultStyle, cboSearchOptions, txtSearch);
            cm.ResumeBinding();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                for (int j = 0; j < dgvDefaultStyle.RowCount; j++)
                {
                    dgvDefaultStyle.Rows[j].Visible = true;
                }
            }
        }
    }
}
