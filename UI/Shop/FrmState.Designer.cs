namespace UI.Shop
{
    partial class FrmState
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
            this.gbCategory = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblSearchOptions = new System.Windows.Forms.Label();
            this.cboSearchOptions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvDefaultStyle = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtStateName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblStateName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCityName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.gbCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefaultStyle)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCategory
            // 
            this.gbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCategory.Controls.Add(this.txtSearch);
            this.gbCategory.Controls.Add(this.lblSearch);
            this.gbCategory.Controls.Add(this.lblSearchOptions);
            this.gbCategory.Controls.Add(this.cboSearchOptions);
            this.gbCategory.Controls.Add(this.dgvDefaultStyle);
            this.gbCategory.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.gbCategory.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbCategory.Location = new System.Drawing.Point(12, 249);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.ShadowDecoration.Parent = this.gbCategory;
            this.gbCategory.Size = new System.Drawing.Size(1069, 507);
            this.gbCategory.TabIndex = 29;
            this.gbCategory.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(343, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(375, 36);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Location = new System.Drawing.Point(296, 23);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 33);
            this.lblSearch.TabIndex = 27;
            this.lblSearch.Text = "ဖြင့်";
            // 
            // lblSearchOptions
            // 
            this.lblSearchOptions.AutoSize = true;
            this.lblSearchOptions.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchOptions.Location = new System.Drawing.Point(5, 23);
            this.lblSearchOptions.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSearchOptions.Name = "lblSearchOptions";
            this.lblSearchOptions.Size = new System.Drawing.Size(58, 33);
            this.lblSearchOptions.TabIndex = 26;
            this.lblSearchOptions.Text = "ရှာရန်";
            // 
            // cboSearchOptions
            // 
            this.cboSearchOptions.BackColor = System.Drawing.Color.Transparent;
            this.cboSearchOptions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSearchOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchOptions.FocusedColor = System.Drawing.Color.Empty;
            this.cboSearchOptions.FocusedState.Parent = this.cboSearchOptions;
            this.cboSearchOptions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboSearchOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboSearchOptions.FormattingEnabled = true;
            this.cboSearchOptions.HoverState.Parent = this.cboSearchOptions;
            this.cboSearchOptions.ItemHeight = 30;
            this.cboSearchOptions.ItemsAppearance.Parent = this.cboSearchOptions;
            this.cboSearchOptions.Location = new System.Drawing.Point(63, 20);
            this.cboSearchOptions.Name = "cboSearchOptions";
            this.cboSearchOptions.ShadowDecoration.Parent = this.cboSearchOptions;
            this.cboSearchOptions.Size = new System.Drawing.Size(226, 36);
            this.cboSearchOptions.TabIndex = 1;
            this.cboSearchOptions.TextChanged += new System.EventHandler(this.cboSearchOptions_TextChanged);
            // 
            // dgvDefaultStyle
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDefaultStyle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDefaultStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDefaultStyle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDefaultStyle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.dgvDefaultStyle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDefaultStyle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDefaultStyle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDefaultStyle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDefaultStyle.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDefaultStyle.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDefaultStyle.EnableHeadersVisualStyles = false;
            this.dgvDefaultStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDefaultStyle.Location = new System.Drawing.Point(8, 60);
            this.dgvDefaultStyle.Name = "dgvDefaultStyle";
            this.dgvDefaultStyle.RowHeadersVisible = false;
            this.dgvDefaultStyle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDefaultStyle.Size = new System.Drawing.Size(1050, 438);
            this.dgvDefaultStyle.TabIndex = 0;
            this.dgvDefaultStyle.TabStop = false;
            this.dgvDefaultStyle.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvDefaultStyle.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDefaultStyle.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDefaultStyle.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDefaultStyle.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDefaultStyle.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDefaultStyle.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.dgvDefaultStyle.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDefaultStyle.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDefaultStyle.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDefaultStyle.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDefaultStyle.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDefaultStyle.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDefaultStyle.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvDefaultStyle.ThemeStyle.ReadOnly = false;
            this.dgvDefaultStyle.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDefaultStyle.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDefaultStyle.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDefaultStyle.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvDefaultStyle.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDefaultStyle.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDefaultStyle.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDefaultStyle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDefaultStyle_CellClick);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BorderRadius = 20;
            this.btnClose.FillColor = System.Drawing.Color.Blue;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1041, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 32;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // txtStateName
            // 
            this.txtStateName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStateName.DefaultText = "";
            this.txtStateName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStateName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStateName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStateName.DisabledState.Parent = this.txtStateName;
            this.txtStateName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStateName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStateName.FocusedState.Parent = this.txtStateName;
            this.txtStateName.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStateName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStateName.HoverState.Parent = this.txtStateName;
            this.txtStateName.Location = new System.Drawing.Point(246, 81);
            this.txtStateName.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtStateName.Name = "txtStateName";
            this.txtStateName.PasswordChar = '\0';
            this.txtStateName.PlaceholderText = "";
            this.txtStateName.SelectedText = "";
            this.txtStateName.ShadowDecoration.Parent = this.txtStateName;
            this.txtStateName.Size = new System.Drawing.Size(412, 36);
            this.txtStateName.TabIndex = 2;
            // 
            // txtCode
            // 
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.DefaultText = "";
            this.txtCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode.DisabledState.Parent = this.txtCode;
            this.txtCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode.Enabled = false;
            this.txtCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode.FocusedState.Parent = this.txtCode;
            this.txtCode.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode.HoverState.Parent = this.txtCode;
            this.txtCode.Location = new System.Drawing.Point(246, 30);
            this.txtCode.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.PlaceholderText = "";
            this.txtCode.SelectedText = "";
            this.txtCode.ShadowDecoration.Parent = this.txtCode;
            this.txtCode.Size = new System.Drawing.Size(412, 36);
            this.txtCode.TabIndex = 1;
            // 
            // btnSave
            // 
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
            this.btnSave.Location = new System.Drawing.Point(20, 177);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.BorderRadius = 27;
            this.btnSave.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnSave.ShadowDecoration.Enabled = true;
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(134, 56);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "သိမ်းမည်";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblStateName
            // 
            this.lblStateName.AutoSize = true;
            this.lblStateName.Location = new System.Drawing.Point(14, 81);
            this.lblStateName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStateName.Name = "lblStateName";
            this.lblStateName.Size = new System.Drawing.Size(180, 33);
            this.lblStateName.TabIndex = 31;
            this.lblStateName.Text = "တိုင်း/ပြည်နယ် အမည်";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(14, 30);
            this.lblCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(206, 33);
            this.lblCode.TabIndex = 30;
            this.lblCode.Text = "မြို့နှင့်တိုင်း/ပြည်နယ် ကုဒ်";
            // 
            // txtCityName
            // 
            this.txtCityName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCityName.DefaultText = "";
            this.txtCityName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCityName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCityName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCityName.DisabledState.Parent = this.txtCityName;
            this.txtCityName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCityName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCityName.FocusedState.Parent = this.txtCityName;
            this.txtCityName.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCityName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCityName.HoverState.Parent = this.txtCityName;
            this.txtCityName.Location = new System.Drawing.Point(246, 131);
            this.txtCityName.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.PasswordChar = '\0';
            this.txtCityName.PlaceholderText = "";
            this.txtCityName.SelectedText = "";
            this.txtCityName.ShadowDecoration.Parent = this.txtCityName;
            this.txtCityName.Size = new System.Drawing.Size(412, 36);
            this.txtCityName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 33);
            this.label1.TabIndex = 34;
            this.label1.Text = "မြို့အမည်";
            // 
            // btnReset
            // 
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
            this.btnReset.Location = new System.Drawing.Point(166, 178);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.BorderRadius = 27;
            this.btnReset.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnReset.ShadowDecoration.Enabled = true;
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(134, 56);
            this.btnReset.TabIndex = 64;
            this.btnReset.Text = " အသစ်";
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // FrmState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1093, 749);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCategory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtStateName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblStateName);
            this.Controls.Add(this.lblCode);
            this.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "FrmState";
            this.Text = "FrmState";
            this.Load += new System.EventHandler(this.FrmState_Load);
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefaultStyle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbCategory;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblSearchOptions;
        private Guna.UI2.WinForms.Guna2ComboBox cboSearchOptions;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDefaultStyle;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2TextBox txtStateName;
        private Guna.UI2.WinForms.Guna2TextBox txtCode;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lblStateName;
        private System.Windows.Forms.Label lblCode;
        private Guna.UI2.WinForms.Guna2TextBox txtCityName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnReset;
    }
}