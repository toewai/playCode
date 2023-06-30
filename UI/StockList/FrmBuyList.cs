using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.StockList
{
    public partial class FrmBuyList : Form
    {
        FrmMain _frmMain;
        public FrmBuyList()
        {
            InitializeComponent();
        }
        public FrmBuyList(FrmMain frmMain)
        {
            _frmMain = frmMain;
            InitializeComponent();
        }
    }
}
