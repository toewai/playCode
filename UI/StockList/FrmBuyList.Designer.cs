
namespace UI.StockList
{
    partial class FrmBuyList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.dgvOpeningStock = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnNewSupplier = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSupplierSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cboSupplier = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSupplierName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInVoiceSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtInvoiceNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpInDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboPaymentType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboWarehouse = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpeningStock)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnReset.Location = new System.Drawing.Point(186, 679);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.BorderRadius = 27;
            this.btnReset.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnReset.ShadowDecoration.Enabled = true;
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(134, 56);
            this.btnReset.TabIndex = 113;
            this.btnReset.Text = " အသစ်";
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
            this.btnSave.Location = new System.Drawing.Point(24, 679);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.BorderRadius = 27;
            this.btnSave.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnSave.ShadowDecoration.Enabled = true;
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(134, 56);
            this.btnSave.TabIndex = 112;
            this.btnSave.Text = "သိမ်းမည်";
            // 
            // dgvOpeningStock
            // 
            this.dgvOpeningStock.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvOpeningStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOpeningStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOpeningStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOpeningStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvOpeningStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOpeningStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOpeningStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOpeningStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOpeningStock.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOpeningStock.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvOpeningStock.EnableHeadersVisualStyles = false;
            this.dgvOpeningStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOpeningStock.Location = new System.Drawing.Point(24, 248);
            this.dgvOpeningStock.Name = "dgvOpeningStock";
            this.dgvOpeningStock.RowHeadersVisible = false;
            this.dgvOpeningStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOpeningStock.Size = new System.Drawing.Size(1044, 425);
            this.dgvOpeningStock.TabIndex = 111;
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
            // 
            // btnNewSupplier
            // 
            this.btnNewSupplier.BackColor = System.Drawing.Color.Gray;
            this.btnNewSupplier.CheckedState.Parent = this.btnNewSupplier;
            this.btnNewSupplier.HoverState.Parent = this.btnNewSupplier;
            this.btnNewSupplier.Location = new System.Drawing.Point(934, 14);
            this.btnNewSupplier.Name = "btnNewSupplier";
            this.btnNewSupplier.PressedState.Parent = this.btnNewSupplier;
            this.btnNewSupplier.Size = new System.Drawing.Size(40, 40);
            this.btnNewSupplier.TabIndex = 110;
            // 
            // btnSupplierSearch
            // 
            this.btnSupplierSearch.BackColor = System.Drawing.Color.Gray;
            this.btnSupplierSearch.CheckedState.Parent = this.btnSupplierSearch;
            this.btnSupplierSearch.HoverState.Parent = this.btnSupplierSearch;
            this.btnSupplierSearch.Location = new System.Drawing.Point(888, 14);
            this.btnSupplierSearch.Name = "btnSupplierSearch";
            this.btnSupplierSearch.PressedState.Parent = this.btnSupplierSearch;
            this.btnSupplierSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSupplierSearch.TabIndex = 109;
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
            this.cboSupplier.Location = new System.Drawing.Point(682, 17);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.ShadowDecoration.Parent = this.cboSupplier;
            this.cboSupplier.Size = new System.Drawing.Size(200, 36);
            this.cboSupplier.TabIndex = 108;
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
            this.txtSupplierName.Location = new System.Drawing.Point(682, 72);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.PasswordChar = '\0';
            this.txtSupplierName.PlaceholderText = "";
            this.txtSupplierName.SelectedText = "";
            this.txtSupplierName.ShadowDecoration.Parent = this.txtSupplierName;
            this.txtSupplierName.Size = new System.Drawing.Size(200, 36);
            this.txtSupplierName.TabIndex = 106;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 33);
            this.label5.TabIndex = 102;
            this.label5.Text = "ကုန်သွင်းသူအမည်";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 33);
            this.label6.TabIndex = 101;
            this.label6.Text = "ကုန်သွင်းသူ ကုဒ်";
            // 
            // btnInVoiceSearch
            // 
            this.btnInVoiceSearch.BackColor = System.Drawing.Color.Gray;
            this.btnInVoiceSearch.CheckedState.Parent = this.btnInVoiceSearch;
            this.btnInVoiceSearch.HoverState.Parent = this.btnInVoiceSearch;
            this.btnInVoiceSearch.Location = new System.Drawing.Point(388, 19);
            this.btnInVoiceSearch.Name = "btnInVoiceSearch";
            this.btnInVoiceSearch.PressedState.Parent = this.btnInVoiceSearch;
            this.btnInVoiceSearch.Size = new System.Drawing.Size(40, 40);
            this.btnInVoiceSearch.TabIndex = 100;
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
            this.txtInvoiceNo.Location = new System.Drawing.Point(197, 21);
            this.txtInvoiceNo.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.PasswordChar = '\0';
            this.txtInvoiceNo.PlaceholderText = "";
            this.txtInvoiceNo.SelectedText = "";
            this.txtInvoiceNo.ShadowDecoration.Parent = this.txtInvoiceNo;
            this.txtInvoiceNo.Size = new System.Drawing.Size(182, 36);
            this.txtInvoiceNo.TabIndex = 99;
            // 
            // dtpInDate
            // 
            this.dtpInDate.CheckedState.Parent = this.dtpInDate;
            this.dtpInDate.CustomFormat = "dd-MM-yyyy";
            this.dtpInDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtpInDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInDate.HoverState.Parent = this.dtpInDate;
            this.dtpInDate.Location = new System.Drawing.Point(197, 69);
            this.dtpInDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpInDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpInDate.Name = "dtpInDate";
            this.dtpInDate.ShadowDecoration.Parent = this.dtpInDate;
            this.dtpInDate.Size = new System.Drawing.Size(182, 36);
            this.dtpInDate.TabIndex = 98;
            this.dtpInDate.Value = new System.DateTime(2022, 4, 21, 17, 35, 35, 70);
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
            this.cboPaymentType.Location = new System.Drawing.Point(197, 126);
            this.cboPaymentType.Name = "cboPaymentType";
            this.cboPaymentType.ShadowDecoration.Parent = this.cboPaymentType;
            this.cboPaymentType.Size = new System.Drawing.Size(182, 36);
            this.cboPaymentType.TabIndex = 97;
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
            this.cboWarehouse.Location = new System.Drawing.Point(197, 183);
            this.cboWarehouse.Name = "cboWarehouse";
            this.cboWarehouse.ShadowDecoration.Parent = this.cboWarehouse;
            this.cboWarehouse.Size = new System.Drawing.Size(182, 36);
            this.cboWarehouse.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 33);
            this.label2.TabIndex = 95;
            this.label2.Text = "ကုန်ရှိနေရာ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 33);
            this.label1.TabIndex = 94;
            this.label1.Text = "ငွေပေးချေသည့် ပုံစံ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(31, 69);
            this.lblName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 33);
            this.lblName.TabIndex = 93;
            this.lblName.Text = "ရက်စွဲ";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(31, 21);
            this.lblCode.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(109, 33);
            this.lblCode.TabIndex = 92;
            this.lblCode.Text = "ပြေစာနံပါတ်";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton1);
            this.guna2GroupBox1.Controls.Add(this.guna2DateTimePicker1);
            this.guna2GroupBox1.Controls.Add(this.guna2TextBox1);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(495, 122);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(479, 120);
            this.guna2GroupBox1.TabIndex = 114;
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 2;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Location = new System.Drawing.Point(507, 106);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(169, 37);
            this.guna2CheckBox1.TabIndex = 115;
            this.guna2CheckBox1.Text = "guna2CheckBox1";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 2;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UseVisualStyleBackColor = false;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(189, 75);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(182, 36);
            this.guna2DateTimePicker1.TabIndex = 117;
            this.guna2DateTimePicker1.Value = new System.DateTime(2022, 4, 21, 17, 35, 35, 70);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 33);
            this.label3.TabIndex = 116;
            this.label3.Text = "ရက်စွဲ";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Gray;
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Location = new System.Drawing.Point(380, 32);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.TabIndex = 118;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(189, 27);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(182, 36);
            this.guna2TextBox1.TabIndex = 117;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 33);
            this.label4.TabIndex = 116;
            this.label4.Text = "ပြေစာနံပါတ်";
            // 
            // FrmBuyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1093, 749);
            this.Controls.Add(this.guna2CheckBox1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvOpeningStock);
            this.Controls.Add(this.btnNewSupplier);
            this.Controls.Add(this.btnSupplierSearch);
            this.Controls.Add(this.cboSupplier);
            this.Controls.Add(this.txtSupplierName);
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
            this.Name = "FrmBuyList";
            this.Text = "FrmBuyList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpeningStock)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOpeningStock;
        private Guna.UI2.WinForms.Guna2ImageButton btnNewSupplier;
        private Guna.UI2.WinForms.Guna2ImageButton btnSupplierSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cboSupplier;
        private Guna.UI2.WinForms.Guna2TextBox txtSupplierName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ImageButton btnInVoiceSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtInvoiceNo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpInDate;
        private Guna.UI2.WinForms.Guna2ComboBox cboPaymentType;
        private Guna.UI2.WinForms.Guna2ComboBox cboWarehouse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}