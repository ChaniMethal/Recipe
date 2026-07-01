namespace RecipeWinForm
{
    partial class frmRecipe 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipe));
            tblMain = new TableLayoutPanel();
            lblCaptionRecipeName = new Label();
            lblCaptionCalories = new Label();
            lblCurrentStatus = new Label();
            txtCalories = new TextBox();
            txtRecipeName = new TextBox();
            lblCaptionCuisineName = new Label();
            lblCaptionUserName = new Label();
            lstUserName = new ComboBox();
            lstCuisineName = new ComboBox();
            lblRecipeStatus = new Label();
            tblStatusDates = new TableLayoutPanel();
            lblDateDrafted = new Label();
            lblDatePublished = new Label();
            lblArchived = new Label();
            txtDateCreated = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            lblStatusDates = new Label();
            tbMain = new TabControl();
            tbIngredients = new TabPage();
            tblIngredients = new TableLayoutPanel();
            btnSaveIngredient = new Button();
            gIngredients = new DataGridView();
            tbSteps = new TabPage();
            tblSteps = new TableLayoutPanel();
            btnSaveSteps = new Button();
            gSteps = new DataGridView();
            tsMain = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnChangeStatus = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            tblBackground = new TableLayoutPanel();
            tblMain.SuspendLayout();
            tblStatusDates.SuspendLayout();
            tbMain.SuspendLayout();
            tbIngredients.SuspendLayout();
            tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).BeginInit();
            tbSteps.SuspendLayout();
            tblSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).BeginInit();
            tsMain.SuspendLayout();
            tblBackground.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.BackColor = Color.AliceBlue;
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.6867046F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.31329F));
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 0);
            tblMain.Controls.Add(lblCaptionCalories, 0, 3);
            tblMain.Controls.Add(lblCurrentStatus, 0, 5);
            tblMain.Controls.Add(txtCalories, 1, 3);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(lblCaptionCuisineName, 0, 2);
            tblMain.Controls.Add(lblCaptionUserName, 0, 1);
            tblMain.Controls.Add(lstUserName, 1, 1);
            tblMain.Controls.Add(lstCuisineName, 1, 2);
            tblMain.Controls.Add(lblRecipeStatus, 1, 5);
            tblMain.Controls.Add(tblStatusDates, 1, 6);
            tblMain.Controls.Add(lblStatusDates, 0, 6);
            tblMain.Controls.Add(tbMain, 0, 7);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(3, 38);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 8;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(883, 577);
            tblMain.TabIndex = 1;
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Right;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.BackColor = Color.AliceBlue;
            lblCaptionRecipeName.Font = new Font("Segoe UI", 12F);
            lblCaptionRecipeName.ForeColor = SystemColors.ControlText;
            lblCaptionRecipeName.Location = new Point(115, 6);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(126, 28);
            lblCaptionRecipeName.TabIndex = 0;
            lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.BackColor = Color.AliceBlue;
            lblCaptionCalories.Font = new Font("Segoe UI", 12F);
            lblCaptionCalories.ForeColor = SystemColors.ControlText;
            lblCaptionCalories.Location = new Point(3, 130);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(238, 28);
            lblCaptionCalories.TabIndex = 6;
            lblCaptionCalories.Text = "Num Calories";
            lblCaptionCalories.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.BackColor = Color.AliceBlue;
            lblCurrentStatus.Font = new Font("Segoe UI", 12F);
            lblCurrentStatus.ForeColor = SystemColors.ControlText;
            lblCurrentStatus.Location = new Point(3, 164);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(238, 28);
            lblCurrentStatus.TabIndex = 8;
            lblCurrentStatus.Text = "Current Status";
            lblCurrentStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCalories
            // 
            txtCalories.BackColor = Color.AliceBlue;
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Font = new Font("Segoe UI", 12F);
            txtCalories.ForeColor = Color.SteelBlue;
            txtCalories.Location = new Point(247, 127);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(633, 34);
            txtCalories.TabIndex = 7;
            // 
            // txtRecipeName
            // 
            txtRecipeName.BackColor = Color.AliceBlue;
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRecipeName.ForeColor = Color.SteelBlue;
            txtRecipeName.Location = new Point(247, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(633, 34);
            txtRecipeName.TabIndex = 1;
            // 
            // lblCaptionCuisineName
            // 
            lblCaptionCuisineName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCaptionCuisineName.AutoSize = true;
            lblCaptionCuisineName.BackColor = Color.AliceBlue;
            lblCaptionCuisineName.Font = new Font("Segoe UI", 12F);
            lblCaptionCuisineName.ForeColor = SystemColors.ControlText;
            lblCaptionCuisineName.Location = new Point(3, 89);
            lblCaptionCuisineName.Name = "lblCaptionCuisineName";
            lblCaptionCuisineName.Size = new Size(238, 28);
            lblCaptionCuisineName.TabIndex = 4;
            lblCaptionCuisineName.Text = "Cuisine";
            lblCaptionCuisineName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCaptionUserName
            // 
            lblCaptionUserName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCaptionUserName.AutoSize = true;
            lblCaptionUserName.BackColor = Color.AliceBlue;
            lblCaptionUserName.Font = new Font("Segoe UI", 12F);
            lblCaptionUserName.ForeColor = SystemColors.ControlText;
            lblCaptionUserName.Location = new Point(3, 47);
            lblCaptionUserName.Name = "lblCaptionUserName";
            lblCaptionUserName.Size = new Size(238, 28);
            lblCaptionUserName.TabIndex = 2;
            lblCaptionUserName.Text = "User";
            lblCaptionUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lstUserName
            // 
            lstUserName.BackColor = Color.AliceBlue;
            lstUserName.Font = new Font("Segoe UI", 12F);
            lstUserName.ForeColor = Color.SteelBlue;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(247, 43);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(151, 36);
            lstUserName.TabIndex = 3;
            // 
            // lstCuisineName
            // 
            lstCuisineName.BackColor = Color.AliceBlue;
            lstCuisineName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstCuisineName.ForeColor = Color.SteelBlue;
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.Location = new Point(247, 85);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(151, 36);
            lstCuisineName.TabIndex = 5;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.BackColor = Color.LightSteelBlue;
            lblRecipeStatus.Dock = DockStyle.Top;
            lblRecipeStatus.Location = new Point(247, 164);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(633, 20);
            lblRecipeStatus.TabIndex = 9;
            // 
            // tblStatusDates
            // 
            tblStatusDates.ColumnCount = 3;
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.Controls.Add(lblDateDrafted, 0, 0);
            tblStatusDates.Controls.Add(lblDatePublished, 1, 0);
            tblStatusDates.Controls.Add(lblArchived, 2, 0);
            tblStatusDates.Controls.Add(txtDateCreated, 0, 1);
            tblStatusDates.Controls.Add(txtDatePublished, 1, 1);
            tblStatusDates.Controls.Add(txtDateArchived, 2, 1);
            tblStatusDates.Dock = DockStyle.Fill;
            tblStatusDates.Location = new Point(247, 195);
            tblStatusDates.Name = "tblStatusDates";
            tblStatusDates.RowCount = 2;
            tblStatusDates.RowStyles.Add(new RowStyle());
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblStatusDates.Size = new Size(633, 60);
            tblStatusDates.TabIndex = 25;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateDrafted.Location = new Point(3, 0);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(205, 28);
            lblDateDrafted.TabIndex = 0;
            lblDateDrafted.Text = "Drafted";
            // 
            // lblDatePublished
            // 
            lblDatePublished.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDatePublished.AutoSize = true;
            lblDatePublished.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDatePublished.Location = new Point(214, 0);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(205, 28);
            lblDatePublished.TabIndex = 2;
            lblDatePublished.Text = "Published";
            // 
            // lblArchived
            // 
            lblArchived.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblArchived.AutoSize = true;
            lblArchived.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArchived.Location = new Point(425, 0);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(205, 28);
            lblArchived.TabIndex = 4;
            lblArchived.Text = "Archived";
            // 
            // txtDateCreated
            // 
            txtDateCreated.BackColor = Color.LightSteelBlue;
            txtDateCreated.BorderStyle = BorderStyle.FixedSingle;
            txtDateCreated.Dock = DockStyle.Fill;
            txtDateCreated.Enabled = false;
            txtDateCreated.Location = new Point(3, 31);
            txtDateCreated.Name = "txtDateCreated";
            txtDateCreated.Size = new Size(205, 27);
            txtDateCreated.TabIndex = 1;
            // 
            // txtDatePublished
            // 
            txtDatePublished.BackColor = Color.LightSteelBlue;
            txtDatePublished.BorderStyle = BorderStyle.FixedSingle;
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Enabled = false;
            txtDatePublished.Location = new Point(214, 31);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(205, 27);
            txtDatePublished.TabIndex = 3;
            // 
            // txtDateArchived
            // 
            txtDateArchived.BackColor = Color.LightSteelBlue;
            txtDateArchived.BorderStyle = BorderStyle.FixedSingle;
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Enabled = false;
            txtDateArchived.Location = new Point(425, 31);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(205, 27);
            txtDateArchived.TabIndex = 5;
            // 
            // lblStatusDates
            // 
            lblStatusDates.AutoSize = true;
            lblStatusDates.Dock = DockStyle.Fill;
            lblStatusDates.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusDates.Location = new Point(3, 192);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(238, 66);
            lblStatusDates.TabIndex = 10;
            lblStatusDates.Text = "Status Dates";
            lblStatusDates.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbMain
            // 
            tblMain.SetColumnSpan(tbMain, 2);
            tbMain.Controls.Add(tbIngredients);
            tbMain.Controls.Add(tbSteps);
            tbMain.Dock = DockStyle.Fill;
            tbMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbMain.Location = new Point(3, 261);
            tbMain.Name = "tbMain";
            tbMain.SelectedIndex = 0;
            tbMain.Size = new Size(877, 313);
            tbMain.TabIndex = 12;
            // 
            // tbIngredients
            // 
            tbIngredients.BackColor = Color.AliceBlue;
            tbIngredients.Controls.Add(tblIngredients);
            tbIngredients.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbIngredients.Location = new Point(4, 37);
            tbIngredients.Name = "tbIngredients";
            tbIngredients.Padding = new Padding(3);
            tbIngredients.Size = new Size(869, 272);
            tbIngredients.TabIndex = 0;
            tbIngredients.Text = "Ingredients";
            // 
            // tblIngredients
            // 
            tblIngredients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblIngredients.AutoScroll = true;
            tblIngredients.ColumnCount = 1;
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblIngredients.Controls.Add(btnSaveIngredient, 0, 0);
            tblIngredients.Controls.Add(gIngredients, 0, 1);
            tblIngredients.Location = new Point(3, 3);
            tblIngredients.Name = "tblIngredients";
            tblIngredients.RowCount = 2;
            tblIngredients.RowStyles.Add(new RowStyle());
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblIngredients.Size = new Size(863, 266);
            tblIngredients.TabIndex = 0;
            // 
            // btnSaveIngredient
            // 
            btnSaveIngredient.AutoSize = true;
            btnSaveIngredient.BackColor = Color.LightSteelBlue;
            btnSaveIngredient.Location = new Point(3, 3);
            btnSaveIngredient.Name = "btnSaveIngredient";
            btnSaveIngredient.Size = new Size(94, 38);
            btnSaveIngredient.TabIndex = 0;
            btnSaveIngredient.Text = "Save";
            btnSaveIngredient.UseVisualStyleBackColor = false;
            // 
            // gIngredients
            // 
            gIngredients.BackgroundColor = Color.AliceBlue;
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(3, 47);
            gIngredients.Name = "gIngredients";
            gIngredients.RowHeadersWidth = 51;
            gIngredients.Size = new Size(857, 216);
            gIngredients.TabIndex = 1;
            // 
            // tbSteps
            // 
            tbSteps.BackColor = Color.AliceBlue;
            tbSteps.Controls.Add(tblSteps);
            tbSteps.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSteps.Location = new Point(4, 37);
            tbSteps.Name = "tbSteps";
            tbSteps.Padding = new Padding(3);
            tbSteps.Size = new Size(869, 272);
            tbSteps.TabIndex = 1;
            tbSteps.Text = "Steps";
            // 
            // tblSteps
            // 
            tblSteps.ColumnCount = 1;
            tblSteps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSteps.Controls.Add(btnSaveSteps, 0, 0);
            tblSteps.Controls.Add(gSteps, 0, 1);
            tblSteps.Dock = DockStyle.Fill;
            tblSteps.Location = new Point(3, 3);
            tblSteps.Name = "tblSteps";
            tblSteps.RowCount = 2;
            tblSteps.RowStyles.Add(new RowStyle());
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblSteps.Size = new Size(863, 266);
            tblSteps.TabIndex = 0;
            // 
            // btnSaveSteps
            // 
            btnSaveSteps.AutoSize = true;
            btnSaveSteps.BackColor = Color.LightSteelBlue;
            btnSaveSteps.Location = new Point(3, 3);
            btnSaveSteps.Name = "btnSaveSteps";
            btnSaveSteps.Size = new Size(94, 38);
            btnSaveSteps.TabIndex = 0;
            btnSaveSteps.Text = "Save";
            btnSaveSteps.UseVisualStyleBackColor = false;
            // 
            // gSteps
            // 
            gSteps.BackgroundColor = Color.AliceBlue;
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(3, 47);
            gSteps.Name = "gSteps";
            gSteps.RowHeadersWidth = 51;
            gSteps.Size = new Size(857, 216);
            gSteps.TabIndex = 1;
            // 
            // tsMain
            // 
            tsMain.BackColor = Color.LightSteelBlue;
            tsMain.Dock = DockStyle.Fill;
            tsMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete, toolStripSeparator2, btnChangeStatus, toolStripSeparator4 });
            tsMain.Location = new Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(889, 35);
            tsMain.TabIndex = 0;
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
            // btnChangeStatus
            // 
            btnChangeStatus.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnChangeStatus.Image = (Image)resources.GetObject("btnChangeStatus.Image");
            btnChangeStatus.ImageTransparentColor = Color.Magenta;
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(140, 32);
            btnChangeStatus.Text = "Change Status";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 35);
            // 
            // tblBackground
            // 
            tblBackground.AutoScroll = true;
            tblBackground.ColumnCount = 1;
            tblBackground.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblBackground.Controls.Add(tblMain, 0, 1);
            tblBackground.Controls.Add(tsMain, 0, 0);
            tblBackground.Dock = DockStyle.Fill;
            tblBackground.Location = new Point(0, 0);
            tblBackground.Name = "tblBackground";
            tblBackground.RowCount = 2;
            tblBackground.RowStyles.Add(new RowStyle());
            tblBackground.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBackground.Size = new Size(889, 618);
            tblBackground.TabIndex = 2;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 618);
            Controls.Add(tblBackground);
            Name = "frmRecipe";
            Text = "Recipe ";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblStatusDates.ResumeLayout(false);
            tblStatusDates.PerformLayout();
            tbMain.ResumeLayout(false);
            tbIngredients.ResumeLayout(false);
            tblIngredients.ResumeLayout(false);
            tblIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).EndInit();
            tbSteps.ResumeLayout(false);
            tblSteps.ResumeLayout(false);
            tblSteps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).EndInit();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            tblBackground.ResumeLayout(false);
            tblBackground.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionRecipeName;
        private Label lblCaptionCuisineName;
        private Label lblCaptionUserName;
        private Label lblCaptionCalories;
        private Label lblCurrentStatus;
        private ToolStrip tsMain;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private ToolStripButton btnChangeStatus;
        private ToolStripSeparator toolStripSeparator4;
        private TableLayoutPanel tblBackground;
        private TextBox txtCalories;
        private TextBox txtRecipeName;
        private ComboBox lstUserName;
        private ComboBox lstCuisineName;
        private Label lblRecipeStatus;
        private TableLayoutPanel tblStatusDates;
        private Label lblDateDrafted;
        private Label lblDatePublished;
        private Label lblArchived;
        private TextBox txtDateCreated;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private Label lblStatusDates;
        private TabControl tbMain;
        private TabPage tbIngredients;
        private TableLayoutPanel tblIngredients;
        private Button btnSaveIngredient;
        private DataGridView gIngredients;
        private TabPage tbSteps;
        private TableLayoutPanel tblSteps;
        private Button btnSaveSteps;
        private DataGridView gSteps;
    }
}