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
    public partial class FrmSearch : Form
    {
        Base.UIBaseFunctions ubFunctions = new Base.UIBaseFunctions();
        public string storedProcedure = "";
        public string[] hideFields;
        public string ID = "";
        public FrmSearch()
        {
            InitializeComponent();
        }
        public FrmSearch(string StoredProcedure, string [] HideFields)
        {
            storedProcedure = StoredProcedure;
            hideFields = HideFields;
            InitializeComponent();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            dgvDefaultStyle.RowTemplate.Height = 40;
            ubFunctions.BindDGV(dgvDefaultStyle, storedProcedure, hideFields);
            for(int i=0; i<dgvDefaultStyle.ColumnCount; i++)
            {
                if (dgvDefaultStyle.Columns[i].Visible)
                {
                    object itemObject = new object();
                    itemObject = dgvDefaultStyle.Columns[i].HeaderText;
                    cboSearchOptions.Items.Add(itemObject);
                }
            }
        }

        private void DgvDefaultStyle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDefaultStyle.Rows.Count > 0)
            {
                ID = dgvDefaultStyle.Rows[dgvDefaultStyle.CurrentCell.RowIndex].Cells[0].Value.ToString();
                this.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cboSearchOptions.Text == "")
            {
                MessageBox.Show("ရွေးရန် ဘေးရှိ ခလုတ်ကို နှိပ်ပြီး တစ်ခုခုကို ရွေးချယ်ပေးပါ။");
            }
            else
            {
                if(txtSearch.Text == "")
                {
                    for (int j = 0; j < dgvDefaultStyle.RowCount; j++)
                    {
                        dgvDefaultStyle.Rows[j].Visible = true;
                    }
                }
                else
                {
                    int columnIndex = 0;
                    for (int i = 0; i < dgvDefaultStyle.ColumnCount; i++)
                    {
                        if (dgvDefaultStyle.Columns[i].HeaderText == cboSearchOptions.Text)
                        {
                            columnIndex = i;
                        }
                    }
                    for (int j = 0; j < dgvDefaultStyle.RowCount; j++)
                    {
                        if (!dgvDefaultStyle.Rows[j].Cells[columnIndex].Value.ToString().Contains(txtSearch.Text))
                        {
                            dgvDefaultStyle.Rows[j].Visible = false;
                        }
                    }
                }
            }
            
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back)
            {
                for (int j = 0; j < dgvDefaultStyle.RowCount; j++)
                {
                    dgvDefaultStyle.Rows[j].Visible = true;
                }
            }
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

        private void dgvDefaultStyle_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvDefaultStyle.Rows.Count > 0 && e.KeyCode == Keys.Enter)
            {
                ID = dgvDefaultStyle.Rows[dgvDefaultStyle.CurrentCell.RowIndex].Cells[0].Value.ToString();
                this.Close();
            }
        }

    }
}
