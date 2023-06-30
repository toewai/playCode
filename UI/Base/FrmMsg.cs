using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Base
{
    public partial class FrmMsg : Form
    {
        public String Title = "";
        public String Message = "";
        public string btnName = "";
        public int setTimer = 5;
        public FrmMsg()
        {
            InitializeComponent();
        }
        public FrmMsg(String title,String Msg,string BName,int settimer = 5)
        {
            Title = title;
            btnName = BName;
            if(btnName == "သိမ်းမည်")
            {
                Message = "အချက်အလက် သိမ်းဆည်းပြီးပြီ";
            }else if(btnName == "ပြုပြင်မည်")
            {
                Message = "အချက်အလက် ပြုပြင်ပြီးပြီ";
            }
            else 
            {
                Message = Msg;
            }
            setTimer = settimer;
            InitializeComponent();
        }

        private void FrmMsg_Load(object sender, EventArgs e)
        {
            this.Text = Title;
            label1.Text = Message;
            timerClose.Interval = setTimer * 1000;
            timerClose.Enabled = true;
            timerClose.Tick += new EventHandler(MyFormClose_Trick);
            timerClose.Start();
        }
        private void MyFormClose_Trick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
