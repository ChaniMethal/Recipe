namespace RecipeWinForms
{
    partial class frmRecipes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipes));
            tblMain = new TableLayoutPanel();
            lblCaptionRecipeName = new Label();
            lblCaptionCuisineName = new Label();
            lblCaptionUserFirstName = new Label();
            lblCaptionUserLastName = new Label();
            lblCaptionCalories = new Label();
            lblCaptionDateCreated = new Label();
            lblCaptionDatePublished = new Label();
            lblCaptionDateArchived = new Label();
            lblCaptionRecipeStatus = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtCalories = new TextBox();
            txtDateArchived = new TextBox();
            txtRecipeStatus = new TextBox();
            txtRecipeName = new TextBox();
            lstCuisineName = new ComboBox();
            dtpDateCreated = new DateTimePicker();
            txtDatePublished = new TextBox();
            tsMain = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tblMain.SuspendLayout();
            tsMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.BackColor = Color.Azure;
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.42987F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.57013F));
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 0);
            tblMain.Controls.Add(lblCaptionCuisineName, 0, 1);
            tblMain.Controls.Add(lblCaptionUserFirstName, 0, 2);
            tblMain.Controls.Add(lblCaptionUserLastName, 0, 3);
            tblMain.Controls.Add(lblCaptionCalories, 0, 4);
            tblMain.Controls.Add(lblCaptionDateCreated, 0, 5);
            tblMain.Controls.Add(lblCaptionDatePublished, 0, 6);
            tblMain.Controls.Add(lblCaptionDateArchived, 0, 7);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 8);
            tblMain.Controls.Add(txtFirstName, 1, 2);
            tblMain.Controls.Add(txtLastName, 1, 3);
            tblMain.Controls.Add(txtCalories, 1, 4);
            tblMain.Controls.Add(txtDateArchived, 1, 7);
            tblMain.Controls.Add(txtRecipeStatus, 1, 8);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(lstCuisineName, 1, 1);
            tblMain.Controls.Add(dtpDateCreated, 1, 5);
            tblMain.Controls.Add(txtDatePublished, 1, 6);
            tblMain.Location = new Point(-1, 38);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 9;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.Size = new Size(550, 615);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Left;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.BackColor = Color.Azure;
            lblCaptionRecipeName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCaptionRecipeName.ForeColor = Color.CadetBlue;
            lblCaptionRecipeName.Location = new Point(3, 20);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(137, 28);
            lblCaptionRecipeName.TabIndex = 0;
            lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // lblCaptionCuisineName
            // 
            lblCaptionCuisineName.Anchor = AnchorStyles.Left;
            lblCaptionCuisineName.AutoSize = true;
            lblCaptionCuisineName.BackColor = Color.Azure;
            lblCaptionCuisineName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCaptionCuisineName.ForeColor = Color.CadetBlue;
            lblCaptionCuisineName.Location = new Point(3, 88);
            lblCaptionCuisineName.Name = "lblCaptionCuisineName";
            lblCaptionCuisineName.Size = new Size(142, 28);
            lblCaptionCuisineName.TabIndex = 1;
            lblCaptionCuisineName.Text = "Cuisine Name";
            // 
            // lblCaptionUserFirstName
            // 
            lblCaptionUserFirstName.Anchor = AnchorStyles.Left;
            lblCaptionUserFirstName.AutoSize = true;
            lblCaptionUserFirstName.BackColor = Color.Azure;
            lblCaptionUserFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCaptionUserFirstName.ForeColor = Color.CadetBlue;
            lblCaptionUserFirstName.Location = new Point(3, 156);
            lblCaptionUserFirstName.Name = "lblCaptionUserFirstName";
            lblCaptionUserFirstName.Size = new Size(163, 28);
            lblCaptionUserFirstName.TabIndex = 2;
            lblCaptionUserFirstName.Text = "User First Name";
            // 
            // lblCaptionUserLastName
            // 
            lblCaptionUserLastName.Anchor = AnchorStyles.Left;
            lblCaptionUserLastName.AutoSize = true;
            lblCaptionUserLastName.BackColor = Color.Azure;
            lblCaptionUserLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCaptionUserLastName.ForeColor = Color.CadetBlue;
            lblCaptionUserLastName.Location = new Point(3, 224);
            lblCaptionUserLastName.Name = "lblCaptionUserLastName";
            lblCaptionUserLastName.Size = new Size(160, 28);
            lblCaptionUserLastName.TabIndex = 3;
            lblCaptionUserLastName.Text = "User Last Name";
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.Anchor = AnchorStyles.Left;
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.BackColor = Color.Azure;
            lblCaptionCalories.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCaptionCalories.ForeColor = Color.CadetBlue;
            lblCaptionCalories.Location = new Point(3, 292);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(87, 28);
            lblCaptionCalories.TabIndex = 4;
            lblCaptionCalories.Text = "Calories";
            // 
            // lblCaptionDateCreated
            // 
            lblCaptionDateCreated.Anchor = AnchorStyles.Left;
            lblCaptionDateCreated.AutoSize = true;
            lblCaptionDateCreated.BackColor = Color.Azure;
            lblCaptionDateCreated.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCaptionDateCreated.ForeColor = Color.CadetBlue;
            lblCaptionDateCreated.Location = new Point(3, 360);
            lblCaptionDateCreated.Name = "lblCaptionDateCreated";
            lblCaptionDateCreated.Size = new Size(136, 28);
            lblCaptionDateCreated.TabIndex = 5;
            lblCaptionDateCreated.Text = "Date Created";
            // 
            // lblCaptionDatePublished
            // 
            lblCaptionDatePublished.Anchor = AnchorStyles.Left;
            lblCaptionDatePublished.AutoSize = true;
            lblCaptionDatePublished.BackColor = Color.Azure;
            lblCaptionDatePublished.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCaptionDatePublished.ForeColor = Color.CadetBlue;
            lblCaptionDatePublished.Location = new Point(3, 428);
            lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            lblCaptionDatePublished.Size = new Size(155, 28);
            lblCaptionDatePublished.TabIndex = 6;
            lblCaptionDatePublished.Text = "Date Published";
            // 
            // lblCaptionDateArchived
            // 
            lblCaptionDateArchived.Anchor = AnchorStyles.Left;
            lblCaptionDateArchived.AutoSize = true;
            lblCaptionDateArchived.BackColor = Color.Azure;
            lblCaptionDateArchived.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCaptionDateArchived.ForeColor = Color.CadetBlue;
            lblCaptionDateArchived.Location = new Point(3, 496);
            lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            lblCaptionDateArchived.Size = new Size(147, 28);
            lblCaptionDateArchived.TabIndex = 7;
            lblCaptionDateArchived.Text = "Date Archived";
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.Anchor = AnchorStyles.Left;
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.BackColor = Color.Azure;
            lblCaptionRecipeStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCaptionRecipeStatus.ForeColor = Color.CadetBlue;
            lblCaptionRecipeStatus.Location = new Point(3, 565);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(140, 28);
            lblCaptionRecipeStatus.TabIndex = 8;
            lblCaptionRecipeStatus.Text = "Recipe Status";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.LightCyan;
            txtFirstName.Dock = DockStyle.Fill;
            txtFirstName.Font = new Font("Segoe UI", 12F);
            txtFirstName.ForeColor = Color.LightSeaGreen;
            txtFirstName.Location = new Point(203, 139);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(344, 34);
            txtFirstName.TabIndex = 11;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.LightCyan;
            txtLastName.Dock = DockStyle.Fill;
            txtLastName.Font = new Font("Segoe UI", 12F);
            txtLastName.ForeColor = Color.LightSeaGreen;
            txtLastName.Location = new Point(203, 207);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(344, 34);
            txtLastName.TabIndex = 12;
            // 
            // txtCalories
            // 
            txtCalories.BackColor = Color.LightCyan;
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Font = new Font("Segoe UI", 12F);
            txtCalories.ForeColor = Color.LightSeaGreen;
            txtCalories.Location = new Point(203, 275);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(344, 34);
            txtCalories.TabIndex = 13;
            // 
            // txtDateArchived
            // 
            txtDateArchived.BackColor = Color.LightCyan;
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Enabled = false;
            txtDateArchived.Font = new Font("Segoe UI", 12F);
            txtDateArchived.ForeColor = Color.LightSeaGreen;
            txtDateArchived.Location = new Point(203, 479);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(344, 34);
            txtDateArchived.TabIndex = 16;
            // 
            // txtRecipeStatus
            // 
            txtRecipeStatus.BackColor = Color.LightCyan;
            txtRecipeStatus.Dock = DockStyle.Fill;
            txtRecipeStatus.Enabled = false;
            txtRecipeStatus.Font = new Font("Segoe UI", 12F);
            txtRecipeStatus.ForeColor = Color.LightSeaGreen;
            txtRecipeStatus.Location = new Point(203, 547);
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.ReadOnly = true;
            txtRecipeStatus.Size = new Size(344, 34);
            txtRecipeStatus.TabIndex = 17;
            // 
            // txtRecipeName
            // 
            txtRecipeName.BackColor = Color.LightCyan;
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRecipeName.ForeColor = Color.LightSeaGreen;
            txtRecipeName.Location = new Point(203, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(344, 34);
            txtRecipeName.TabIndex = 1;
            // 
            // lstCuisineName
            // 
            lstCuisineName.BackColor = Color.LightCyan;
            lstCuisineName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstCuisineName.ForeColor = Color.LightSeaGreen;
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.Location = new Point(203, 71);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(151, 36);
            lstCuisineName.TabIndex = 19;
            // 
            // dtpDateCreated
            // 
            dtpDateCreated.CalendarForeColor = Color.LightSeaGreen;
            dtpDateCreated.CalendarMonthBackground = Color.LightCyan;
            dtpDateCreated.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateCreated.Format = DateTimePickerFormat.Short;
            dtpDateCreated.Location = new Point(203, 343);
            dtpDateCreated.Name = "dtpDateCreated";
            dtpDateCreated.Size = new Size(151, 34);
            dtpDateCreated.TabIndex = 20;
            dtpDateCreated.Value = new DateTime(2026, 4, 27, 8, 29, 38, 0);
            // 
            // txtDatePublished
            // 
            txtDatePublished.BackColor = Color.LightCyan;
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Enabled = false;
            txtDatePublished.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDatePublished.ForeColor = Color.LightSeaGreen;
            txtDatePublished.Location = new Point(203, 411);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(344, 34);
            txtDatePublished.TabIndex = 21;
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete, toolStripSeparator2 });
            tsMain.Location = new Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(549, 35);
            tsMain.TabIndex = 1;
            tsMain.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(57, 32);
            btnSave.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 35);
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(72, 32);
            btnDelete.Text = "Delete";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 35);
            // 
            // frmRecipes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 653);
            Controls.Add(tsMain);
            Controls.Add(tblMain);
            Name = "frmRecipes";
            Text = "frmRecipes";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionRecipeName;
        private Label lblCaptionCuisineName;
        private Label lblCaptionUserFirstName;
        private Label lblCaptionUserLastName;
        private Label lblCaptionCalories;
        private Label lblCaptionDateCreated;
        private Label lblCaptionDatePublished;
        private Label lblCaptionDateArchived;
        private Label lblCaptionRecipeStatus;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtCalories;
        private TextBox txtDateArchived;
        private ToolStrip tsMain;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private TextBox txtRecipeName;
        private ComboBox lstCuisineName;
        private DateTimePicker dtpDateCreated;
        private TextBox txtRecipeStatus;
        private TextBox txtDatePublished;
    }
}