
namespace UI.Management
{
    partial class FrmUser
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
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPasswordConfirm = new System.Windows.Forms.Label();
            this.btnSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.cbInactive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.gbCategory = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbIsUpdate = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbIsSave = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbIsRead = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblSearchOptions = new System.Windows.Forms.Label();
            this.cboSearchOptions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvDefaultStyle = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gbCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefaultStyle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BorderRadius = 20;
            this.btnClose.FillColor = System.Drawing.Color.Blue;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1051, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 90;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.Parent = this.txtFirstName;
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.FocusedState.Parent = this.txtFirstName;
            this.txtFirstName.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.HoverState.Parent = this.txtFirstName;
            this.txtFirstName.Location = new System.Drawing.Point(269, 35);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderText = "";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.ShadowDecoration.Parent = this.txtFirstName;
            this.txtFirstName.Size = new System.Drawing.Size(224, 36);
            this.txtFirstName.TabIndex = 91;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(55, 37);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(183, 33);
            this.lblFirstName.TabIndex = 92;
            this.lblFirstName.Text = "အမည်၏ ပထမ စာလုံး";
            // 
            // txtLastName
            // 
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.Parent = this.txtLastName;
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.FocusedState.Parent = this.txtLastName;
            this.txtLastName.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.HoverState.Parent = this.txtLastName;
            this.txtLastName.Location = new System.Drawing.Point(269, 83);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.SelectedText = "";
            this.txtLastName.ShadowDecoration.Parent = this.txtLastName;
            this.txtLastName.Size = new System.Drawing.Size(224, 36);
            this.txtLastName.TabIndex = 93;
            // 
            // txtFullName
            // 
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.DisabledState.Parent = this.txtFullName;
            this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.FocusedState.Parent = this.txtFullName;
            this.txtFullName.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            this.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.HoverState.Parent = this.txtFullName;
            this.txtFullName.Location = new System.Drawing.Point(269, 131);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PlaceholderText = "";
            this.txtFullName.SelectedText = "";
            this.txtFullName.ShadowDecoration.Parent = this.txtFullName;
            this.txtFullName.Size = new System.Drawing.Size(224, 36);
            this.txtFullName.TabIndex = 94;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(269, 179);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(224, 36);
            this.txtPassword.TabIndex = 95;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.DisabledState.Parent = this.txtConfirmPassword;
            this.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.FocusedState.Parent = this.txtConfirmPassword;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            this.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.HoverState.Parent = this.txtConfirmPassword;
            this.txtConfirmPassword.Location = new System.Drawing.Point(269, 227);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '\0';
            this.txtConfirmPassword.PlaceholderText = "";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.ShadowDecoration.Parent = this.txtConfirmPassword;
            this.txtConfirmPassword.Size = new System.Drawing.Size(224, 36);
            this.txtConfirmPassword.TabIndex = 96;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(55, 85);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(191, 33);
            this.lblLastName.TabIndex = 97;
            this.lblLastName.Text = "အမည်၏ နောက် စာလုံး";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(55, 133);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(153, 33);
            this.lblFullName.TabIndex = 98;
            this.lblFullName.Text = "အမည် အပြည့်အစုံ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(55, 181);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(108, 33);
            this.lblPassword.TabIndex = 99;
            this.lblPassword.Text = "လျှို့ဝှက်ကုဒ်";
            // 
            // lblPasswordConfirm
            // 
            this.lblPasswordConfirm.AutoSize = true;
            this.lblPasswordConfirm.Location = new System.Drawing.Point(55, 229);
            this.lblPasswordConfirm.Name = "lblPasswordConfirm";
            this.lblPasswordConfirm.Size = new System.Drawing.Size(194, 33);
            this.lblPasswordConfirm.TabIndex = 100;
            this.lblPasswordConfirm.Text = "လျှို့ဝှက်ကုဒ် ပြန်ရိုက်ရန်";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gray;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(502, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PressedState.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(40, 36);
            this.btnSearch.TabIndex = 101;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnReset.Location = new System.Drawing.Point(215, 320);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.BorderRadius = 27;
            this.btnReset.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnReset.ShadowDecoration.Enabled = true;
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(134, 56);
            this.btnReset.TabIndex = 103;
            this.btnReset.Text = " အသစ်";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.btnSave.Location = new System.Drawing.Point(55, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.BorderRadius = 27;
            this.btnSave.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnSave.ShadowDecoration.Enabled = true;
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(134, 56);
            this.btnSave.TabIndex = 102;
            this.btnSave.Text = "သိမ်းမည်";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbInactive
            // 
            this.cbInactive.AutoSize = true;
            this.cbInactive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbInactive.CheckedState.BorderRadius = 2;
            this.cbInactive.CheckedState.BorderThickness = 0;
            this.cbInactive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbInactive.Location = new System.Drawing.Point(269, 275);
            this.cbInactive.Name = "cbInactive";
            this.cbInactive.Size = new System.Drawing.Size(162, 37);
            this.cbInactive.TabIndex = 104;
            this.cbInactive.Text = "အသုံးမပြုတော့ပါ";
            this.cbInactive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbInactive.UncheckedState.BorderRadius = 2;
            this.cbInactive.UncheckedState.BorderThickness = 0;
            this.cbInactive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbInactive.UseVisualStyleBackColor = true;
            // 
            // gbCategory
            // 
            this.gbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCategory.Controls.Add(this.cbIsUpdate);
            this.gbCategory.Controls.Add(this.cbIsSave);
            this.gbCategory.Controls.Add(this.cbIsRead);
            this.gbCategory.Controls.Add(this.txtSearch);
            this.gbCategory.Controls.Add(this.lblSearch);
            this.gbCategory.Controls.Add(this.lblSearchOptions);
            this.gbCategory.Controls.Add(this.cboSearchOptions);
            this.gbCategory.Controls.Add(this.dgvDefaultStyle);
            this.gbCategory.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.gbCategory.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbCategory.Location = new System.Drawing.Point(12, 382);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.ShadowDecoration.Parent = this.gbCategory;
            this.gbCategory.Size = new System.Drawing.Size(1069, 355);
            this.gbCategory.TabIndex = 105;
            this.gbCategory.TabStop = false;
            // 
            // cbIsUpdate
            // 
            this.cbIsUpdate.AutoSize = true;
            this.cbIsUpdate.BackColor = System.Drawing.Color.Transparent;
            this.cbIsUpdate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsUpdate.CheckedState.BorderRadius = 2;
            this.cbIsUpdate.CheckedState.BorderThickness = 0;
            this.cbIsUpdate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsUpdate.Location = new System.Drawing.Point(758, 3);
            this.cbIsUpdate.Name = "cbIsUpdate";
            this.cbIsUpdate.Size = new System.Drawing.Size(184, 37);
            this.cbIsUpdate.TabIndex = 30;
            this.cbIsUpdate.Text = "Select All IsUpdate";
            this.cbIsUpdate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbIsUpdate.UncheckedState.BorderRadius = 2;
            this.cbIsUpdate.UncheckedState.BorderThickness = 0;
            this.cbIsUpdate.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbIsUpdate.UseVisualStyleBackColor = false;
            this.cbIsUpdate.CheckedChanged += new System.EventHandler(this.cbIsUpdate_CheckedChanged);
            // 
            // cbIsSave
            // 
            this.cbIsSave.AutoSize = true;
            this.cbIsSave.BackColor = System.Drawing.Color.Transparent;
            this.cbIsSave.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsSave.CheckedState.BorderRadius = 2;
            this.cbIsSave.CheckedState.BorderThickness = 0;
            this.cbIsSave.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsSave.Location = new System.Drawing.Point(589, 33);
            this.cbIsSave.Name = "cbIsSave";
            this.cbIsSave.Size = new System.Drawing.Size(163, 37);
            this.cbIsSave.TabIndex = 29;
            this.cbIsSave.Text = "Select All IsSave";
            this.cbIsSave.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbIsSave.UncheckedState.BorderRadius = 2;
            this.cbIsSave.UncheckedState.BorderThickness = 0;
            this.cbIsSave.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbIsSave.UseVisualStyleBackColor = false;
            this.cbIsSave.CheckedChanged += new System.EventHandler(this.cbIsSave_CheckedChanged);
            // 
            // cbIsRead
            // 
            this.cbIsRead.AutoSize = true;
            this.cbIsRead.BackColor = System.Drawing.Color.Transparent;
            this.cbIsRead.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsRead.CheckedState.BorderRadius = 2;
            this.cbIsRead.CheckedState.BorderThickness = 0;
            this.cbIsRead.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsRead.Location = new System.Drawing.Point(589, 3);
            this.cbIsRead.Name = "cbIsRead";
            this.cbIsRead.Size = new System.Drawing.Size(166, 37);
            this.cbIsRead.TabIndex = 28;
            this.cbIsRead.Text = "Select All IsRead";
            this.cbIsRead.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbIsRead.UncheckedState.BorderRadius = 2;
            this.cbIsRead.UncheckedState.BorderThickness = 0;
            this.cbIsRead.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbIsRead.UseVisualStyleBackColor = false;
            this.cbIsRead.CheckedChanged += new System.EventHandler(this.cbIsRead_CheckedChanged);
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
            this.txtSearch.Location = new System.Drawing.Point(311, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(252, 36);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Location = new System.Drawing.Point(264, 23);
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
            this.cboSearchOptions.Size = new System.Drawing.Size(198, 36);
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
            this.dgvDefaultStyle.Location = new System.Drawing.Point(8, 76);
            this.dgvDefaultStyle.Name = "dgvDefaultStyle";
            this.dgvDefaultStyle.RowHeadersVisible = false;
            this.dgvDefaultStyle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDefaultStyle.Size = new System.Drawing.Size(1050, 270);
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
            this.dgvDefaultStyle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDefaultStyle_CellClick);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 749);
            this.Controls.Add(this.gbCategory);
            this.Controls.Add(this.cbInactive);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblPasswordConfirm);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "FrmUser";
            this.Text = "FrmUser";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefaultStyle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPasswordConfirm;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2CheckBox cbInactive;
        private Guna.UI2.WinForms.Guna2GroupBox gbCategory;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblSearchOptions;
        private Guna.UI2.WinForms.Guna2ComboBox cboSearchOptions;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDefaultStyle;
        private Guna.UI2.WinForms.Guna2CheckBox cbIsUpdate;
        private Guna.UI2.WinForms.Guna2CheckBox cbIsSave;
        private Guna.UI2.WinForms.Guna2CheckBox cbIsRead;
    }
}