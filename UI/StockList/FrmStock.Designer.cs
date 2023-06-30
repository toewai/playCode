namespace UI.StockList
{
    partial class FrmStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnSupplierSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSubCategory = new System.Windows.Forms.Label();
            this.gbReOrder = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvReorder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gbImage = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnChooseImage = new Guna.UI2.WinForms.Guna2Button();
            this.pbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cbReOrder = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbInsertImage = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.cbInactive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbSubCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gbMultiUnit = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvMultiUnit = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cbMultiUnit = new Guna.UI2.WinForms.Guna2CheckBox();
            this.gbReOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReorder)).BeginInit();
            this.gbImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.gbMultiUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultiUnit)).BeginInit();
            this.SuspendLayout();
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
            this.btnClose.TabIndex = 25;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnSupplierSearch
            // 
            this.btnSupplierSearch.BackColor = System.Drawing.Color.Gray;
            this.btnSupplierSearch.CheckedState.Parent = this.btnSupplierSearch;
            this.btnSupplierSearch.HoverState.Parent = this.btnSupplierSearch;
            this.btnSupplierSearch.Location = new System.Drawing.Point(480, 140);
            this.btnSupplierSearch.Name = "btnSupplierSearch";
            this.btnSupplierSearch.PressedState.Parent = this.btnSupplierSearch;
            this.btnSupplierSearch.Size = new System.Drawing.Size(40, 36);
            this.btnSupplierSearch.TabIndex = 65;
            this.btnSupplierSearch.Click += new System.EventHandler(this.btnSupplierSearch_Click);
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
            this.txtCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode.FocusedState.Parent = this.txtCode;
            this.txtCode.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode.HoverState.Parent = this.txtCode;
            this.txtCode.Location = new System.Drawing.Point(212, 140);
            this.txtCode.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.PlaceholderText = "";
            this.txtCode.SelectedText = "";
            this.txtCode.ShadowDecoration.Parent = this.txtCode;
            this.txtCode.Size = new System.Drawing.Size(260, 36);
            this.txtCode.TabIndex = 64;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(14, 140);
            this.lblCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(132, 33);
            this.lblCode.TabIndex = 66;
            this.lblCode.Text = "ကုန်ပစ္စည်း ကုဒ်";
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
            this.txtName.Location = new System.Drawing.Point(212, 195);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(260, 36);
            this.txtName.TabIndex = 67;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 195);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(151, 33);
            this.lblName.TabIndex = 68;
            this.lblName.Text = "ကုန်ပစ္စည်း အမည်";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(14, 26);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(169, 33);
            this.lblCategory.TabIndex = 71;
            this.lblCategory.Text = "ကုန်ပစ္စည်း အစုအဖွဲ့ ";
            // 
            // lblSubCategory
            // 
            this.lblSubCategory.AutoSize = true;
            this.lblSubCategory.Location = new System.Drawing.Point(14, 81);
            this.lblSubCategory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSubCategory.Name = "lblSubCategory";
            this.lblSubCategory.Size = new System.Drawing.Size(175, 33);
            this.lblSubCategory.TabIndex = 72;
            this.lblSubCategory.Text = "ကုန်ပစ္စည်း အစုအဖွဲ့ခွဲ";
            // 
            // gbReOrder
            // 
            this.gbReOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbReOrder.Controls.Add(this.dgvReorder);
            this.gbReOrder.CustomBorderColor = System.Drawing.Color.White;
            this.gbReOrder.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            this.gbReOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbReOrder.Location = new System.Drawing.Point(572, 320);
            this.gbReOrder.Name = "gbReOrder";
            this.gbReOrder.ShadowDecoration.Parent = this.gbReOrder;
            this.gbReOrder.Size = new System.Drawing.Size(463, 242);
            this.gbReOrder.TabIndex = 74;
            // 
            // dgvReorder
            // 
            this.dgvReorder.AllowUserToAddRows = false;
            this.dgvReorder.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvReorder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReorder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReorder.BackgroundColor = System.Drawing.Color.White;
            this.dgvReorder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReorder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReorder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReorder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReorder.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReorder.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReorder.EnableHeadersVisualStyles = false;
            this.dgvReorder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReorder.Location = new System.Drawing.Point(22, 31);
            this.dgvReorder.MultiSelect = false;
            this.dgvReorder.Name = "dgvReorder";
            this.dgvReorder.RowHeadersVisible = false;
            this.dgvReorder.RowTemplate.Height = 40;
            this.dgvReorder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReorder.Size = new System.Drawing.Size(419, 198);
            this.dgvReorder.TabIndex = 0;
            this.dgvReorder.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvReorder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReorder.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvReorder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReorder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReorder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReorder.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvReorder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReorder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvReorder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReorder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            this.dgvReorder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReorder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvReorder.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvReorder.ThemeStyle.ReadOnly = false;
            this.dgvReorder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReorder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReorder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            this.dgvReorder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvReorder.ThemeStyle.RowsStyle.Height = 40;
            this.dgvReorder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReorder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvReorder.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvReorder_EditingControlShowing);
            this.dgvReorder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvReorder_KeyDown);
            // 
            // gbImage
            // 
            this.gbImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbImage.Controls.Add(this.btnChooseImage);
            this.gbImage.Controls.Add(this.pbImage);
            this.gbImage.CustomBorderColor = System.Drawing.Color.White;
            this.gbImage.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            this.gbImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbImage.Location = new System.Drawing.Point(572, 30);
            this.gbImage.Name = "gbImage";
            this.gbImage.ShadowDecoration.Parent = this.gbImage;
            this.gbImage.Size = new System.Drawing.Size(463, 242);
            this.gbImage.TabIndex = 75;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChooseImage.AutoRoundedCorners = true;
            this.btnChooseImage.BackColor = System.Drawing.Color.Transparent;
            this.btnChooseImage.BorderRadius = 27;
            this.btnChooseImage.BorderThickness = 1;
            this.btnChooseImage.CheckedState.Parent = this.btnChooseImage;
            this.btnChooseImage.CustomImages.Parent = this.btnChooseImage;
            this.btnChooseImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnChooseImage.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseImage.ForeColor = System.Drawing.Color.White;
            this.btnChooseImage.HoverState.Parent = this.btnChooseImage;
            this.btnChooseImage.Location = new System.Drawing.Point(157, 173);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.ShadowDecoration.BorderRadius = 27;
            this.btnChooseImage.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnChooseImage.ShadowDecoration.Enabled = true;
            this.btnChooseImage.ShadowDecoration.Parent = this.btnChooseImage;
            this.btnChooseImage.Size = new System.Drawing.Size(158, 56);
            this.btnChooseImage.TabIndex = 80;
            this.btnChooseImage.Text = "ဓါတ်ပုံ ရွေးချယ်ရန်";
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImage.Location = new System.Drawing.Point(41, 31);
            this.pbImage.Name = "pbImage";
            this.pbImage.ShadowDecoration.Parent = this.pbImage;
            this.pbImage.Size = new System.Drawing.Size(367, 136);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // cbReOrder
            // 
            this.cbReOrder.AutoSize = true;
            this.cbReOrder.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbReOrder.CheckedState.BorderRadius = 2;
            this.cbReOrder.CheckedState.BorderThickness = 0;
            this.cbReOrder.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbReOrder.Location = new System.Drawing.Point(614, 300);
            this.cbReOrder.Name = "cbReOrder";
            this.cbReOrder.Size = new System.Drawing.Size(246, 37);
            this.cbReOrder.TabIndex = 76;
            this.cbReOrder.Text = "ကုန်ပစ္စည်းပြန်လည်မှာယူရန်";
            this.cbReOrder.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbReOrder.UncheckedState.BorderRadius = 2;
            this.cbReOrder.UncheckedState.BorderThickness = 0;
            this.cbReOrder.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbReOrder.UseVisualStyleBackColor = true;
            this.cbReOrder.CheckedChanged += new System.EventHandler(this.cbReOrder_CheckedChanged);
            // 
            // cbInsertImage
            // 
            this.cbInsertImage.AutoSize = true;
            this.cbInsertImage.BackColor = System.Drawing.Color.Transparent;
            this.cbInsertImage.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbInsertImage.CheckedState.BorderRadius = 2;
            this.cbInsertImage.CheckedState.BorderThickness = 0;
            this.cbInsertImage.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbInsertImage.ForeColor = System.Drawing.Color.Black;
            this.cbInsertImage.Location = new System.Drawing.Point(621, 11);
            this.cbInsertImage.Name = "cbInsertImage";
            this.cbInsertImage.Size = new System.Drawing.Size(149, 37);
            this.cbInsertImage.TabIndex = 77;
            this.cbInsertImage.Text = "ဓါတ်ပုံ ထည့်ရန်";
            this.cbInsertImage.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbInsertImage.UncheckedState.BorderRadius = 2;
            this.cbInsertImage.UncheckedState.BorderThickness = 0;
            this.cbInsertImage.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbInsertImage.UseVisualStyleBackColor = false;
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
            this.btnReset.Location = new System.Drawing.Point(182, 567);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.BorderRadius = 27;
            this.btnReset.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnReset.ShadowDecoration.Enabled = true;
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(134, 56);
            this.btnReset.TabIndex = 79;
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
            this.btnSave.Location = new System.Drawing.Point(20, 567);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.BorderRadius = 27;
            this.btnSave.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnSave.ShadowDecoration.Enabled = true;
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(134, 56);
            this.btnSave.TabIndex = 78;
            this.btnSave.Text = "သိမ်းမည်";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // cbInactive
            // 
            this.cbInactive.AutoSize = true;
            this.cbInactive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbInactive.CheckedState.BorderRadius = 2;
            this.cbInactive.CheckedState.BorderThickness = 0;
            this.cbInactive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbInactive.Location = new System.Drawing.Point(212, 250);
            this.cbInactive.Name = "cbInactive";
            this.cbInactive.Size = new System.Drawing.Size(162, 37);
            this.cbInactive.TabIndex = 82;
            this.cbInactive.Text = "အသုံးမပြုတော့ပါ";
            this.cbInactive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbInactive.UncheckedState.BorderRadius = 2;
            this.cbInactive.UncheckedState.BorderThickness = 0;
            this.cbInactive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbInactive.UseVisualStyleBackColor = true;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cbCategory.FocusedState.Parent = this.cbCategory;
            this.cbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.HoverState.Parent = this.cbCategory;
            this.cbCategory.ItemHeight = 30;
            this.cbCategory.ItemsAppearance.Parent = this.cbCategory;
            this.cbCategory.Location = new System.Drawing.Point(212, 30);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.ShadowDecoration.Parent = this.cbCategory;
            this.cbCategory.Size = new System.Drawing.Size(260, 36);
            this.cbCategory.TabIndex = 90;
            this.cbCategory.SelectedValueChanged += new System.EventHandler(this.cbCategory_SelectedValueChanged);
            // 
            // cbSubCategory
            // 
            this.cbSubCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbSubCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSubCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cbSubCategory.FocusedState.Parent = this.cbSubCategory;
            this.cbSubCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSubCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSubCategory.FormattingEnabled = true;
            this.cbSubCategory.HoverState.Parent = this.cbSubCategory;
            this.cbSubCategory.ItemHeight = 30;
            this.cbSubCategory.ItemsAppearance.Parent = this.cbSubCategory;
            this.cbSubCategory.Location = new System.Drawing.Point(212, 85);
            this.cbSubCategory.Name = "cbSubCategory";
            this.cbSubCategory.ShadowDecoration.Parent = this.cbSubCategory;
            this.cbSubCategory.Size = new System.Drawing.Size(260, 36);
            this.cbSubCategory.TabIndex = 91;
            // 
            // gbMultiUnit
            // 
            this.gbMultiUnit.Controls.Add(this.dgvMultiUnit);
            this.gbMultiUnit.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbMultiUnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbMultiUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbMultiUnit.Location = new System.Drawing.Point(20, 320);
            this.gbMultiUnit.Name = "gbMultiUnit";
            this.gbMultiUnit.ShadowDecoration.Parent = this.gbMultiUnit;
            this.gbMultiUnit.Size = new System.Drawing.Size(526, 242);
            this.gbMultiUnit.TabIndex = 92;
            // 
            // dgvMultiUnit
            // 
            this.dgvMultiUnit.AllowUserToAddRows = false;
            this.dgvMultiUnit.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvMultiUnit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMultiUnit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMultiUnit.BackgroundColor = System.Drawing.Color.White;
            this.dgvMultiUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMultiUnit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMultiUnit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMultiUnit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMultiUnit.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMultiUnit.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMultiUnit.EnableHeadersVisualStyles = false;
            this.dgvMultiUnit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMultiUnit.Location = new System.Drawing.Point(20, 31);
            this.dgvMultiUnit.MultiSelect = false;
            this.dgvMultiUnit.Name = "dgvMultiUnit";
            this.dgvMultiUnit.RowHeadersVisible = false;
            this.dgvMultiUnit.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMultiUnit.RowTemplate.Height = 40;
            this.dgvMultiUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMultiUnit.Size = new System.Drawing.Size(480, 198);
            this.dgvMultiUnit.TabIndex = 0;
            this.dgvMultiUnit.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvMultiUnit.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMultiUnit.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMultiUnit.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMultiUnit.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMultiUnit.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMultiUnit.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMultiUnit.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMultiUnit.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMultiUnit.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMultiUnit.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Pyidaungsu", 14.25F);
            this.dgvMultiUnit.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMultiUnit.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMultiUnit.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvMultiUnit.ThemeStyle.ReadOnly = false;
            this.dgvMultiUnit.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMultiUnit.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMultiUnit.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvMultiUnit.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvMultiUnit.ThemeStyle.RowsStyle.Height = 40;
            this.dgvMultiUnit.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMultiUnit.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMultiUnit.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvMultiUnit_EditingControlShowing);
            this.dgvMultiUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMultiUnit_KeyDown);
            this.dgvMultiUnit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvMultiUnit_KeyUp);
            // 
            // cbMultiUnit
            // 
            this.cbMultiUnit.AutoSize = true;
            this.cbMultiUnit.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMultiUnit.CheckedState.BorderRadius = 2;
            this.cbMultiUnit.CheckedState.BorderThickness = 0;
            this.cbMultiUnit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMultiUnit.Location = new System.Drawing.Point(69, 300);
            this.cbMultiUnit.Name = "cbMultiUnit";
            this.cbMultiUnit.Size = new System.Drawing.Size(293, 37);
            this.cbMultiUnit.TabIndex = 93;
            this.cbMultiUnit.Text = "ကုန်ပစ္စည်း ရေတွက်ပုံ သတ်မှတ်ရန်";
            this.cbMultiUnit.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbMultiUnit.UncheckedState.BorderRadius = 2;
            this.cbMultiUnit.UncheckedState.BorderThickness = 0;
            this.cbMultiUnit.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbMultiUnit.UseVisualStyleBackColor = true;
            this.cbMultiUnit.CheckedChanged += new System.EventHandler(this.cbMultiUnit_CheckedChanged);
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1093, 749);
            this.Controls.Add(this.cbMultiUnit);
            this.Controls.Add(this.gbMultiUnit);
            this.Controls.Add(this.cbSubCategory);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cbInactive);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbInsertImage);
            this.Controls.Add(this.cbReOrder);
            this.Controls.Add(this.gbImage);
            this.Controls.Add(this.gbReOrder);
            this.Controls.Add(this.lblSubCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSupplierSearch);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "FrmStock";
            this.Text = "FrmStock";
            this.Load += new System.EventHandler(this.FrmStock_Load);
            this.gbReOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReorder)).EndInit();
            this.gbImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.gbMultiUnit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultiUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2ImageButton btnSupplierSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSubCategory;
        private Guna.UI2.WinForms.Guna2GroupBox gbReOrder;
        private Guna.UI2.WinForms.Guna2GroupBox gbImage;
        private Guna.UI2.WinForms.Guna2CheckBox cbReOrder;
        private Guna.UI2.WinForms.Guna2CheckBox cbInsertImage;
        private Guna.UI2.WinForms.Guna2PictureBox pbImage;
        private Guna.UI2.WinForms.Guna2Button btnChooseImage;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2CheckBox cbInactive;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cbSubCategory;
        private Guna.UI2.WinForms.Guna2DataGridView dgvReorder;
        private Guna.UI2.WinForms.Guna2GroupBox gbMultiUnit;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMultiUnit;
        private Guna.UI2.WinForms.Guna2CheckBox cbMultiUnit;
    }
}