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
            lblCaptionUserName = new Label();
            lblCaptionCalories = new Label();
            lblCaptionDateCreated = new Label();
            lblCaptionDatePublished = new Label();
            lblCaptionDateArchived = new Label();
            lblCaptionRecipeStatus = new Label();
            txtCalories = new TextBox();
            txtDateArchived = new TextBox();
            txtRecipeStatus = new TextBox();
            txtRecipeName = new TextBox();
            lstCuisineName = new ComboBox();
            dtpDateCreated = new DateTimePicker();
            txtDatePublished = new TextBox();
            lstUserName = new ComboBox();
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
            tblMain.Controls.Add(lblCaptionUserName, 0, 2);
            tblMain.Controls.Add(lblCaptionCalories, 0, 3);
            tblMain.Controls.Add(lblCaptionDateCreated, 0, 4);
            tblMain.Controls.Add(lblCaptionDatePublished, 0, 5);
            tblMain.Controls.Add(lblCaptionDateArchived, 0, 6);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 7);
            tblMain.Controls.Add(txtCalories, 1, 3);
            tblMain.Controls.Add(txtDateArchived, 1, 6);
            tblMain.Controls.Add(txtRecipeStatus, 1, 7);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(lstCuisineName, 1, 1);
            tblMain.Controls.Add(dtpDateCreated, 1, 4);
            tblMain.Controls.Add(txtDatePublished, 1, 5);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Dock = DockStyle.Bottom;
            tblMain.Location = new Point(0, 38);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 8;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(549, 615);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Left;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.BackColor = Color.Azure;
            lblCaptionRecipeName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCaptionRecipeName.ForeColor = Color.CadetBlue;
            lblCaptionRecipeName.Location = new Point(3, 24);
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
            lblCaptionCuisineName.Location = new Point(3, 100);
            lblCaptionCuisineName.Name = "lblCaptionCuisineName";
            lblCaptionCuisineName.Size = new Size(142, 28);
            lblCaptionCuisineName.TabIndex = 1;
            lblCaptionCuisineName.Text = "Cuisine Name";
            // 
            // lblCaptionUserName
            // 
            lblCaptionUserName.Anchor = AnchorStyles.Left;
            lblCaptionUserName.AutoSize = true;
            lblCaptionUserName.BackColor = Color.Azure;
            lblCaptionUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCaptionUserName.ForeColor = Color.CadetBlue;
            lblCaptionUserName.Location = new Point(3, 176);
            lblCaptionUserName.Name = "lblCaptionUserName";
            lblCaptionUserName.Size = new Size(116, 28);
            lblCaptionUserName.TabIndex = 2;
            lblCaptionUserName.Text = "User Name";
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.Anchor = AnchorStyles.Left;
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.BackColor = Color.Azure;
            lblCaptionCalories.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCaptionCalories.ForeColor = Color.CadetBlue;
            lblCaptionCalories.Location = new Point(3, 252);
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
            lblCaptionDateCreated.Location = new Point(3, 328);
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
            lblCaptionDatePublished.Location = new Point(3, 404);
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
            lblCaptionDateArchived.Location = new Point(3, 480);
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
            lblCaptionRecipeStatus.Location = new Point(3, 559);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(140, 28);
            lblCaptionRecipeStatus.TabIndex = 8;
            lblCaptionRecipeStatus.Text = "Recipe Status";
            // 
            // txtCalories
            // 
            txtCalories.BackColor = Color.LightCyan;
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Font = new Font("Segoe UI", 12F);
            txtCalories.ForeColor = Color.LightSeaGreen;
            txtCalories.Location = new Point(202, 231);
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
            txtDateArchived.Location = new Point(202, 459);
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
            txtRecipeStatus.Location = new Point(202, 535);
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
            txtRecipeName.Location = new Point(202, 3);
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
            lstCuisineName.Location = new Point(202, 79);
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
            dtpDateCreated.Location = new Point(202, 307);
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
            txtDatePublished.Location = new Point(202, 383);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(344, 34);
            txtDatePublished.TabIndex = 21;
            // 
            // lstUserName
            // 
            lstUserName.BackColor = Color.LightCyan;
            lstUserName.Font = new Font("Segoe UI", 12F);
            lstUserName.ForeColor = Color.LightSeaGreen;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(202, 155);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(151, 36);
            lstUserName.TabIndex = 22;
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
        private Label lblCaptionUserName;
        private Label lblCaptionCalories;
        private Label lblCaptionDateCreated;
        private Label lblCaptionDatePublished;
        private Label lblCaptionDateArchived;
        private Label lblCaptionRecipeStatus;
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
        private ComboBox lstUserName;
    }
}