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
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
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
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
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
            tblMain.Size = new Size(1119, 627);
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
            lblHeader.Size = new Size(1113, 89);
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
            lblSubHeader.Location = new Point(3, 89);
            lblSubHeader.Name = "lblSubHeader";
            lblSubHeader.Size = new Size(1113, 89);
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
            lblType.Location = new Point(3, 178);
            lblType.Name = "lblType";
            lblType.Size = new Size(553, 89);
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
            lblNumber.Location = new Point(562, 178);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(554, 89);
            lblNumber.TabIndex = 3;
            lblNumber.Text = "Number";
            lblNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecipes
            // 
            lblRecipes.AutoSize = true;
            lblRecipes.Dock = DockStyle.Fill;
            lblRecipes.Location = new Point(3, 267);
            lblRecipes.Name = "lblRecipes";
            lblRecipes.Size = new Size(553, 89);
            lblRecipes.TabIndex = 4;
            lblRecipes.Text = "Recipes";
            lblRecipes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMeals
            // 
            lblMeals.AutoSize = true;
            lblMeals.Dock = DockStyle.Fill;
            lblMeals.Location = new Point(3, 356);
            lblMeals.Name = "lblMeals";
            lblMeals.Size = new Size(553, 89);
            lblMeals.TabIndex = 6;
            lblMeals.Text = "Meals";
            lblMeals.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCookbooks
            // 
            lblCookbooks.AutoSize = true;
            lblCookbooks.Dock = DockStyle.Fill;
            lblCookbooks.Location = new Point(3, 445);
            lblCookbooks.Name = "lblCookbooks";
            lblCookbooks.Size = new Size(553, 89);
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
            txtRecipes.Location = new Point(562, 298);
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
            txtMeals.Location = new Point(562, 387);
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
            txtCookBook.Location = new Point(562, 476);
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
            tblButtons.Location = new Point(3, 537);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.Size = new Size(1113, 87);
            tblButtons.TabIndex = 10;
            // 
            // btnRecipeList
            // 
            btnRecipeList.BackColor = Color.LightSteelBlue;
            btnRecipeList.Dock = DockStyle.Fill;
            btnRecipeList.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRecipeList.Location = new Point(3, 3);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(365, 81);
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
            btnMealList.Size = new Size(365, 81);
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
            btnCookbookList.Size = new Size(365, 81);
            btnCookbookList.TabIndex = 2;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = false;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 627);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmDashboard";
            Text = "Hearty Hearth - Dashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TableLayoutPanel tblMain;
        private Label lblNumber;
        private TextBox txtRecipes;
        private TextBox txtMeals;
        private TextBox txtCookBook;
        private Label lblHeader;
        private Label lblSubHeader;
        private Label lblType;
        private Label lblRecipes;
        private Label lblMeals;
        private Label lblCookbooks;
        private TableLayoutPanel tblButtons;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
    }
}