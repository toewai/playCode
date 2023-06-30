namespace UI.Shop
{
    partial class FrmCustomer
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
            this.btnCustomerSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.gbGeneral = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnSaleCodeSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnCustomerBookSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtSaleCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSaleCode = new System.Windows.Forms.Label();
            this.btnOpenBook = new Guna.UI2.WinForms.Guna2Button();
            this.txtCustomerBook = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCustomerBook = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPhone2 = new System.Windows.Forms.Label();
            this.txtPhone1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPhone1 = new System.Windows.Forms.Label();
            this.txtCity = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtState = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtContAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblConAddress = new System.Windows.Forms.Label();
            this.txtPerAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPerAddress = new System.Windows.Forms.Label();
            this.txtNRCNO = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNrcNo = new System.Windows.Forms.Label();
            this.cbInactive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.gbGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.BackColor = System.Drawing.Color.Gray;
            this.btnCustomerSearch.CheckedState.Parent = this.btnCustomerSearch;
            this.btnCustomerSearch.HoverState.Parent = this.btnCustomerSearch;
            this.btnCustomerSearch.Location = new System.Drawing.Point(485, 21);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.PressedState.Parent = this.btnCustomerSearch;
            this.btnCustomerSearch.Size = new System.Drawing.Size(40, 40);
            this.btnCustomerSearch.TabIndex = 2;
            this.btnCustomerSearch.Click += new System.EventHandler(this.BtnCustomerSearch_Click);
            // 
            // gbGeneral
            // 
            this.gbGeneral.BorderColor = System.Drawing.Color.Transparent;
            this.gbGeneral.Controls.Add(this.btnSaleCodeSearch);
            this.gbGeneral.Controls.Add(this.btnCustomerBookSearch);
            this.gbGeneral.Controls.Add(this.txtSaleCode);
            this.gbGeneral.Controls.Add(this.lblSaleCode);
            this.gbGeneral.Controls.Add(this.btnOpenBook);
            this.gbGeneral.Controls.Add(this.txtCustomerBook);
            this.gbGeneral.Controls.Add(this.lblCustomerBook);
            this.gbGeneral.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGeneral.ForeColor = System.Drawing.Color.Black;
            this.gbGeneral.Location = new System.Drawing.Point(217, 462);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.ShadowDecoration.Parent = this.gbGeneral;
            this.gbGeneral.Size = new System.Drawing.Size(736, 155);
            this.gbGeneral.TabIndex = 12;
            this.gbGeneral.Text = "အထွေထွေစာရင်း";
            // 
            // btnSaleCodeSearch
            // 
            this.btnSaleCodeSearch.BackColor = System.Drawing.Color.Gray;
            this.btnSaleCodeSearch.CheckedState.Parent = this.btnSaleCodeSearch;
            this.btnSaleCodeSearch.HoverState.Parent = this.btnSaleCodeSearch;
            this.btnSaleCodeSearch.Location = new System.Drawing.Point(451, 96);
            this.btnSaleCodeSearch.Name = "btnSaleCodeSearch";
            this.btnSaleCodeSearch.PressedState.Parent = this.btnSaleCodeSearch;
            this.btnSaleCodeSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSaleCodeSearch.TabIndex = 15;
            // 
            // btnCustomerBookSearch
            // 
            this.btnCustomerBookSearch.BackColor = System.Drawing.Color.Gray;
            this.btnCustomerBookSearch.CheckedState.Parent = this.btnCustomerBookSearch;
            this.btnCustomerBookSearch.HoverState.Parent = this.btnCustomerBookSearch;
            this.btnCustomerBookSearch.Location = new System.Drawing.Point(451, 51);
            this.btnCustomerBookSearch.Name = "btnCustomerBookSearch";
            this.btnCustomerBookSearch.PressedState.Parent = this.btnCustomerBookSearch;
            this.btnCustomerBookSearch.Size = new System.Drawing.Size(40, 40);
            this.btnCustomerBookSearch.TabIndex = 13;
            // 
            // txtSaleCode
            // 
            this.txtSaleCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSaleCode.DefaultText = "";
            this.txtSaleCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSaleCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSaleCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSaleCode.DisabledState.Parent = this.txtSaleCode;
            this.txtSaleCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSaleCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSaleCode.FocusedState.Parent = this.txtSaleCode;
            this.txtSaleCode.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSaleCode.HoverState.Parent = this.txtSaleCode;
            this.txtSaleCode.Location = new System.Drawing.Point(259, 99);
            this.txtSaleCode.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtSaleCode.Name = "txtSaleCode";
            this.txtSaleCode.PasswordChar = '\0';
            this.txtSaleCode.PlaceholderText = "";
            this.txtSaleCode.SelectedText = "";
            this.txtSaleCode.ShadowDecoration.Parent = this.txtSaleCode;
            this.txtSaleCode.Size = new System.Drawing.Size(183, 36);
            this.txtSaleCode.TabIndex = 14;
            // 
            // lblSaleCode
            // 
            this.lblSaleCode.AutoSize = true;
            this.lblSaleCode.BackColor = System.Drawing.Color.Transparent;
            this.lblSaleCode.ForeColor = System.Drawing.Color.Black;
            this.lblSaleCode.Location = new System.Drawing.Point(132, 102);
            this.lblSaleCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSaleCode.Name = "lblSaleCode";
            this.lblSaleCode.Size = new System.Drawing.Size(115, 33);
            this.lblSaleCode.TabIndex = 54;
            this.lblSaleCode.Text = "ကုန်ဝယ် ကုဒ်";
            // 
            // btnOpenBook
            // 
            this.btnOpenBook.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenBook.BorderThickness = 1;
            this.btnOpenBook.CheckedState.Parent = this.btnOpenBook;
            this.btnOpenBook.CustomImages.Parent = this.btnOpenBook;
            this.btnOpenBook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnOpenBook.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenBook.ForeColor = System.Drawing.Color.White;
            this.btnOpenBook.HoverState.Parent = this.btnOpenBook;
            this.btnOpenBook.Location = new System.Drawing.Point(584, 65);
            this.btnOpenBook.Name = "btnOpenBook";
            this.btnOpenBook.ShadowDecoration.BorderRadius = 27;
            this.btnOpenBook.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnOpenBook.ShadowDecoration.Enabled = true;
            this.btnOpenBook.ShadowDecoration.Parent = this.btnOpenBook;
            this.btnOpenBook.Size = new System.Drawing.Size(134, 56);
            this.btnOpenBook.TabIndex = 16;
            this.btnOpenBook.Text = "စာရင်းဖွင့်ငွေ ";
            // 
            // txtCustomerBook
            // 
            this.txtCustomerBook.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerBook.DefaultText = "";
            this.txtCustomerBook.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerBook.DisabledState.Parent = this.txtCustomerBook;
            this.txtCustomerBook.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerBook.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerBook.FocusedState.Parent = this.txtCustomerBook;
            this.txtCustomerBook.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerBook.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerBook.HoverState.Parent = this.txtCustomerBook;
            this.txtCustomerBook.Location = new System.Drawing.Point(259, 53);
            this.txtCustomerBook.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtCustomerBook.Name = "txtCustomerBook";
            this.txtCustomerBook.PasswordChar = '\0';
            this.txtCustomerBook.PlaceholderText = "";
            this.txtCustomerBook.SelectedText = "";
            this.txtCustomerBook.ShadowDecoration.Parent = this.txtCustomerBook;
            this.txtCustomerBook.Size = new System.Drawing.Size(183, 36);
            this.txtCustomerBook.TabIndex = 12;
            // 
            // lblCustomerBook
            // 
            this.lblCustomerBook.AutoSize = true;
            this.lblCustomerBook.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerBook.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerBook.Location = new System.Drawing.Point(22, 56);
            this.lblCustomerBook.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCustomerBook.Name = "lblCustomerBook";
            this.lblCustomerBook.Size = new System.Drawing.Size(227, 33);
            this.lblCustomerBook.TabIndex = 51;
            this.lblCustomerBook.Text = "ပေးရန်ရှိသူ၏ ငွေစာရင်း ကုဒ်";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(727, 247);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(260, 36);
            this.txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(540, 250);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(141, 33);
            this.lblEmail.TabIndex = 98;
            this.lblEmail.Text = "အီးမေးလ်လိပ်စာ";
            // 
            // txtPhone2
            // 
            this.txtPhone2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone2.DefaultText = "";
            this.txtPhone2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone2.DisabledState.Parent = this.txtPhone2;
            this.txtPhone2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone2.FocusedState.Parent = this.txtPhone2;
            this.txtPhone2.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone2.HoverState.Parent = this.txtPhone2;
            this.txtPhone2.Location = new System.Drawing.Point(727, 195);
            this.txtPhone2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.PasswordChar = '\0';
            this.txtPhone2.PlaceholderText = "";
            this.txtPhone2.SelectedText = "";
            this.txtPhone2.ShadowDecoration.Parent = this.txtPhone2;
            this.txtPhone2.Size = new System.Drawing.Size(260, 36);
            this.txtPhone2.TabIndex = 10;
            // 
            // lblPhone2
            // 
            this.lblPhone2.AutoSize = true;
            this.lblPhone2.Location = new System.Drawing.Point(540, 198);
            this.lblPhone2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPhone2.Name = "lblPhone2";
            this.lblPhone2.Size = new System.Drawing.Size(106, 33);
            this.lblPhone2.TabIndex = 97;
            this.lblPhone2.Text = "ဖုန်းနံပါတ် ၂";
            // 
            // txtPhone1
            // 
            this.txtPhone1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone1.DefaultText = "";
            this.txtPhone1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone1.DisabledState.Parent = this.txtPhone1;
            this.txtPhone1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone1.FocusedState.Parent = this.txtPhone1;
            this.txtPhone1.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone1.HoverState.Parent = this.txtPhone1;
            this.txtPhone1.Location = new System.Drawing.Point(727, 138);
            this.txtPhone1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.PasswordChar = '\0';
            this.txtPhone1.PlaceholderText = "";
            this.txtPhone1.SelectedText = "";
            this.txtPhone1.ShadowDecoration.Parent = this.txtPhone1;
            this.txtPhone1.Size = new System.Drawing.Size(260, 36);
            this.txtPhone1.TabIndex = 9;
            // 
            // lblPhone1
            // 
            this.lblPhone1.AutoSize = true;
            this.lblPhone1.Location = new System.Drawing.Point(540, 141);
            this.lblPhone1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPhone1.Name = "lblPhone1";
            this.lblPhone1.Size = new System.Drawing.Size(108, 33);
            this.lblPhone1.TabIndex = 96;
            this.lblPhone1.Text = "ဖုန်းနံပါတ် ၁";
            // 
            // txtCity
            // 
            this.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCity.DefaultText = "";
            this.txtCity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCity.DisabledState.Parent = this.txtCity;
            this.txtCity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCity.FocusedState.Parent = this.txtCity;
            this.txtCity.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCity.HoverState.Parent = this.txtCity;
            this.txtCity.Location = new System.Drawing.Point(727, 81);
            this.txtCity.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtCity.Name = "txtCity";
            this.txtCity.PasswordChar = '\0';
            this.txtCity.PlaceholderText = "";
            this.txtCity.SelectedText = "";
            this.txtCity.ShadowDecoration.Parent = this.txtCity;
            this.txtCity.Size = new System.Drawing.Size(260, 36);
            this.txtCity.TabIndex = 8;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(540, 84);
            this.lblCity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(37, 33);
            this.lblCity.TabIndex = 95;
            this.lblCity.Text = "မြို့";
            // 
            // txtState
            // 
            this.txtState.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtState.DefaultText = "";
            this.txtState.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtState.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtState.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtState.DisabledState.Parent = this.txtState;
            this.txtState.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtState.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtState.FocusedState.Parent = this.txtState;
            this.txtState.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtState.HoverState.Parent = this.txtState;
            this.txtState.Location = new System.Drawing.Point(727, 24);
            this.txtState.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtState.Name = "txtState";
            this.txtState.PasswordChar = '\0';
            this.txtState.PlaceholderText = "";
            this.txtState.SelectedText = "";
            this.txtState.ShadowDecoration.Parent = this.txtState;
            this.txtState.Size = new System.Drawing.Size(260, 36);
            this.txtState.TabIndex = 7;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(540, 27);
            this.lblState.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(126, 33);
            this.lblState.TabIndex = 94;
            this.lblState.Text = "တိုင်း/ပြည်နယ်";
            // 
            // txtContAddress
            // 
            this.txtContAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContAddress.DefaultText = "";
            this.txtContAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContAddress.DisabledState.Parent = this.txtContAddress;
            this.txtContAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContAddress.FocusedState.Parent = this.txtContAddress;
            this.txtContAddress.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContAddress.HoverState.Parent = this.txtContAddress;
            this.txtContAddress.Location = new System.Drawing.Point(217, 326);
            this.txtContAddress.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtContAddress.Multiline = true;
            this.txtContAddress.Name = "txtContAddress";
            this.txtContAddress.PasswordChar = '\0';
            this.txtContAddress.PlaceholderText = "";
            this.txtContAddress.SelectedText = "";
            this.txtContAddress.ShadowDecoration.Parent = this.txtContAddress;
            this.txtContAddress.Size = new System.Drawing.Size(260, 110);
            this.txtContAddress.TabIndex = 6;
            // 
            // lblConAddress
            // 
            this.lblConAddress.AutoSize = true;
            this.lblConAddress.Location = new System.Drawing.Point(19, 326);
            this.lblConAddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblConAddress.Name = "lblConAddress";
            this.lblConAddress.Size = new System.Drawing.Size(175, 33);
            this.lblConAddress.TabIndex = 93;
            this.lblConAddress.Text = "ဆက်သွယ်ရန် လိပ်စာ";
            // 
            // txtPerAddress
            // 
            this.txtPerAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPerAddress.DefaultText = "";
            this.txtPerAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPerAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPerAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPerAddress.DisabledState.Parent = this.txtPerAddress;
            this.txtPerAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPerAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPerAddress.FocusedState.Parent = this.txtPerAddress;
            this.txtPerAddress.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPerAddress.HoverState.Parent = this.txtPerAddress;
            this.txtPerAddress.Location = new System.Drawing.Point(217, 195);
            this.txtPerAddress.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtPerAddress.Multiline = true;
            this.txtPerAddress.Name = "txtPerAddress";
            this.txtPerAddress.PasswordChar = '\0';
            this.txtPerAddress.PlaceholderText = "";
            this.txtPerAddress.SelectedText = "";
            this.txtPerAddress.ShadowDecoration.Parent = this.txtPerAddress;
            this.txtPerAddress.Size = new System.Drawing.Size(260, 110);
            this.txtPerAddress.TabIndex = 5;
            // 
            // lblPerAddress
            // 
            this.lblPerAddress.AutoSize = true;
            this.lblPerAddress.Location = new System.Drawing.Point(19, 198);
            this.lblPerAddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPerAddress.Name = "lblPerAddress";
            this.lblPerAddress.Size = new System.Drawing.Size(190, 33);
            this.lblPerAddress.TabIndex = 92;
            this.lblPerAddress.Text = "အမြဲတမ်း နေရပ်လိပ်စာ";
            // 
            // txtNRCNO
            // 
            this.txtNRCNO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNRCNO.DefaultText = "";
            this.txtNRCNO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNRCNO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNRCNO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNRCNO.DisabledState.Parent = this.txtNRCNO;
            this.txtNRCNO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNRCNO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNRCNO.FocusedState.Parent = this.txtNRCNO;
            this.txtNRCNO.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNRCNO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNRCNO.HoverState.Parent = this.txtNRCNO;
            this.txtNRCNO.Location = new System.Drawing.Point(217, 138);
            this.txtNRCNO.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtNRCNO.Name = "txtNRCNO";
            this.txtNRCNO.PasswordChar = '\0';
            this.txtNRCNO.PlaceholderText = "";
            this.txtNRCNO.SelectedText = "";
            this.txtNRCNO.ShadowDecoration.Parent = this.txtNRCNO;
            this.txtNRCNO.Size = new System.Drawing.Size(260, 36);
            this.txtNRCNO.TabIndex = 4;
            // 
            // lblNrcNo
            // 
            this.lblNrcNo.AutoSize = true;
            this.lblNrcNo.Location = new System.Drawing.Point(19, 141);
            this.lblNrcNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNrcNo.Name = "lblNrcNo";
            this.lblNrcNo.Size = new System.Drawing.Size(142, 33);
            this.lblNrcNo.TabIndex = 91;
            this.lblNrcNo.Text = "မှတ်ပုံတင် နံပါတ်";
            // 
            // cbInactive
            // 
            this.cbInactive.AutoSize = true;
            this.cbInactive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbInactive.CheckedState.BorderRadius = 2;
            this.cbInactive.CheckedState.BorderThickness = 0;
            this.cbInactive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbInactive.Location = new System.Drawing.Point(217, 627);
            this.cbInactive.Name = "cbInactive";
            this.cbInactive.Size = new System.Drawing.Size(179, 37);
            this.cbInactive.TabIndex = 17;
            this.cbInactive.Text = "ကုန်ရောင်း ရပ်ဆိုင်း";
            this.cbInactive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbInactive.UncheckedState.BorderRadius = 2;
            this.cbInactive.UncheckedState.BorderThickness = 0;
            this.cbInactive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbInactive.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BorderRadius = 20;
            this.btnClose.FillColor = System.Drawing.Color.Blue;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1046, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 90;
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
            this.txtName.Location = new System.Drawing.Point(217, 81);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(260, 36);
            this.txtName.TabIndex = 3;
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
            this.txtCode.Location = new System.Drawing.Point(217, 24);
            this.txtCode.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.PlaceholderText = "";
            this.txtCode.SelectedText = "";
            this.txtCode.ShadowDecoration.Parent = this.txtCode;
            this.txtCode.Size = new System.Drawing.Size(260, 36);
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
            this.btnSave.Location = new System.Drawing.Point(25, 670);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.BorderRadius = 27;
            this.btnSave.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnSave.ShadowDecoration.Enabled = true;
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(134, 56);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "သိမ်းမည်";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 84);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(157, 33);
            this.lblName.TabIndex = 89;
            this.lblName.Text = "ကုန်သွင်းသူ အမည်";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(19, 27);
            this.lblCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(138, 33);
            this.lblCode.TabIndex = 88;
            this.lblCode.Text = "ကုန်သွင်းသူ ကုဒ်";
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
            this.btnReset.Location = new System.Drawing.Point(193, 670);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.BorderRadius = 27;
            this.btnReset.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnReset.ShadowDecoration.Enabled = true;
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(134, 56);
            this.btnReset.TabIndex = 99;
            this.btnReset.Text = " အသစ်";
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1093, 749);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCustomerSearch);
            this.Controls.Add(this.gbGeneral);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone2);
            this.Controls.Add(this.lblPhone2);
            this.Controls.Add(this.txtPhone1);
            this.Controls.Add(this.lblPhone1);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtContAddress);
            this.Controls.Add(this.lblConAddress);
            this.Controls.Add(this.txtPerAddress);
            this.Controls.Add(this.lblPerAddress);
            this.Controls.Add(this.txtNRCNO);
            this.Controls.Add(this.lblNrcNo);
            this.Controls.Add(this.cbInactive);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Font = new System.Drawing.Font("Pyidaungsu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "FrmCustomer";
            this.Text = "FrmCustomer";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnCustomerSearch;
        private Guna.UI2.WinForms.Guna2GroupBox gbGeneral;
        private Guna.UI2.WinForms.Guna2ImageButton btnSaleCodeSearch;
        private Guna.UI2.WinForms.Guna2ImageButton btnCustomerBookSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSaleCode;
        private System.Windows.Forms.Label lblSaleCode;
        private Guna.UI2.WinForms.Guna2Button btnOpenBook;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerBook;
        private System.Windows.Forms.Label lblCustomerBook;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone2;
        private System.Windows.Forms.Label lblPhone2;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone1;
        private System.Windows.Forms.Label lblPhone1;
        private Guna.UI2.WinForms.Guna2TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private Guna.UI2.WinForms.Guna2TextBox txtState;
        private System.Windows.Forms.Label lblState;
        private Guna.UI2.WinForms.Guna2TextBox txtContAddress;
        private System.Windows.Forms.Label lblConAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtPerAddress;
        private System.Windows.Forms.Label lblPerAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtNRCNO;
        private System.Windows.Forms.Label lblNrcNo;
        private Guna.UI2.WinForms.Guna2CheckBox cbInactive;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtCode;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private Guna.UI2.WinForms.Guna2Button btnReset;
    }
}