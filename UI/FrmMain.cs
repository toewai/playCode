using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        #region Group Box Change
        private void BtnShop_Click(object sender, EventArgs e)
        {
            gbShop.Visible = true;
            gbMain.Visible = false;
            gbShop.Dock = DockStyle.Fill;
        }
        private void BtnStockList_Click(object sender, EventArgs e)
        {
            gbStockList.Visible = true;
            gbMain.Visible = false;
            gbStockList.Dock = DockStyle.Fill;
            groupButton(gbMain);
            btnStockList.FillColor = Color.White;
            btnStockList.ForeColor = Color.Black;
        }
        private void BtnSaleList_Click(object sender, EventArgs e)
        {
            gbSaleList.Visible = true;
            gbMain.Visible = false;
            gbSaleList.Dock = DockStyle.Fill;
            groupButton(gbMain);
            btnSaleList.FillColor = Color.White;
            btnSaleList.ForeColor = Color.Black;
        }
        private void BtnAccount_Click(object sender, EventArgs e)
        {
            gbAccount.Visible = true;
            gbMain.Visible = false;
            gbAccount.Dock = DockStyle.Fill;
            groupButton(gbMain);
            btnAccount.FillColor = Color.White;
            btnAccount.ForeColor = Color.Black;
        }
        private void BtnManagement_Click(object sender, EventArgs e)
        {
            gbManagement.Visible = true;
            gbMain.Visible = false;
            gbManagement.Dock = DockStyle.Fill;
            groupButton(gbMain);
            btnManagement.FillColor = Color.White;
            btnManagement.ForeColor = Color.Black;
        }
        #endregion
        private void FrmMain_Load(object sender, EventArgs e)
        {
            panel1.Width = 273;
            gbMain.Dock = DockStyle.Fill;
        }

        #region Back to Main Picture Box
        private void PbShopBack_Click(object sender, EventArgs e)
        {
            gbShop.Visible = false;
            gbMain.Visible = true;
            showMainScreen();
        }

        private void PbStockListBack_Click(object sender, EventArgs e)
        {
            gbStockList.Visible = false;
            gbMain.Visible = true;
            showMainScreen();
        }

        private void PbSaleListBack_Click(object sender, EventArgs e)
        {
            gbSaleList.Visible = false;
            gbMain.Visible = true;
            showMainScreen();
        }

        private void PbDebitCreditBack_Click(object sender, EventArgs e)
        {
            gbAccount.Visible = false;
            gbMain.Visible = true;
            showMainScreen();
        }

        private void PbManagementBack_Click(object sender, EventArgs e)
        {
            gbManagement.Visible = false;
            gbMain.Visible = true;
            showMainScreen();
        }

        #endregion

        
        

        private void BtnExitMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void showMainScreen()
        {
            groupboxReset();
            mainRadioButtonReset();
            User.FrmUser frmUser = new User.FrmUser() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showOnPannel2(frmUser);
        }
        private void groupboxReset()
        {
            gbMain.Visible = true;
            gbAccount.Visible = false;
            gbManagement.Visible = false;
            gbSaleList.Visible = false;
            gbShop.Visible = false;
            gbStockList.Visible = false;
        }
        private void mainRadioButtonReset()
        {
            btnAccount.Checked = false;
            btnManagement.Checked = false;
            btnSaleList.Checked = false;
            btnShop.Checked = false;
            btnStockList.Checked = false;
        }
        private void showOnPannel2(System.Windows.Forms.Form frm)
        {
            if (panel2.Controls.Count > 0)
            {
                panel2.Controls.Clear();
            }
            panel2.Controls.Add(frm);
            frm.Show();
        }
        private void groupButton(Guna.UI2.WinForms.Guna2GroupBox gb)
        {
            foreach(Control control in gb.Controls)
            {
                if(control.GetType().ToString()== "Guna.UI2.WinForms.Guna2Button")
                {
                    Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)control;
                    btn.FillColor = Color.Gray;
                    btn.ForeColor = Color.White;
                }
            }
            
        }
        #region Group Box Shop
        private void BtnShopInfo_Click(object sender, EventArgs e)
        {
            Shop.FrmShop frmShop = new Shop.FrmShop(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showOnPannel2(frmShop);
            groupButton(gbShop);
            btnShopInfo.FillColor = Color.White;
            btnShopInfo.ForeColor = Color.Black;
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            Shop.FrmCategory frmCategory = new Shop.FrmCategory(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showOnPannel2(frmCategory);
            groupButton(gbShop);
            btnCategory.FillColor = Color.White;
            btnCategory.ForeColor = Color.Black;
        }

        private void BtnSubCategory_Click(object sender, EventArgs e)
        {
            Shop.FrmSubCategory frmSubCategory = new Shop.FrmSubCategory(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showOnPannel2(frmSubCategory);
            groupButton(gbShop);
            btnSubCategory.FillColor = Color.White;
            btnSubCategory.ForeColor = Color.Black;
        }

        private void BtnWarehouse_Click(object sender, EventArgs e)
        {
            Shop.FrmWarehouse frmWarehouse = new Shop.FrmWarehouse(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showOnPannel2(frmWarehouse);
            groupButton(gbShop);
            btnWarehouse.FillColor = Color.White;
            btnWarehouse.ForeColor = Color.Black;
        }

        private void BtnCounter_Click(object sender, EventArgs e)
        {
            Shop.FrmCounter frmCounter = new Shop.FrmCounter(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showOnPannel2(frmCounter);
            groupButton(gbShop);
            btnCounter.FillColor = Color.White;
            btnCounter.ForeColor = Color.Black;
        }

        private void BtnDebitCredit_Click(object sender, EventArgs e)
        {
            Shop.FrmDebitCredit frmDebitCredit = new Shop.FrmDebitCredit(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showOnPannel2(frmDebitCredit);
            groupButton(gbShop);
            btnDebitCredit.FillColor = Color.White;
            btnDebitCredit.ForeColor = Color.Black;
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            Shop.FrmCount frmCount = new Shop.FrmCount(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showOnPannel2(frmCount);
            groupButton(gbShop);
            btnCount.FillColor = Color.White;
            btnCount.ForeColor = Color.Black;
        }

        private void BtnSalePerson_Click(object sender, EventArgs e)
        {
            Shop.FrmSalePerson frmSalePerson = new Shop.FrmSalePerson(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showOnPannel2(frmSalePerson);
            groupButton(gbShop);
            btnSalePerson.FillColor = Color.White;
            btnSalePerson.ForeColor = Color.Black;
        }

        private void BtnState_Click(object sender, EventArgs e)
        {
            Shop.FrmState frmState = new Shop.FrmState(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showOnPannel2(frmState);
            groupButton(gbShop);
            btnState.FillColor = Color.White;
            btnState.ForeColor = Color.Black;
        }

        private void BtnSupplier_Click(object sender, EventArgs e)
        {
            Shop.FrmSupplier frmSupplier = new Shop.FrmSupplier(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showOnPannel2(frmSupplier);
            groupButton(gbShop);
            btnSupplier.FillColor = Color.White;
            btnSupplier.ForeColor = Color.Black;
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            Shop.FrmCustomer frmCustomer = new Shop.FrmCustomer(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showOnPannel2(frmCustomer);
            groupButton(gbShop);
            btnCustomer.FillColor = Color.White;
            btnCustomer.ForeColor = Color.Black;
        }
        #endregion

        #region Group Box Stock List
        private void BtnStock_Click(object sender, EventArgs e)
        {
            StockList.FrmStock frmStock = new StockList.FrmStock(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showOnPannel2(frmStock);
            groupButton(gbStockList);
            btnStock.FillColor = Color.White;
            btnStock.ForeColor = Color.Black;
        }
        private void btnOpenStock_Click(object sender, EventArgs e)
        {
            StockList.FrmOpeningStock frmOpeningStock = new StockList.FrmOpeningStock(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showOnPannel2(frmOpeningStock);
            groupButton(gbStockList);
            btnBuyList.FillColor = Color.White;
            btnBuyList.ForeColor = Color.Black;
        }

        #endregion

        private void btnBuyList_Click(object sender, EventArgs e)
        {
            StockList.FrmBuyList frmBuyList = new StockList.FrmBuyList(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showOnPannel2(frmBuyList);
            groupButton(gbStockList);
            btnBuyList.FillColor = Color.White;
            btnBuyList.ForeColor = Color.Black;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Management.FrmUser frmUser = new Management.FrmUser(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showOnPannel2(frmUser);
            groupButton(gbManagement);
            btnUser.FillColor = Color.White;
            btnUser.ForeColor = Color.Black;
        }
    }
}
