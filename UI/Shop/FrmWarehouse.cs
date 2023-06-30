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
    public partial class FrmWarehouse : Form
    {
        FrmMain _frmMain;
        Models.WarehouseInfo warehouseinfo;
        Controllers.WarehouseController warehouseController;
        DataTable dt;
        public FrmWarehouse()
        {
            InitializeComponent();
        }
        public FrmWarehouse(FrmMain frmMain)
        {
            _frmMain = frmMain;
            dt = new DataTable();
            warehouseinfo = new Models.WarehouseInfo();
            warehouseController = new Controllers.WarehouseController();
            InitializeComponent();
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
            warehouseinfo.Code = txtCode.Text;
            warehouseinfo.Name = txtName.Text;
            if (cbDefault.Checked)
            {
                warehouseinfo.UseDefault = true;
            }
            else
            {
                warehouseinfo.UseDefault = false;
            }
            if (cbInactive.Checked)
            {
                warehouseinfo.Inactive = true;
            }
            else
            {
                warehouseinfo.Inactive = false;
            }
            if (btnSave.Text != "ပြုပြင်မည်")
            {
                warehouseController.Insert(warehouseinfo, "sp_Warehouse");
            }
            else
            {
                warehouseController.Update(warehouseinfo, "sp_Warehouse");
            }
            ClearControls();
            Bind_dgvWarehouse();
        }
        private void Bind_dgvWarehouse()
        {
            Base.UIBaseFunctions ubFunctions = new Base.UIBaseFunctions();
            ubFunctions.BindDGV(dgvWarehouse, "sp_Warehouse", new string[] { "WarehouseID" });
            if (cboSearchOptions.Items.Count < 1)
            {
                ubFunctions.BindSearchOptions(dgvWarehouse, cboSearchOptions);
            }
        }
        private void ClearControls()
        {
            warehouseinfo = new Models.WarehouseInfo();
            txtCode.Text = warehouseController.AutoGenerateCode("sp_Warehouse") ;
            txtName.Text = "";
            cbDefault.Checked = false;
            cbInactive.Checked = false;
            btnSave.Text = "သိမ်းမည်";
            txtName.Focus();
        }
        private void FrmWarehouse_Load(object sender, EventArgs e)
        {
            ClearControls();
            Bind_dgvWarehouse();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            Base.UIBaseFunctions ubFunctions = new Base.UIBaseFunctions();
            CurrencyManager cm = (CurrencyManager)BindingContext[dgvWarehouse.DataSource];
            cm.SuspendBinding();
            ubFunctions.SearchTextChanged(dgvWarehouse, cboSearchOptions, txtSearch);
            cm.ResumeBinding();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void dgvWarehouse_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dt = warehouseController.SelectAll("sp_Warehouse");
            if (dt.Rows.Count > 0)
            {
                string warehouseID = dgvWarehouse.Rows[dgvWarehouse.CurrentCell.RowIndex].Cells["WarehouseID"].Value.ToString();
                dt = warehouseController.SelectByID("sp_Warehouse", "WarehouseID", warehouseID);
                warehouseinfo.WarehouseID = dt.Rows[0]["WarehouseID"].ToString();
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
            for (int j = 0; j < dgvWarehouse.RowCount; j++)
            {
                dgvWarehouse.Rows[j].Visible = true;
            }
            txtSearch.Focus();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                for (int j = 0; j < dgvWarehouse.RowCount; j++)
                {
                    dgvWarehouse.Rows[j].Visible = true;
                }
            }
        }
    }
}
