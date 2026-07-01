namespace RecipeWinForm
{
    partial class frmDashboard
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            mnuMain = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileDashboard = new ToolStripMenuItem();
            mnuRecipe = new ToolStripMenuItem();
            mnuRecipeList = new ToolStripMenuItem();
            mnuNewRecipe = new ToolStripMenuItem();
            mnuCloneARecipe = new ToolStripMenuItem();
            mnuMeals = new ToolStripMenuItem();
            mnuMealList = new ToolStripMenuItem();
            mnuCookbooks = new ToolStripMenuItem();
            mnuCookbookList = new ToolStripMenuItem();
            mnuNewCookbook = new ToolStripMenuItem();
            mnuCookbookAutoCreate = new ToolStripMenuItem();
            mnuDataMaintenance = new ToolStripMenuItem();
            mnuEditData = new ToolStripMenuItem();
            mnuWindows = new ToolStripMenuItem();
            mnuWindowTile = new ToolStripMenuItem();
            mnuWindowCascade = new ToolStripMenuItem();
            tblMain = new TableLayoutPanel();
            lblHeader = new Label();
            lblSubHeader = new Label();
            lblType = new Label();
            lblNumber = new Label();
            lblRecipes = new Label();
            lblMeals = new Label();
            lblCookbooks = new Label();
            txtRecipes = new TextBox();
            txtMeals = new TextBox();
            txtCookBook = new TextBox();
            tblButtons = new TableLayoutPanel();
            btnRecipeList = new Button();
            btnMealList = new Button();
            btnCookbookList = new Button();
            tsMain = new ToolStrip();
            mnuMain.SuspendLayout();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // mnuMain
            // 
            mnuMain.BackColor = SystemColors.ActiveCaption;
            mnuMain.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuMain.ImageScalingSize = new Size(20, 20);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuRecipe, mnuMeals, mnuCookbooks, mnuDataMaintenance, mnuWindows });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(1119, 36);
            mnuMain.TabIndex = 0;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileDashboard });
            mnuFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(59, 32);
            mnuFile.Text = "File";
            // 
            // mnuFileDashboard
            // 
            mnuFileDashboard.Name = "mnuFileDashboard";
            mnuFileDashboard.Size = new Size(200, 32);
            mnuFileDashboard.Text = "Dashboard";
            // 
            // mnuRecipe
            // 
            mnuRecipe.DropDownItems.AddRange(new ToolStripItem[] { mnuRecipeList, mnuNewRecipe, mnuCloneARecipe });
            mnuRecipe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            mnuRecipe.Name = "mnuRecipe";
            mnuRecipe.Size = new Size(98, 32);
            mnuRecipe.Text = "Recipes";
            // 
            // mnuRecipeList
            // 
            mnuRecipeList.Name = "mnuRecipeList";
            mnuRecipeList.Size = new Size(237, 32);
            mnuRecipeList.Text = "List";
            // 
            // mnuNewRecipe
            // 
            mnuNewRecipe.Name = "mnuNewRecipe";
            mnuNewRecipe.Size = new Size(237, 32);
            mnuNewRecipe.Text = "New Recipe";
            // 
            // mnuCloneARecipe
            // 
            mnuCloneARecipe.Name = "mnuCloneARecipe";
            mnuCloneARecipe.Size = new Size(237, 32);
            mnuCloneARecipe.Text = "Clone a Recipe";
            // 
            // mnuMeals
            // 
            mnuMeals.DropDownItems.AddRange(new ToolStripItem[] { mnuMealList });
            mnuMeals.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            mnuMeals.Name = "mnuMeals";
            mnuMeals.Size = new Size(82, 32);
            mnuMeals.Text = "Meals";
            // 
            // mnuMealList
            // 
            mnuMealList.Name = "mnuMealList";
            mnuMealList.Size = new Size(131, 32);
            mnuMealList.Text = "List";
            // 
            // mnuCookbooks
            // 
            mnuCookbooks.DropDownItems.AddRange(new ToolStripItem[] { mnuCookbookList, mnuNewCookbook, mnuCookbookAutoCreate });
            mnuCookbooks.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            mnuCookbooks.Name = "mnuCookbooks";
            mnuCookbooks.Size = new Size(129, 32);
            mnuCookbooks.Text = "Cookbooks";
            // 
            // mnuCookbookList
            // 
            mnuCookbookList.Name = "mnuCookbookList";
            mnuCookbookList.Size = new Size(241, 32);
            mnuCookbookList.Text = "List";
            // 
            // mnuNewCookbook
            // 
            mnuNewCookbook.Name = "mnuNewCookbook";
            mnuNewCookbook.Size = new Size(241, 32);
            mnuNewCookbook.Text = "New Cookbook";
            // 
            // mnuCookbookAutoCreate
            // 
            mnuCookbookAutoCreate.Name = "mnuCookbookAutoCreate";
            mnuCookbookAutoCreate.Size = new Size(241, 32);
            mnuCookbookAutoCreate.Text = "Auto-Create";
            // 
            // mnuDataMaintenance
            // 
            mnuDataMaintenance.DropDownItems.AddRange(new ToolStripItem[] { mnuEditData });
            mnuDataMaintenance.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            mnuDataMaintenance.Name = "mnuDataMaintenance";
            mnuDataMaintenance.Size = new Size(200, 32);
            mnuDataMaintenance.Text = "Data Maintenance";
            // 
            // mnuEditData
            // 
            mnuEditData.Name = "mnuEditData";
            mnuEditData.Size = new Size(186, 32);
            mnuEditData.Text = "Edit Data";
            // 
            // mnuWindows
            // 
            mnuWindows.DropDownItems.AddRange(new ToolStripItem[] { mnuWindowTile, mnuWindowCascade });
            mnuWindows.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            mnuWindows.Name = "mnuWindows";
            mnuWindows.Size = new Size(113, 32);
            mnuWindows.Text = "Windows";
            // 
            // mnuWindowTile
            // 
            mnuWindowTile.Name = "mnuWindowTile";
            mnuWindowTile.Size = new Size(174, 32);
            mnuWindowTile.Text = "Tile";
            // 
            // mnuWindowCascade
            // 
            mnuWindowCascade.Name = "mnuWindowCascade";
            mnuWindowCascade.Size = new Size(174, 32);
            mnuWindowCascade.Text = "Cascade";
            // 
            // tblMain
            // 
            tblMain.BackColor = Color.AliceBlue;
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(lblHeader, 0, 0);
            tblMain.Controls.Add(lblSubHeader, 0, 1);
            tblMain.Controls.Add(lblType, 0, 2);
            tblMain.Controls.Add(lblNumber, 1, 2);
            tblMain.Controls.Add(lblRecipes, 0, 3);
            tblMain.Controls.Add(lblMeals, 0, 4);
            tblMain.Controls.Add(lblCookbooks, 0, 5);
            tblMain.Controls.Add(txtRecipes, 1, 3);
            tblMain.Controls.Add(txtMeals, 1, 4);
            tblMain.Controls.Add(txtCookBook, 1, 5);
            tblMain.Controls.Add(tblButtons, 0, 6);
            tblMain.Dock = DockStyle.Bottom;
            tblMain.Location = new Point(0, 55);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 7;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(1119, 572);
            tblMain.TabIndex = 1;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            tblMain.SetColumnSpan(lblHeader, 2);
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.FlatStyle = FlatStyle.Flat;
            lblHeader.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.DarkBlue;
            lblHeader.Location = new Point(3, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(1113, 81);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Hearty Hearth Desktop App";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubHeader
            // 
            lblSubHeader.AutoSize = true;
            tblMain.SetColumnSpan(lblSubHeader, 2);
            lblSubHeader.Dock = DockStyle.Fill;
            lblSubHeader.FlatStyle = FlatStyle.Flat;
            lblSubHeader.ForeColor = Color.DarkBlue;
            lblSubHeader.Location = new Point(3, 81);
            lblSubHeader.Name = "lblSubHeader";
            lblSubHeader.Size = new Size(1113, 81);
            lblSubHeader.TabIndex = 1;
            lblSubHeader.Text = "Welcome to Hearty Hearth desktop app. In this app you can create recipes and cookbooks. You can also view lists of our current recipes, meals, and cookbooks. Happy cooking!";
            lblSubHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.BackColor = Color.LightSteelBlue;
            lblType.Dock = DockStyle.Fill;
            lblType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblType.Location = new Point(3, 162);
            lblType.Name = "lblType";
            lblType.Size = new Size(553, 81);
            lblType.TabIndex = 2;
            lblType.Text = "Type";
            lblType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.BackColor = Color.LightSteelBlue;
            lblNumber.Dock = DockStyle.Fill;
            lblNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumber.Location = new Point(562, 162);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(554, 81);
            lblNumber.TabIndex = 3;
            lblNumber.Text = "Number";
            lblNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecipes
            // 
            lblRecipes.AutoSize = true;
            lblRecipes.Dock = DockStyle.Fill;
            lblRecipes.Location = new Point(3, 243);
            lblRecipes.Name = "lblRecipes";
            lblRecipes.Size = new Size(553, 81);
            lblRecipes.TabIndex = 4;
            lblRecipes.Text = "Recipes";
            lblRecipes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMeals
            // 
            lblMeals.AutoSize = true;
            lblMeals.Dock = DockStyle.Fill;
            lblMeals.Location = new Point(3, 324);
            lblMeals.Name = "lblMeals";
            lblMeals.Size = new Size(553, 81);
            lblMeals.TabIndex = 6;
            lblMeals.Text = "Meals";
            lblMeals.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCookbooks
            // 
            lblCookbooks.AutoSize = true;
            lblCookbooks.Dock = DockStyle.Fill;
            lblCookbooks.Location = new Point(3, 405);
            lblCookbooks.Name = "lblCookbooks";
            lblCookbooks.Size = new Size(553, 81);
            lblCookbooks.TabIndex = 8;
            lblCookbooks.Text = "Cookbooks";
            lblCookbooks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRecipes
            // 
            txtRecipes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRecipes.BackColor = Color.AliceBlue;
            txtRecipes.BorderStyle = BorderStyle.None;
            txtRecipes.Enabled = false;
            txtRecipes.Location = new Point(562, 270);
            txtRecipes.Name = "txtRecipes";
            txtRecipes.Size = new Size(554, 27);
            txtRecipes.TabIndex = 5;
            txtRecipes.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMeals
            // 
            txtMeals.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMeals.BackColor = Color.AliceBlue;
            txtMeals.BorderStyle = BorderStyle.None;
            txtMeals.Enabled = false;
            txtMeals.Location = new Point(562, 351);
            txtMeals.Name = "txtMeals";
            txtMeals.Size = new Size(554, 27);
            txtMeals.TabIndex = 7;
            txtMeals.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCookBook
            // 
            txtCookBook.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCookBook.BackColor = Color.AliceBlue;
            txtCookBook.BorderStyle = BorderStyle.None;
            txtCookBook.Enabled = false;
            txtCookBook.Location = new Point(562, 432);
            txtCookBook.Name = "txtCookBook";
            txtCookBook.Size = new Size(554, 27);
            txtCookBook.TabIndex = 9;
            txtCookBook.TextAlign = HorizontalAlignment.Center;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 3;
            tblMain.SetColumnSpan(tblButtons, 2);
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.Controls.Add(btnRecipeList, 0, 0);
            tblButtons.Controls.Add(btnMealList, 1, 0);
            tblButtons.Controls.Add(btnCookbookList, 2, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 489);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.Size = new Size(1113, 80);
            tblButtons.TabIndex = 10;
            // 
            // btnRecipeList
            // 
            btnRecipeList.BackColor = Color.LightSteelBlue;
            btnRecipeList.Dock = DockStyle.Fill;
            btnRecipeList.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRecipeList.Location = new Point(3, 3);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(365, 74);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = false;
            // 
            // btnMealList
            // 
            btnMealList.BackColor = Color.LightSteelBlue;
            btnMealList.Dock = DockStyle.Fill;
            btnMealList.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMealList.Location = new Point(374, 3);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(365, 74);
            btnMealList.TabIndex = 1;
            btnMealList.Text = "Meal List";
            btnMealList.UseVisualStyleBackColor = false;
            // 
            // btnCookbookList
            // 
            btnCookbookList.BackColor = Color.LightSteelBlue;
            btnCookbookList.Dock = DockStyle.Fill;
            btnCookbookList.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCookbookList.Location = new Point(745, 3);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(365, 74);
            btnCookbookList.TabIndex = 2;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = false;
            // 
            // tsMain
            // 
            tsMain.BackColor = Color.AliceBlue;
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Location = new Point(0, 36);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(1119, 25);
            tsMain.TabIndex = 3;
            tsMain.Text = "toolStrip1";
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 627);
            Controls.Add(tsMain);
            Controls.Add(tblMain);
            Controls.Add(mnuMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = mnuMain;
            Margin = new Padding(4);
            Name = "frmDashboard";
            Text = "Hearty Hearth - Dashboard";
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileDashboard;
        private ToolStripMenuItem mnuRecipe;
        private ToolStripMenuItem mnuRecipeList;
        private ToolStripMenuItem mnuNewRecipe;
        private ToolStripMenuItem mnuCloneARecipe;
        private ToolStripMenuItem mnuMeals;
        private ToolStripMenuItem mnuMealList;
        private ToolStripMenuItem mnuCookbooks;
        private ToolStripMenuItem mnuCookbookList;
        private ToolStripMenuItem mnuNewCookbook;
        private ToolStripMenuItem mnuCookbookAutoCreate;
        private ToolStripMenuItem mnuDataMaintenance;
        private ToolStripMenuItem mnuEditData;
        private ToolStripMenuItem mnuWindows;
        private TableLayoutPanel tblMain;
        private Label lblHeader;
        private Label lblSubHeader;
        private Label lblType;
        private Label lblNumber;
        private Label lblRecipes;
        private Label lblMeals;
        private Label lblCookbooks;
        private TextBox txtRecipes;
        private TextBox txtMeals;
        private TextBox txtCookBook;
        private TableLayoutPanel tblButtons;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
        private ToolStripMenuItem mnuWindowTile;
        private ToolStripMenuItem mnuWindowCascade;
        private ToolStrip tsMain;
    }
}