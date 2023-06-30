using System.Data;
using System.Windows.Forms;
using System.Reflection;
using System;

namespace UI.Base
{
    public class UIBaseFunctions
    {
        Controllers.ControllerBase cb;
        DataTable dt;
        #region Numeric Fucntions
        public static bool CheckNumeric(KeyEventArgs e)
        {
            bool NumericKeys = (((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode == Keys.Decimal) || (e.KeyCode == Keys.OemPeriod) || (e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Back) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)) && e.Modifiers != Keys.Shift);
            return NumericKeys;
        }
        #endregion
        public void BindDGV(Guna.UI2.WinForms.Guna2DataGridView dgv,string StoredProcedure,string[] HideFields,bool selectWithActive=false)
        {
            dt = new DataTable();
            cb = new Controllers.ControllerBase();
            if(selectWithActive == true)
            {
                dt = cb.SelectAllActive(StoredProcedure);
            }
            else
            {
                dt = cb.SelectAll(StoredProcedure);
            }
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top);
            dgv.ColumnHeadersHeight = 40;
            dgv.ReadOnly = true;
            dgv.TabStop = true;
            dgv.RowTemplate.Height = 40;
            if (dt.Rows.Count > 0)
            {
                dgv.DataSource = dt;
                foreach (string hField in HideFields)
                {
                    dgv.Columns[hField].Visible = false;
                }
                
            }
        }
        public void BindDGVWithSelectID(Guna.UI2.WinForms.Guna2DataGridView dgv, string StoredProcedure, string FieldName,string FieldValue, string[] HideFields)
        {
            dt = new DataTable();
            cb = new Controllers.ControllerBase();
            dt = cb.SelectByID(StoredProcedure,FieldName, FieldValue);
            dgv.DataSource = dt;
            foreach (string hField in HideFields)
            {
                dgv.Columns[hField].Visible = false;
            }
            //dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top);
            dgv.ColumnHeadersHeight = 40;
            dgv.RowTemplate.Height = 40;
            //dgv.ReadOnly = true;
            dgv.TabStop = true;

        }

        public void BindSearchOptions(Guna.UI2.WinForms.Guna2DataGridView dgv, Guna.UI2.WinForms.Guna2ComboBox cboOptions)
        {
            if (dgv.RowCount > 0)
            {

            }
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                if (dgv.Columns[i].Visible)
                {
                    object itemObject = new object();
                    itemObject = dgv.Columns[i].HeaderText;
                    cboOptions.Items.Add(itemObject);
                }
            }
        }

        public void SearchTextChanged(Guna.UI2.WinForms.Guna2DataGridView dgv, Guna.UI2.WinForms.Guna2ComboBox cboSearchOptions, Guna.UI2.WinForms.Guna2TextBox txtSearch)
        {
            if (cboSearchOptions.Text == "")
            {
                MessageBox.Show("ရွေးရန် ဘေးရှိ ခလုတ်ကို နှိပ်ပြီး တစ်ခုခုကို ရွေးချယ်ပေးပါ။");
            }
            else
            {
                //CurrencyManager cm = (CurrencyManager)BindingCompleteContext[dgv.DataSource];
                //cm.SuspendBinding();
                if (txtSearch.Text == "")
                {
                    for (int j = 0; j < dgv.RowCount; j++)
                    {
                        dgv.Rows[j].Visible = true;
                    }
                }
                else
                {
                    int columnIndex = 0;
                    for (int i = 0; i < dgv.ColumnCount; i++)
                    {
                        if (dgv.Columns[i].HeaderText == cboSearchOptions.Text)
                        {
                            columnIndex = i;
                        }
                    }
                    for (int j = 0; j < dgv.RowCount; j++)
                    {
                        if (!dgv.Rows[j].Cells[columnIndex].Value.ToString().Contains(txtSearch.Text))
                        {
                            dgv.Rows[j].Visible = false;
                        }
                    }
                }
                //cm.ResumeBinding();
            }
        }

        public bool Validation(object obj)
        {
            bool result = false;
            Type t = obj.GetType();
            if(t.Name == "Guna2TextBox")
            {
                if (t.GetProperty("Text").GetValue(obj).ToString() != "")
                    result = true;
            }
            return result;
        }
    }
    
}
