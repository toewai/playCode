namespace UI.Shop
{
    partial class FrmCount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbInactive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbDefault = new Guna.UI2.WinForms.Guna2CheckBox();
            this.gbCategory = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblSearchOptions = new System.Windows.Forms.Label();
            this.cboSearchOptions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvCount = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.gbCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCount)).BeginInit();
            this.SuspendLayout();
            // 
            // cbInactive
            // 
            this.cbInactive.AutoSize = true;
            this.cbInactive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbInactive.CheckedState.BorderRadius = 2;
            this.cbInactive.CheckedState.BorderThickness = 0;
            this.cbInactive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbInactive.Location = new System.Drawing.Point(246, 177);
            this.cbInactive.Name = "cbInactive";
            this.cbInactive.Size = new System.Drawing.Size(248, 37);
            this.cbInactive.TabIndex = 4;
            this.cbInactive.Text = "ဆက်လက် အသုံးမပြုတော့ပါ";
            this.cbInactive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbInactive.UncheckedState.BorderRadius = 2;
            this.cbInactive.UncheckedState.BorderThickness = 0;
            this.cbInactive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbInactive.UseVisualStyleBackColor = true;
            // 
            // cbDefault
            // 
            this.cbDefault.AutoSize = true;
            this.cbDefault.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDefault.CheckedState.BorderRadius = 2;
            this.cbDefault.CheckedState.BorderThickness = 0;
            this.cbDefault.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDefault.Location = new System.Drawing.Point(246, 132);
            this.cbDefault.Name = "cbDefault";
            this.cbDefault.Size = new System.Drawing.Size(179, 37);
            this.cbDefault.TabIndex = 3;
            this.cbDefault.Text = "ပုံသေသတ်မှတ်မည်";
            this.cbDefault.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbDefault.UncheckedState.BorderRadius = 2;
            this.cbDefault.UncheckedState.BorderThickness = 0;
            this.cbDefault.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbDefault.UseVisualStyleBackColor = true;
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
            this.gbCategory.Controls.Add(this.dgvCount);
            this.gbCategory.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.gbCategory.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbCategory.Location = new System.Drawing.Point(12, 280);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.ShadowDecoration.Parent = this.gbCategory;
            this.gbCategory.Size = new System.Drawing.Size(1069, 476);
            this.gbCategory.TabIndex = 51;
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
            this.txtSearch.Location = new System.Drawing.Point(361, 20);
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
            this.lblSearch.Location = new System.Drawing.Point(308, 23);
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
            this.cboSearchOptions.Location = new System.Drawing.Point(74, 20);
            this.cboSearchOptions.Name = "cboSearchOptions";
            this.cboSearchOptions.ShadowDecoration.Parent = this.cboSearchOptions;
            this.cboSearchOptions.Size = new System.Drawing.Size(226, 36);
            this.cboSearchOptions.TabIndex = 1;
            this.cboSearchOptions.TextChanged += new System.EventHandler(this.cboSearchOptions_TextChanged);
            // 
            // dgvCount
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvCount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.dgvCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCount.ColumnHeadersHeight = 4;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCount.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCount.EnableHeadersVisualStyles = false;
            this.dgvCount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCount.Location = new System.Drawing.Point(8, 60);
            this.dgvCount.Name = "dgvCount";
            this.dgvCount.RowHeadersVisible = false;
            this.dgvCount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCount.Size = new System.Drawing.Size(1050, 407);
            this.dgvCount.TabIndex = 0;
            this.dgvCount.TabStop = false;
            this.dgvCount.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvCount.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCount.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCount.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCount.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCount.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCount.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.dgvCount.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCount.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCount.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCount.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCount.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCount.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCount.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvCount.ThemeStyle.ReadOnly = false;
            this.dgvCount.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCount.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCount.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCount.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvCount.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCount.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCount.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCount_CellClick);
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
            this.btnClose.TabIndex = 50;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(246, 81);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(412, 36);
            this.txtName.TabIndex = 2;
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
            this.btnSave.Location = new System.Drawing.Point(20, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.BorderRadius = 27;
            this.btnSave.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnSave.ShadowDecoration.Enabled = true;
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(134, 56);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "သိမ်းမည်";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 81);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 33);
            this.lblName.TabIndex = 49;
            this.lblName.Text = "ရေတွက်ပုံ";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(14, 30);
            this.lblCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(125, 33);
            this.lblCode.TabIndex = 48;
            this.lblCode.Text = "ရေတွက်ပုံ ကုဒ်";
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
            this.btnReset.Location = new System.Drawing.Point(178, 218);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.BorderRadius = 27;
            this.btnReset.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnReset.ShadowDecoration.Enabled = true;
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(134, 56);
            this.btnReset.TabIndex = 52;
            this.btnReset.Text = " အသစ်";
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // FrmCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1093, 749);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbInactive);
            this.Controls.Add(this.cbDefault);
            this.Controls.Add(this.gbCategory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "FrmCount";
            this.Text = "FrmCount";
            this.Load += new System.EventHandler(this.FrmCount_Load);
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CheckBox cbInactive;
        private Guna.UI2.WinForms.Guna2CheckBox cbDefault;
        private Guna.UI2.WinForms.Guna2GroupBox gbCategory;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblSearchOptions;
        private Guna.UI2.WinForms.Guna2ComboBox cboSearchOptions;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCount;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtCode;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private Guna.UI2.WinForms.Guna2Button btnReset;
    }
}