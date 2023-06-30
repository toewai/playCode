
namespace UI.StockList
{
    partial class FrmOpeningStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboWarehouse = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboPaymentType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpInDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtInvoiceNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnInVoiceSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCurrencyType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSupplierName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtExchangeRate = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboSupplier = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSupplierSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnNewSupplier = new Guna.UI2.WinForms.Guna2ImageButton();
            this.dgvOpeningStock = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtGrandTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpeningStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(31, 79);
            this.lblName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 33);
            this.lblName.TabIndex = 70;
            this.lblName.Text = "ရက်စွဲ";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(31, 31);
            this.lblCode.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(109, 33);
            this.lblCode.TabIndex = 69;
            this.lblCode.Text = "ပြေစာနံပါတ်";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 33);
            this.label1.TabIndex = 71;
            this.label1.Text = "ငွေပေးချေသည့် ပုံစံ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 33);
            this.label2.TabIndex = 72;
            this.label2.Text = "ကုန်ရှိနေရာ";
            // 
            // cboWarehouse
            // 
            this.cboWarehouse.BackColor = System.Drawing.Color.Transparent;
            this.cboWarehouse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWarehouse.FocusedColor = System.Drawing.Color.Empty;
            this.cboWarehouse.FocusedState.Parent = this.cboWarehouse;
            this.cboWarehouse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboWarehouse.FormattingEnabled = true;
            this.cboWarehouse.HoverState.Parent = this.cboWarehouse;
            this.cboWarehouse.ItemHeight = 30;
            this.cboWarehouse.ItemsAppearance.Parent = this.cboWarehouse;
            this.cboWarehouse.Location = new System.Drawing.Point(197, 193);
            this.cboWarehouse.Name = "cboWarehouse";
            this.cboWarehouse.ShadowDecoration.Parent = this.cboWarehouse;
            this.cboWarehouse.Size = new System.Drawing.Size(182, 36);
            this.cboWarehouse.TabIndex = 73;
            // 
            // cboPaymentType
            // 
            this.cboPaymentType.BackColor = System.Drawing.Color.Transparent;
            this.cboPaymentType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentType.FocusedColor = System.Drawing.Color.Empty;
            this.cboPaymentType.FocusedState.Parent = this.cboPaymentType;
            this.cboPaymentType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPaymentType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboPaymentType.FormattingEnabled = true;
            this.cboPaymentType.HoverState.Parent = this.cboPaymentType;
            this.cboPaymentType.ItemHeight = 30;
            this.cboPaymentType.ItemsAppearance.Parent = this.cboPaymentType;
            this.cboPaymentType.Location = new System.Drawing.Point(197, 136);
            this.cboPaymentType.Name = "cboPaymentType";
            this.cboPaymentType.ShadowDecoration.Parent = this.cboPaymentType;
            this.cboPaymentType.Size = new System.Drawing.Size(182, 36);
            this.cboPaymentType.TabIndex = 74;
            // 
            // dtpInDate
            // 
            this.dtpInDate.CheckedState.Parent = this.dtpInDate;
            this.dtpInDate.CustomFormat = "dd-MM-yyyy";
            this.dtpInDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtpInDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInDate.HoverState.Parent = this.dtpInDate;
            this.dtpInDate.Location = new System.Drawing.Point(197, 79);
            this.dtpInDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpInDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpInDate.Name = "dtpInDate";
            this.dtpInDate.ShadowDecoration.Parent = this.dtpInDate;
            this.dtpInDate.Size = new System.Drawing.Size(182, 36);
            this.dtpInDate.TabIndex = 75;
            this.dtpInDate.Value = new System.DateTime(2022, 4, 21, 17, 35, 35, 70);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInvoiceNo.DefaultText = "";
            this.txtInvoiceNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInvoiceNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInvoiceNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInvoiceNo.DisabledState.Parent = this.txtInvoiceNo;
            this.txtInvoiceNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInvoiceNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInvoiceNo.FocusedState.Parent = this.txtInvoiceNo;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            this.txtInvoiceNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInvoiceNo.HoverState.Parent = this.txtInvoiceNo;
            this.txtInvoiceNo.Location = new System.Drawing.Point(197, 31);
            this.txtInvoiceNo.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.PasswordChar = '\0';
            this.txtInvoiceNo.PlaceholderText = "";
            this.txtInvoiceNo.SelectedText = "";
            this.txtInvoiceNo.ShadowDecoration.Parent = this.txtInvoiceNo;
            this.txtInvoiceNo.Size = new System.Drawing.Size(182, 36);
            this.txtInvoiceNo.TabIndex = 76;
            // 
            // btnInVoiceSearch
            // 
            this.btnInVoiceSearch.BackColor = System.Drawing.Color.Gray;
            this.btnInVoiceSearch.CheckedState.Parent = this.btnInVoiceSearch;
            this.btnInVoiceSearch.HoverState.Parent = this.btnInVoiceSearch;
            this.btnInVoiceSearch.Location = new System.Drawing.Point(388, 29);
            this.btnInVoiceSearch.Name = "btnInVoiceSearch";
            this.btnInVoiceSearch.PressedState.Parent = this.btnInVoiceSearch;
            this.btnInVoiceSearch.Size = new System.Drawing.Size(40, 40);
            this.btnInVoiceSearch.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 33);
            this.label3.TabIndex = 81;
            this.label3.Text = "ငွေကြေးပေါက်ဈေး";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 33);
            this.label4.TabIndex = 80;
            this.label4.Text = "ငွေကြေးအမျိုးအစား";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 33);
            this.label5.TabIndex = 79;
            this.label5.Text = "ကုန်သွင်းသူအမည်";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 33);
            this.label6.TabIndex = 78;
            this.label6.Text = "ကုန်သွင်းသူ ကုဒ်";
            // 
            // cboCurrencyType
            // 
            this.cboCurrencyType.BackColor = System.Drawing.Color.Transparent;
            this.cboCurrencyType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCurrencyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurrencyType.FocusedColor = System.Drawing.Color.Empty;
            this.cboCurrencyType.FocusedState.Parent = this.cboCurrencyType;
            this.cboCurrencyType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCurrencyType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboCurrencyType.FormattingEnabled = true;
            this.cboCurrencyType.HoverState.Parent = this.cboCurrencyType;
            this.cboCurrencyType.ItemHeight = 30;
            this.cboCurrencyType.ItemsAppearance.Parent = this.cboCurrencyType;
            this.cboCurrencyType.Location = new System.Drawing.Point(682, 136);
            this.cboCurrencyType.Name = "cboCurrencyType";
            this.cboCurrencyType.ShadowDecoration.Parent = this.cboCurrencyType;
            this.cboCurrencyType.Size = new System.Drawing.Size(200, 36);
            this.cboCurrencyType.TabIndex = 82;
            this.cboCurrencyType.SelectedValueChanged += new System.EventHandler(this.cboCurrencyType_SelectedValueChanged);
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplierName.DefaultText = "";
            this.txtSupplierName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSupplierName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSupplierName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplierName.DisabledState.Parent = this.txtSupplierName;
            this.txtSupplierName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplierName.Enabled = false;
            this.txtSupplierName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupplierName.FocusedState.Parent = this.txtSupplierName;
            this.txtSupplierName.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            this.txtSupplierName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupplierName.HoverState.Parent = this.txtSupplierName;
            this.txtSupplierName.Location = new System.Drawing.Point(682, 82);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.PasswordChar = '\0';
            this.txtSupplierName.PlaceholderText = "";
            this.txtSupplierName.SelectedText = "";
            this.txtSupplierName.ShadowDecoration.Parent = this.txtSupplierName;
            this.txtSupplierName.Size = new System.Drawing.Size(200, 36);
            this.txtSupplierName.TabIndex = 83;
            // 
            // txtExchangeRate
            // 
            this.txtExchangeRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExchangeRate.DefaultText = "";
            this.txtExchangeRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtExchangeRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtExchangeRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExchangeRate.DisabledState.Parent = this.txtExchangeRate;
            this.txtExchangeRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExchangeRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExchangeRate.FocusedState.Parent = this.txtExchangeRate;
            this.txtExchangeRate.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            this.txtExchangeRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExchangeRate.HoverState.Parent = this.txtExchangeRate;
            this.txtExchangeRate.Location = new System.Drawing.Point(682, 193);
            this.txtExchangeRate.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.PasswordChar = '\0';
            this.txtExchangeRate.PlaceholderText = "";
            this.txtExchangeRate.SelectedText = "";
            this.txtExchangeRate.ShadowDecoration.Parent = this.txtExchangeRate;
            this.txtExchangeRate.Size = new System.Drawing.Size(200, 36);
            this.txtExchangeRate.TabIndex = 84;
            this.txtExchangeRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExchangeRate_KeyDown);
            // 
            // cboSupplier
            // 
            this.cboSupplier.BackColor = System.Drawing.Color.Transparent;
            this.cboSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupplier.FocusedColor = System.Drawing.Color.Empty;
            this.cboSupplier.FocusedState.Parent = this.cboSupplier;
            this.cboSupplier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.HoverState.Parent = this.cboSupplier;
            this.cboSupplier.ItemHeight = 30;
            this.cboSupplier.ItemsAppearance.Parent = this.cboSupplier;
            this.cboSupplier.Location = new System.Drawing.Point(682, 27);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.ShadowDecoration.Parent = this.cboSupplier;
            this.cboSupplier.Size = new System.Drawing.Size(200, 36);
            this.cboSupplier.TabIndex = 85;
            this.cboSupplier.SelectedValueChanged += new System.EventHandler(this.cboSupplier_SelectedValueChanged);
            // 
            // btnSupplierSearch
            // 
            this.btnSupplierSearch.BackColor = System.Drawing.Color.Gray;
            this.btnSupplierSearch.CheckedState.Parent = this.btnSupplierSearch;
            this.btnSupplierSearch.HoverState.Parent = this.btnSupplierSearch;
            this.btnSupplierSearch.Location = new System.Drawing.Point(888, 24);
            this.btnSupplierSearch.Name = "btnSupplierSearch";
            this.btnSupplierSearch.PressedState.Parent = this.btnSupplierSearch;
            this.btnSupplierSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSupplierSearch.TabIndex = 86;
            this.btnSupplierSearch.Click += new System.EventHandler(this.btnSupplierSearch_Click);
            // 
            // btnNewSupplier
            // 
            this.btnNewSupplier.BackColor = System.Drawing.Color.Gray;
            this.btnNewSupplier.CheckedState.Parent = this.btnNewSupplier;
            this.btnNewSupplier.HoverState.Parent = this.btnNewSupplier;
            this.btnNewSupplier.Location = new System.Drawing.Point(934, 24);
            this.btnNewSupplier.Name = "btnNewSupplier";
            this.btnNewSupplier.PressedState.Parent = this.btnNewSupplier;
            this.btnNewSupplier.Size = new System.Drawing.Size(40, 40);
            this.btnNewSupplier.TabIndex = 87;
            this.btnNewSupplier.Click += new System.EventHandler(this.btnNewSupplier_Click);
            // 
            // dgvOpeningStock
            // 
            this.dgvOpeningStock.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvOpeningStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOpeningStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOpeningStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOpeningStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvOpeningStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOpeningStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOpeningStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOpeningStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOpeningStock.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOpeningStock.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOpeningStock.EnableHeadersVisualStyles = false;
            this.dgvOpeningStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOpeningStock.Location = new System.Drawing.Point(24, 258);
            this.dgvOpeningStock.Name = "dgvOpeningStock";
            this.dgvOpeningStock.RowHeadersVisible = false;
            this.dgvOpeningStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOpeningStock.Size = new System.Drawing.Size(1044, 425);
            this.dgvOpeningStock.TabIndex = 88;
            this.dgvOpeningStock.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvOpeningStock.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOpeningStock.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOpeningStock.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOpeningStock.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvOpeningStock.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvOpeningStock.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvOpeningStock.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOpeningStock.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvOpeningStock.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOpeningStock.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            this.dgvOpeningStock.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOpeningStock.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvOpeningStock.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvOpeningStock.ThemeStyle.ReadOnly = false;
            this.dgvOpeningStock.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOpeningStock.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOpeningStock.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            this.dgvOpeningStock.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvOpeningStock.ThemeStyle.RowsStyle.Height = 22;
            this.dgvOpeningStock.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOpeningStock.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvOpeningStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOpeningStock_CellClick);
            this.dgvOpeningStock.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOpeningStock_CellValueChanged);
            this.dgvOpeningStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvOpeningStock_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BorderRadius = 20;
            this.btnClose.FillColor = System.Drawing.Color.Blue;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1051, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 89;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.AutoRoundedCorners = true;
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BorderRadius = 27;
            this.btnReset.BorderThickness = 1;
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.btnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnReset.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Location = new System.Drawing.Point(186, 689);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.BorderRadius = 27;
            this.btnReset.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnReset.ShadowDecoration.Enabled = true;
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(134, 56);
            this.btnReset.TabIndex = 91;
            this.btnReset.Text = " အသစ်";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 27;
            this.btnSave.BorderThickness = 1;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnSave.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(24, 689);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.BorderRadius = 27;
            this.btnSave.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnSave.ShadowDecoration.Enabled = true;
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(134, 56);
            this.btnSave.TabIndex = 90;
            this.btnSave.Text = "သိမ်းမည်";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGrandTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrandTotal.DefaultText = "";
            this.txtGrandTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGrandTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGrandTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrandTotal.DisabledState.Parent = this.txtGrandTotal;
            this.txtGrandTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrandTotal.Enabled = false;
            this.txtGrandTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrandTotal.FocusedState.Parent = this.txtGrandTotal;
            this.txtGrandTotal.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            this.txtGrandTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrandTotal.HoverState.Parent = this.txtGrandTotal;
            this.txtGrandTotal.Location = new System.Drawing.Point(888, 696);
            this.txtGrandTotal.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.PasswordChar = '\0';
            this.txtGrandTotal.PlaceholderText = "";
            this.txtGrandTotal.SelectedText = "";
            this.txtGrandTotal.ShadowDecoration.Parent = this.txtGrandTotal;
            this.txtGrandTotal.Size = new System.Drawing.Size(182, 36);
            this.txtGrandTotal.TabIndex = 93;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(718, 698);
            this.lblGrandTotal.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(161, 33);
            this.lblGrandTotal.TabIndex = 92;
            this.lblGrandTotal.Text = "စုစုပေါင်း ကျသင့်ငွေ";
            // 
            // FrmOpeningStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1093, 749);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvOpeningStock);
            this.Controls.Add(this.btnNewSupplier);
            this.Controls.Add(this.btnSupplierSearch);
            this.Controls.Add(this.cboSupplier);
            this.Controls.Add(this.txtExchangeRate);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.cboCurrencyType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnInVoiceSearch);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.dtpInDate);
            this.Controls.Add(this.cboPaymentType);
            this.Controls.Add(this.cboWarehouse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "FrmOpeningStock";
            this.Text = "Opening Stock";
            this.Load += new System.EventHandler(this.FrmOpeningStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpeningStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cboWarehouse;
        private Guna.UI2.WinForms.Guna2ComboBox cboPaymentType;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpInDate;
        private Guna.UI2.WinForms.Guna2TextBox txtInvoiceNo;
        private Guna.UI2.WinForms.Guna2ImageButton btnInVoiceSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cboCurrencyType;
        private Guna.UI2.WinForms.Guna2TextBox txtSupplierName;
        private Guna.UI2.WinForms.Guna2TextBox txtExchangeRate;
        private Guna.UI2.WinForms.Guna2ComboBox cboSupplier;
        private Guna.UI2.WinForms.Guna2ImageButton btnSupplierSearch;
        private Guna.UI2.WinForms.Guna2ImageButton btnNewSupplier;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOpeningStock;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtGrandTotal;
        private System.Windows.Forms.Label lblGrandTotal;
    }
}