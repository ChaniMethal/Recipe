namespace RecipeWinForm
{
    partial class frmCookbook
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
            tblMain = new TableLayoutPanel();
            btnSaveCookbook = new Button();
            btnDeleteCookbook = new Button();
            lblCookbookName = new Label();
            lblUser = new Label();
            lblPrice = new Label();
            lblActive = new Label();
            lblDateCreated = new Label();
            txtCookbookName = new TextBox();
            txtPrice = new TextBox();
            lstUserName = new ComboBox();
            dtpDateCreated = new DateTimePicker();
            btnSaveCookbookSupper = new Button();
            gCookbookSuppers = new DataGridView();
            tblActiveButtons = new TableLayoutPanel();
            rdoActiveYes = new RadioButton();
            rdoActiveNo = new RadioButton();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gCookbookSuppers).BeginInit();
            tblActiveButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.22604F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.90352F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.8704357F));
            tblMain.Controls.Add(btnSaveCookbook, 0, 0);
            tblMain.Controls.Add(btnDeleteCookbook, 1, 0);
            tblMain.Controls.Add(lblCookbookName, 0, 1);
            tblMain.Controls.Add(lblUser, 0, 2);
            tblMain.Controls.Add(lblPrice, 0, 3);
            tblMain.Controls.Add(lblActive, 0, 4);
            tblMain.Controls.Add(lblDateCreated, 2, 3);
            tblMain.Controls.Add(txtCookbookName, 1, 1);
            tblMain.Controls.Add(txtPrice, 1, 3);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Controls.Add(dtpDateCreated, 2, 4);
            tblMain.Controls.Add(btnSaveCookbookSupper, 0, 5);
            tblMain.Controls.Add(gCookbookSuppers, 0, 6);
            tblMain.Controls.Add(tblActiveButtons, 1, 4);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 7;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(597, 615);
            tblMain.TabIndex = 0;
            // 
            // btnSaveCookbook
            // 
            btnSaveCookbook.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSaveCookbook.AutoSize = true;
            btnSaveCookbook.BackColor = Color.LightSteelBlue;
            btnSaveCookbook.Location = new Point(3, 3);
            btnSaveCookbook.Name = "btnSaveCookbook";
            btnSaveCookbook.Size = new Size(192, 38);
            btnSaveCookbook.TabIndex = 0;
            btnSaveCookbook.Text = "Save";
            btnSaveCookbook.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCookbook
            // 
            btnDeleteCookbook.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnDeleteCookbook.AutoSize = true;
            btnDeleteCookbook.BackColor = Color.LightSteelBlue;
            btnDeleteCookbook.Location = new Point(201, 3);
            btnDeleteCookbook.Name = "btnDeleteCookbook";
            btnDeleteCookbook.Size = new Size(220, 38);
            btnDeleteCookbook.TabIndex = 1;
            btnDeleteCookbook.Text = "Delete";
            btnDeleteCookbook.UseVisualStyleBackColor = false;
            // 
            // lblCookbookName
            // 
            lblCookbookName.Anchor = AnchorStyles.Right;
            lblCookbookName.AutoSize = true;
            lblCookbookName.Location = new Point(34, 50);
            lblCookbookName.Name = "lblCookbookName";
            lblCookbookName.Size = new Size(161, 28);
            lblCookbookName.TabIndex = 2;
            lblCookbookName.Text = "Cookbook Name";
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Right;
            lblUser.AutoSize = true;
            lblUser.Location = new Point(144, 91);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(51, 28);
            lblUser.TabIndex = 4;
            lblUser.Text = "User";
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Right;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(141, 132);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(54, 28);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price";
            // 
            // lblActive
            // 
            lblActive.Anchor = AnchorStyles.Right;
            lblActive.AutoSize = true;
            lblActive.Location = new Point(129, 173);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(66, 28);
            lblActive.TabIndex = 10;
            lblActive.Text = "Active";
            // 
            // lblDateCreated
            // 
            lblDateCreated.AutoSize = true;
            lblDateCreated.Location = new Point(427, 126);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(130, 28);
            lblDateCreated.TabIndex = 8;
            lblDateCreated.Text = "Date Created:";
            // 
            // txtCookbookName
            // 
            txtCookbookName.BackColor = Color.AliceBlue;
            tblMain.SetColumnSpan(txtCookbookName, 2);
            txtCookbookName.Dock = DockStyle.Fill;
            txtCookbookName.Location = new Point(201, 47);
            txtCookbookName.Name = "txtCookbookName";
            txtCookbookName.Size = new Size(393, 34);
            txtCookbookName.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.AliceBlue;
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Dock = DockStyle.Fill;
            txtPrice.Location = new Point(201, 129);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(220, 34);
            txtPrice.TabIndex = 7;
            // 
            // lstUserName
            // 
            lstUserName.BackColor = Color.AliceBlue;
            tblMain.SetColumnSpan(lstUserName, 2);
            lstUserName.Dock = DockStyle.Fill;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(201, 87);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(393, 36);
            lstUserName.TabIndex = 5;
            // 
            // dtpDateCreated
            // 
            dtpDateCreated.CalendarMonthBackground = Color.AliceBlue;
            dtpDateCreated.Format = DateTimePickerFormat.Short;
            dtpDateCreated.Location = new Point(427, 169);
            dtpDateCreated.Name = "dtpDateCreated";
            dtpDateCreated.Size = new Size(158, 34);
            dtpDateCreated.TabIndex = 9;
            dtpDateCreated.Value = new DateTime(2026, 6, 11, 4, 25, 57, 0);
            // 
            // btnSaveCookbookSupper
            // 
            btnSaveCookbookSupper.AutoSize = true;
            btnSaveCookbookSupper.BackColor = Color.LightSteelBlue;
            btnSaveCookbookSupper.Location = new Point(3, 211);
            btnSaveCookbookSupper.Name = "btnSaveCookbookSupper";
            btnSaveCookbookSupper.Size = new Size(94, 38);
            btnSaveCookbookSupper.TabIndex = 11;
            btnSaveCookbookSupper.Text = "Save";
            btnSaveCookbookSupper.UseVisualStyleBackColor = false;
            // 
            // gCookbookSuppers
            // 
            gCookbookSuppers.BackgroundColor = Color.AliceBlue;
            gCookbookSuppers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMain.SetColumnSpan(gCookbookSuppers, 3);
            gCookbookSuppers.Dock = DockStyle.Fill;
            gCookbookSuppers.Location = new Point(3, 255);
            gCookbookSuppers.Name = "gCookbookSuppers";
            gCookbookSuppers.RowHeadersWidth = 51;
            gCookbookSuppers.Size = new Size(591, 357);
            gCookbookSuppers.TabIndex = 12;
            // 
            // tblActiveButtons
            // 
            tblActiveButtons.ColumnCount = 2;
            tblActiveButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblActiveButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblActiveButtons.Controls.Add(rdoActiveYes, 0, 0);
            tblActiveButtons.Controls.Add(rdoActiveNo, 1, 0);
            tblActiveButtons.Dock = DockStyle.Fill;
            tblActiveButtons.Location = new Point(201, 169);
            tblActiveButtons.Name = "tblActiveButtons";
            tblActiveButtons.RowCount = 1;
            tblActiveButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblActiveButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblActiveButtons.Size = new Size(220, 36);
            tblActiveButtons.TabIndex = 14;
            // 
            // rdoActiveYes
            // 
            rdoActiveYes.AutoSize = true;
            rdoActiveYes.Dock = DockStyle.Fill;
            rdoActiveYes.Location = new Point(3, 3);
            rdoActiveYes.Name = "rdoActiveYes";
            rdoActiveYes.Size = new Size(104, 30);
            rdoActiveYes.TabIndex = 0;
            rdoActiveYes.TabStop = true;
            rdoActiveYes.Text = "Yes";
            rdoActiveYes.UseVisualStyleBackColor = true;
            // 
            // rdoActiveNo
            // 
            rdoActiveNo.AutoSize = true;
            rdoActiveNo.Dock = DockStyle.Fill;
            rdoActiveNo.Location = new Point(113, 3);
            rdoActiveNo.Name = "rdoActiveNo";
            rdoActiveNo.Size = new Size(104, 30);
            rdoActiveNo.TabIndex = 1;
            rdoActiveNo.TabStop = true;
            rdoActiveNo.Text = "No";
            rdoActiveNo.UseVisualStyleBackColor = true;
            // 
            // frmCookbook
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(597, 615);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmCookbook";
            Text = "Cookbook - Suppers On the Go";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gCookbookSuppers).EndInit();
            tblActiveButtons.ResumeLayout(false);
            tblActiveButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSaveCookbook;
        private Button btnDeleteCookbook;
        private Label lblCookbookName;
        private Label lblUser;
        private Label lblPrice;
        private Label lblActive;
        private Label lblDateCreated;
        private TextBox txtCookbookName;
        private TextBox txtPrice;
        private ComboBox lstUserName;
        private DateTimePicker dtpDateCreated;
        private Button btnSaveCookbookSupper;
        private DataGridView gCookbookSuppers;
        private TableLayoutPanel tblActiveButtons;
        private RadioButton rdoActiveYes;
        private RadioButton rdoActiveNo;
    }
}