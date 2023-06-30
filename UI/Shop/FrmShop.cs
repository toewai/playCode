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
    public partial class FrmShop : Form
    {
        FrmMain _frmMain;
        Controllers.ShopController shopController;
        DataTable dt;
        Models.ShopInfo shopInfo;
        Base.FrmMsg frmMsg;
        public FrmShop()
        {
            InitializeComponent();
        }
        public FrmShop(FrmMain frmMain)
        {
            _frmMain = frmMain;
            shopController = new Controllers.ShopController();
            shopInfo = new Models.ShopInfo();
            dt = new DataTable();
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            _frmMain.showMainScreen();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            shopInfo.Name = txtShopName.Text;
            shopInfo.Address = txtAddress.Text;
            shopInfo.Phone1 = txtPhone1.Text;
            shopInfo.Phone2 = txtPhone2.Text;
            shopInfo.email = txtEmail.Text;
            if(btnSave.Text != "ပြုပြင်မည်")
            {
                string result = shopController.Insert(shopInfo, "sp_Shop");
                frmMsg = new Base.FrmMsg("ဆိုင်အချက်အလက်", "", btnSave.Text);
                frmMsg.ShowDialog();
                btnSave.Text = "ပြုပြင်မည်";
            }
            else
            {
                string result = shopController.Update(shopInfo, "sp_Shop");
                frmMsg = new Base.FrmMsg("ဆိုင်အချက်အလက်", "", btnSave.Text);
                frmMsg.ShowDialog();
            }
            
            
        }

        private void FrmShop_Load(object sender, EventArgs e)
        {
            dt = shopController.SelectAll("sp_Shop");
            if (dt.Rows.Count > 0)
            {
                dt = shopController.SelectByID("sp_Shop", "ShopID", dt.Rows[0]["ShopID"].ToString());
                shopInfo.ShopID = dt.Rows[0]["ShopID"].ToString();
                txtShopName.Text = dt.Rows[0]["Name"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
                txtPhone1.Text = dt.Rows[0]["Phone1"].ToString();
                txtPhone2.Text = dt.Rows[0]["Phone2"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                btnSave.Text = "ပြုပြင်မည်";
            }
        }
    }
}
