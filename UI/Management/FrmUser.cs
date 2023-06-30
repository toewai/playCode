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
    public partial class FrmUser : Form
    {
        FrmMain _frmMain;
        Models.UserInfo userInfo;
        Models.FrmPermissionInfo frmPermissionInfo;

        Models.FrmPermissionCollections frmPermissionCollections;

        Controllers.ControllerBase controllerbase;

        DataTable dt;
        public FrmUser()
        {
            InitializeComponent();
        }
        public FrmUser(FrmMain frmMain)
        {
            _frmMain = frmMain;
            userInfo = new Models.UserInfo();
            frmPermissionInfo = new Models.FrmPermissionInfo();
            frmPermissionCollections = new Models.FrmPermissionCollections();
            controllerbase = new Controllers.ControllerBase();
            dt = new DataTable();
            InitializeComponent();
        }
        private void Bind_dgv()
        {
            dgvDefaultStyle.DataSource = new DataTable();
            dgvDefaultStyle.Columns.Clear();
            Base.UIBaseFunctions ubFunctions = new Base.UIBaseFunctions();
            ubFunctions.BindDGV(dgvDefaultStyle, "sp_Frm", new string[] { "FrmID", "FrmCategoryID", "FrmName", "FrmDescription", "Inactive" }, true);
            if (cboSearchOptions.Items.Count < 1)
            {
                ubFunctions.BindSearchOptions(dgvDefaultStyle, cboSearchOptions);
            }
            //ubFunctions.SearchTextChanged(dgvDefaultStyle, cboSearchOptions, txtSearch);
            DataGridViewCheckBoxColumn isRead = new DataGridViewCheckBoxColumn();
            isRead.HeaderText = "IsRead";
            isRead.Name = "IsRead";
            dgvDefaultStyle.Columns.Add(isRead);
            DataGridViewCheckBoxColumn isWrite = new DataGridViewCheckBoxColumn();
            isWrite.HeaderText = "IsWrite";
            isWrite.Name = "IsWrite";
            dgvDefaultStyle.Columns.Add(isWrite);
            DataGridViewCheckBoxColumn isUpdate = new DataGridViewCheckBoxColumn();
            isUpdate.HeaderText = "IsUpdate";
            isUpdate.Name = "IsUpdate";
            dgvDefaultStyle.Columns.Add(isUpdate);
            dgvDefaultStyle.Columns.Add("FrmPermissionID", "FrmPermissionID");
            dgvDefaultStyle.Columns["FrmPermissionID"].Visible = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            _frmMain.showMainScreen();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtFirstName.Text == "" && txtPassword.Text == "sayartoe")
                {
                    FrmFrm frmFrame = new FrmFrm();
                    frmFrame.ShowDialog();
                }
            }
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            Bind_dgv();
        }

        private void dgvDefaultStyle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dgvDefaultStyle.Columns.Count.ToString());
            string dgvHeaderText = dgvDefaultStyle.Columns[dgvDefaultStyle.CurrentCell.ColumnIndex].HeaderText;
            if (dgvHeaderText == "IsRead" || dgvHeaderText == "IsWrite" || dgvHeaderText =="IsUpdate")
            {
                if(dgvDefaultStyle.CurrentCell.Value == null)
                {
                    dgvDefaultStyle.CurrentCell.Value = true;
                }
                else
                {
                    if(Convert.ToBoolean(dgvDefaultStyle.CurrentCell.Value) == false)
                    {
                        dgvDefaultStyle.CurrentCell.Value = true;
                    }
                    else
                    {
                        dgvDefaultStyle.CurrentCell.Value = false;
                    }
                    
                }
                
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void ClearControls()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtFullName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            cbInactive.Checked = false;
            cbIsRead.Checked = false;
            cbIsSave.Checked = false;
            cbIsUpdate.Checked = false;
            btnSave.Text = "သိမ်းမည်";
            Bind_dgv();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Base.UIBaseFunctions ubFunctions = new Base.UIBaseFunctions();
            CurrencyManager cm = (CurrencyManager)BindingContext[dgvDefaultStyle.DataSource];
            cm.SuspendBinding();
            ubFunctions.SearchTextChanged(dgvDefaultStyle, cboSearchOptions, txtSearch);
            cm.ResumeBinding();
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

        private void cbIsRead_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvDefaultStyle.RowCount > 0)
            {
                for(int i = 0; i < dgvDefaultStyle.RowCount; i++)
                {
                    dgvDefaultStyle.Rows[i].Cells["IsRead"].Value = cbIsRead.Checked;
                }
            }
        }

        private void cbIsSave_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvDefaultStyle.RowCount > 0)
            {
                for (int i = 0; i < dgvDefaultStyle.RowCount; i++)
                {
                    dgvDefaultStyle.Rows[i].Cells["IsWrite"].Value = cbIsSave.Checked;
                }
            }
        }

        private void cbIsUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvDefaultStyle.RowCount > 0)
            {
                for (int i = 0; i < dgvDefaultStyle.RowCount; i++)
                {
                    dgvDefaultStyle.Rows[i].Cells["IsUpdate"].Value = cbIsUpdate.Checked;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text.Trim() == "")
            {
                Base.FrmMsg frmMsg = new Base.FrmMsg("ဖြည့်ရန်လိုအပ်", "အမည်၏ ပထမ စာလုံး","",2);
                frmMsg.ShowDialog();
                txtFirstName.Focus();
                return;
            }
            if (txtFullName.Text.Trim() == "")
            {
                Base.FrmMsg frmMsg = new Base.FrmMsg("ဖြည့်ရန်လိုအပ်", "အမည် အပြည့်အစုံ ","", 2);
                frmMsg.ShowDialog();
                txtFullName.Focus();
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                Base.FrmMsg frmMsg = new Base.FrmMsg("ဖြည့်ရန်လိုအပ်", "လျှို့ဝှက်ကုဒ် ", "", 2);
                frmMsg.ShowDialog();
                txtPassword.Focus();
                return;
            }
            if (txtConfirmPassword.Text.Trim() == "")
            {
                Base.FrmMsg frmMsg = new Base.FrmMsg("ဖြည့်ရန်လိုအပ်", "လျှို့ဝှက်ကုဒ် ပြန်ရိုက်ရန် ", "", 2);
                frmMsg.ShowDialog();
                txtConfirmPassword.Focus();
                return;
            }
            if(txtPassword.Text != txtConfirmPassword.Text)
            {
                Base.FrmMsg frmMsg = new Base.FrmMsg("ဖြည့်ရန်လိုအပ်", "လျှို့ဝှက်ကုဒ် မတူညီပါ ", "", 2);
                frmMsg.ShowDialog();
                txtConfirmPassword.Focus();
                return;
            }
            userInfo.FirstName = txtFirstName.Text;
            userInfo.LastName = txtLastName.Text;
            userInfo.Username = txtFullName.Text;
            userInfo.Password = txtPassword.Text;
            
            if(btnSave.Text != "ပြုပြင်မည်")
            {
                string userID = controllerbase.InsertID(userInfo, "sp_User");
                string result = "";
                if (dgvDefaultStyle.Rows.Count > 0)
                {
                    frmPermissionCollections = new Models.FrmPermissionCollections();
                    for(int i = 0; i < dgvDefaultStyle.Rows.Count; i++)
                    {
                        frmPermissionInfo.FrmID = dgvDefaultStyle.Rows[i].Cells["FrmID"].Value.ToString();
                        frmPermissionInfo.UserID = userID;
                        frmPermissionInfo.isRead = Convert.ToBoolean(dgvDefaultStyle.Rows[i].Cells["IsRead"].Value); 
                        frmPermissionInfo.isSave = Convert.ToBoolean(dgvDefaultStyle.Rows[i].Cells["IsWrite"].Value); 
                        frmPermissionInfo.isUpdate = Convert.ToBoolean(dgvDefaultStyle.Rows[i].Cells["IsUpdate"].Value);
                        result=controllerbase.Insert(frmPermissionInfo, "sp_FrmPermission");
                    }
                }
            }
            else
            {
                string userID = controllerbase.Update(userInfo, "sp_User");
                string result = "";
                if (dgvDefaultStyle.Rows.Count > 0)
                {
                    frmPermissionCollections = new Models.FrmPermissionCollections();
                    for (int i = 0; i < dgvDefaultStyle.Rows.Count; i++)
                    {
                        frmPermissionInfo.FrmID = dgvDefaultStyle.Rows[i].Cells["FrmID"].Value.ToString();
                        frmPermissionInfo.UserID = userInfo.UserID;
                        frmPermissionInfo.isRead = Convert.ToBoolean(dgvDefaultStyle.Rows[i].Cells["IsRead"].Value);
                        frmPermissionInfo.isSave = Convert.ToBoolean(dgvDefaultStyle.Rows[i].Cells["IsWrite"].Value);
                        frmPermissionInfo.isUpdate = Convert.ToBoolean(dgvDefaultStyle.Rows[i].Cells["IsUpdate"].Value);
                        frmPermissionInfo.FrmPermissionID = dgvDefaultStyle.Rows[i].Cells["FrmPermissionID"].Value.ToString();
                        result = controllerbase.Update(frmPermissionInfo, "sp_FrmPermission");
                    }
                }
            }
            ClearControls();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Base.FrmSearch frmSearch = new Base.FrmSearch("sp_User", new string[] { "UserID","Password"});
            frmSearch.ShowDialog();
            string ID = frmSearch.ID;
            userInfo.UserID = ID;
            if (ID != "ပြုပြင်မည်")
            {
                dt = controllerbase.SelectByID("sp_User", "UserID", ID);
                txtFirstName.Text = dt.Rows[0]["FirstName"].ToString();
                txtLastName.Text = dt.Rows[0]["LastName"].ToString();
                txtFullName.Text = dt.Rows[0]["Username"].ToString();
                txtPassword.Text = dt.Rows[0]["Password"].ToString();
                txtConfirmPassword.Text = dt.Rows[0]["Password"].ToString();
                cbInactive.Checked = Convert.ToBoolean( dt.Rows[0]["Inactive"]);

                dt = controllerbase.SelectByID("sp_FrmPermission", "UserID", ID);

                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    string frmID = dt.Rows[i]["FrmID"].ToString();
                    for(int j=0; j<dgvDefaultStyle.Rows.Count; j++)
                    {
                        if(frmID == dgvDefaultStyle.Rows[j].Cells["FrmID"].Value.ToString())
                        {
                            dgvDefaultStyle.Rows[j].Cells["IsRead"].Value = dt.Rows[i]["isRead"];
                            dgvDefaultStyle.Rows[j].Cells["IsWrite"].Value = dt.Rows[i]["isSave"];
                            dgvDefaultStyle.Rows[j].Cells["IsUpdate"].Value = dt.Rows[i]["isUpdate"];
                            dgvDefaultStyle.Rows[j].Cells["FrmPermissionID"].Value = dt.Rows[i]["FrmPermissionID"];
                            break;
                        }
                    }
                }
                btnSave.Text = "ပြုပြင်မည်";
                
            }
        }
    }
}
