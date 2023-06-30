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
    public partial class FrmCounter : Form
    {
        FrmMain _frmMain;
        Models.CounterInfo counterInfo;
        Controllers.CountController counterController;
        DataTable dt;
        public FrmCounter()
        {
            InitializeComponent();
        }
        public FrmCounter(FrmMain frmMain)
        {
            _frmMain = frmMain;
            dt = new DataTable();
            counterController = new Controllers.CountController();
            counterInfo = new Models.CounterInfo();
            InitializeComponent();
        }
        private void ClearControls()
        {
            counterInfo = new Models.CounterInfo();
            txtCode.Text = counterController.AutoGenerateCode("sp_Counter");
            txtName.Text = "";
            cbDefault.Checked = false;
            txtDefaultName.Text = "";
            cbInactive.Checked = false;
            btnSave.Text = "သိမ်းမည်";
            txtName.Focus();
        }
        private void Bind_dgv()
        {
            Base.UIBaseFunctions ubFunctions = new Base.UIBaseFunctions();
            ubFunctions.BindDGV(dgvDefaultStyle, "sp_Counter", new string[] { "CounterID" });
            if(cboSearchOptions.Items.Count < 1)
            {
                ubFunctions.BindSearchOptions(dgvDefaultStyle, cboSearchOptions);
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            _frmMain.showMainScreen();
        }

        private void FrmCounter_Load(object sender, EventArgs e)
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
            counterInfo.Code = txtCode.Text;
            counterInfo.Name = txtName.Text;
            if (cbDefault.Checked)
            {
                counterInfo.UsedDefault = true;
            }
            else
            {
                counterInfo.UsedDefault = false;
            }
            counterInfo.DefaultName = txtDefaultName.Text;
            if (cbInactive.Checked)
            {
                counterInfo.Inactive = true;
            }
            else
            {
                counterInfo.Inactive = false;
            }
            if (btnSave.Text != "ပြုပြင်မည်")
            {
                counterController.Insert(counterInfo, "sp_Counter");
            }
            else
            {
                counterController.Update(counterInfo, "sp_Counter");
            }
            ClearControls();
            Bind_dgv();
        }

        private void DgvDefaultStyle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dt = counterController.SelectAll("sp_DebitCredit");
            if (dt.Rows.Count > 0)
            {
                string DebitCreditID = dgvDefaultStyle.Rows[dgvDefaultStyle.CurrentCell.RowIndex].Cells["CounterID"].Value.ToString();
                dt = counterController.SelectByID("sp_Counter", "CounterID", DebitCreditID);
                counterInfo.CounterID = dt.Rows[0]["CounterID"].ToString();
                txtCode.Text = dt.Rows[0]["Code"].ToString();
                txtName.Text = dt.Rows[0]["Name"].ToString();
                txtDefaultName.Text = dt.Rows[0]["DefaultName"].ToString();
                cbDefault.Checked = Convert.ToBoolean(dt.Rows[0]["UsedDefault"]);
                cbInactive.Checked = Convert.ToBoolean(dt.Rows[0]["Inactive"]);
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
