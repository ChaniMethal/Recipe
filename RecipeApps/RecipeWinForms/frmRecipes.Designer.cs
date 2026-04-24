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
            lblRecipeName = new Label();
            lblCuisineName = new Label();
            txtUserFirstName = new TextBox();
            txtUserLastName = new TextBox();
            txtCalories = new TextBox();
            txtDateCreated = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            txtRecipeStatus = new TextBox();
            tblMain.SuspendLayout();
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
            tblMain.Controls.Add(lblRecipeName, 1, 0);
            tblMain.Controls.Add(lblCuisineName, 1, 1);
            tblMain.Controls.Add(txtUserFirstName, 1, 2);
            tblMain.Controls.Add(txtUserLastName, 1, 3);
            tblMain.Controls.Add(txtCalories, 1, 4);
            tblMain.Controls.Add(txtDateCreated, 1, 5);
            tblMain.Controls.Add(txtDatePublished, 1, 6);
            tblMain.Controls.Add(txtDateArchived, 1, 7);
            tblMain.Controls.Add(txtRecipeStatus, 1, 8);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
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
            tblMain.Size = new Size(549, 653);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Left;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.BackColor = Color.Azure;
            lblCaptionRecipeName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCaptionRecipeName.ForeColor = Color.CadetBlue;
            lblCaptionRecipeName.Location = new Point(3, 22);
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
            lblCaptionCuisineName.Location = new Point(3, 94);
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
            lblCaptionUserFirstName.Location = new Point(3, 166);
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
            lblCaptionUserLastName.Location = new Point(3, 238);
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
            lblCaptionCalories.Location = new Point(3, 310);
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
            lblCaptionDateCreated.Location = new Point(3, 382);
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
            lblCaptionDatePublished.Location = new Point(3, 454);
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
            lblCaptionDateArchived.Location = new Point(3, 526);
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
            lblCaptionRecipeStatus.Location = new Point(3, 600);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(140, 28);
            lblCaptionRecipeStatus.TabIndex = 8;
            lblCaptionRecipeStatus.Text = "Recipe Status";
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.BackColor = Color.LightCyan;
            lblRecipeName.BorderStyle = BorderStyle.FixedSingle;
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Font = new Font("Segoe UI", 12F);
            lblRecipeName.ForeColor = Color.LightSeaGreen;
            lblRecipeName.Location = new Point(202, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(344, 72);
            lblRecipeName.TabIndex = 9;
            // 
            // lblCuisineName
            // 
            lblCuisineName.AutoSize = true;
            lblCuisineName.BackColor = Color.LightCyan;
            lblCuisineName.BorderStyle = BorderStyle.FixedSingle;
            lblCuisineName.Dock = DockStyle.Fill;
            lblCuisineName.Font = new Font("Segoe UI", 12F);
            lblCuisineName.ForeColor = Color.LightSeaGreen;
            lblCuisineName.Location = new Point(202, 72);
            lblCuisineName.Name = "lblCuisineName";
            lblCuisineName.Size = new Size(344, 72);
            lblCuisineName.TabIndex = 10;
            // 
            // txtUserFirstName
            // 
            txtUserFirstName.BackColor = Color.LightCyan;
            txtUserFirstName.Dock = DockStyle.Fill;
            txtUserFirstName.Enabled = false;
            txtUserFirstName.Font = new Font("Segoe UI", 12F);
            txtUserFirstName.ForeColor = Color.LightSeaGreen;
            txtUserFirstName.Location = new Point(202, 147);
            txtUserFirstName.Name = "txtUserFirstName";
            txtUserFirstName.ReadOnly = true;
            txtUserFirstName.Size = new Size(344, 34);
            txtUserFirstName.TabIndex = 11;
            // 
            // txtUserLastName
            // 
            txtUserLastName.BackColor = Color.LightCyan;
            txtUserLastName.Dock = DockStyle.Fill;
            txtUserLastName.Enabled = false;
            txtUserLastName.Font = new Font("Segoe UI", 12F);
            txtUserLastName.ForeColor = Color.LightSeaGreen;
            txtUserLastName.Location = new Point(202, 219);
            txtUserLastName.Name = "txtUserLastName";
            txtUserLastName.ReadOnly = true;
            txtUserLastName.Size = new Size(344, 34);
            txtUserLastName.TabIndex = 12;
            // 
            // txtCalories
            // 
            txtCalories.BackColor = Color.LightCyan;
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Enabled = false;
            txtCalories.Font = new Font("Segoe UI", 12F);
            txtCalories.ForeColor = Color.LightSeaGreen;
            txtCalories.Location = new Point(202, 291);
            txtCalories.Name = "txtCalories";
            txtCalories.ReadOnly = true;
            txtCalories.Size = new Size(344, 34);
            txtCalories.TabIndex = 13;
            // 
            // txtDateCreated
            // 
            txtDateCreated.BackColor = Color.LightCyan;
            txtDateCreated.Dock = DockStyle.Fill;
            txtDateCreated.Enabled = false;
            txtDateCreated.Font = new Font("Segoe UI", 12F);
            txtDateCreated.ForeColor = Color.LightSeaGreen;
            txtDateCreated.Location = new Point(202, 363);
            txtDateCreated.Name = "txtDateCreated";
            txtDateCreated.ReadOnly = true;
            txtDateCreated.Size = new Size(344, 34);
            txtDateCreated.TabIndex = 14;
            // 
            // txtDatePublished
            // 
            txtDatePublished.BackColor = Color.LightCyan;
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Enabled = false;
            txtDatePublished.Font = new Font("Segoe UI", 12F);
            txtDatePublished.ForeColor = Color.LightSeaGreen;
            txtDatePublished.Location = new Point(202, 435);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(344, 34);
            txtDatePublished.TabIndex = 15;
            // 
            // txtDateArchived
            // 
            txtDateArchived.BackColor = Color.LightCyan;
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Enabled = false;
            txtDateArchived.Font = new Font("Segoe UI", 12F);
            txtDateArchived.ForeColor = Color.LightSeaGreen;
            txtDateArchived.Location = new Point(202, 507);
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
            txtRecipeStatus.Location = new Point(202, 579);
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.ReadOnly = true;
            txtRecipeStatus.Size = new Size(344, 34);
            txtRecipeStatus.TabIndex = 17;
            // 
            // frmRecipes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 653);
            Controls.Add(tblMain);
            Name = "frmRecipes";
            Text = "frmRecipes";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
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
        private Label lblRecipeName;
        private Label lblCuisineName;
        private TextBox txtUserFirstName;
        private TextBox txtUserLastName;
        private TextBox txtCalories;
        private TextBox txtDateCreated;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TextBox txtRecipeStatus;
    }
}