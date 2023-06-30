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
    public partial class FrmCount : Form
    {
        FrmMain _frmMain;
        Models.CountInfo countInfo;
        Controllers.CountController countController;
        DataTable dt;
        public FrmCount()
        {
            InitializeComponent();
        }
        public FrmCount(FrmMain frmMain)
        {
            _frmMain = frmMain;
            dt = new DataTable();
            countInfo = new Models.CountInfo();
            countController = new Controllers.CountController();
            InitializeComponent();
        }
        private void ClearControls()
        {
            countInfo = new Models.CountInfo();
            txtCode.Text = countController.AutoGenerateCode("sp_Count");
            txtName.Text = "";
            cbDefault.Checked = false;
            cbInactive.Checked = false;
            btnSave.Text = "သိမ်းမည်";
            txtName.Focus();
        }
        private void Bind_dgvCategory()
        {
            Base.UIBaseFunctions ubFunctions = new Base.UIBaseFunctions();
            ubFunctions.BindDGV(dgvCount, "sp_Count", new string[] { "CountID" });
            if (cboSearchOptions.Items.Count < 1)
            {
                ubFunctions.BindSearchOptions(dgvCount, cboSearchOptions);
            }
        }
        private void FrmCount_Load(object sender, EventArgs e)
        {
            Bind_dgvCategory();
            ClearControls();
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
            countInfo.Code = txtCode.Text;
            countInfo.Name = txtName.Text;
            if (cbDefault.Checked)
            {
                countInfo.UseDefault = true;
            }
            else
            {
                countInfo.UseDefault = false;
            }
            if (cbInactive.Checked)
            {
                countInfo.Inactive = true;
            }
            else
            {
                countInfo.Inactive = false;
            }
            if (btnSave.Text != "ပြုပြင်မည်")
            {
                countController.Insert(countInfo, "sp_Count");
            }
            else
            {
                countController.Update(countInfo, "sp_Count");
            }
            ClearControls();
            Bind_dgvCategory();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void DgvCount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dt = countController.SelectAll("sp_Count");
            if (dt.Rows.Count > 0)
            {
                string countID = dgvCount.Rows[dgvCount.CurrentCell.RowIndex].Cells["CountID"].Value.ToString();
                dt = countController.SelectByID("sp_Count", "CountID", countID);
                countInfo.CountID = dt.Rows[0]["CountID"].ToString();
                txtCode.Text = dt.Rows[0]["Code"].ToString();
                txtName.Text = dt.Rows[0]["Name"].ToString();
                cbDefault.Checked = Convert.ToBoolean(dt.Rows[0]["UseDefault"]);
                cbInactive.Checked = Convert.ToBoolean(dt.Rows[0]["Inactive"]);
                btnSave.Text = "ပြုပြင်မည်";
            }
        }

        private void cboSearchOptions_TextChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            for (int j = 0; j < dgvCount.RowCount; j++)
            {
                dgvCount.Rows[j].Visible = true;
            }
            txtSearch.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Base.UIBaseFunctions ubFunctions = new Base.UIBaseFunctions();
            CurrencyManager cm = (CurrencyManager)BindingContext[dgvCount.DataSource];
            cm.SuspendBinding();
            ubFunctions.SearchTextChanged(dgvCount, cboSearchOptions, txtSearch);
            cm.ResumeBinding();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                for (int j = 0; j < dgvCount.RowCount; j++)
                {
                    dgvCount.Rows[j].Visible = true;
                }
            }
        }
    }
}
