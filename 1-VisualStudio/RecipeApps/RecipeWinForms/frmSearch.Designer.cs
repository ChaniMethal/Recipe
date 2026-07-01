namespace RecipeWinForm
{
    partial class frmSearch
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
            tblOptions = new TableLayoutPanel();
            lblName = new Label();
            txtRecipeName = new TextBox();
            btnSearch = new Button();
            btnNew = new Button();
            gRecipe = new DataGridView();
            tblMain.SuspendLayout();
            tblOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(tblOptions, 0, 0);
            tblMain.Controls.Add(gRecipe, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // tblOptions
            // 
            tblOptions.AutoSize = true;
            tblOptions.BackColor = Color.LightSteelBlue;
            tblOptions.ColumnCount = 4;
            tblOptions.ColumnStyles.Add(new ColumnStyle());
            tblOptions.ColumnStyles.Add(new ColumnStyle());
            tblOptions.ColumnStyles.Add(new ColumnStyle());
            tblOptions.ColumnStyles.Add(new ColumnStyle());
            tblOptions.Controls.Add(lblName, 0, 0);
            tblOptions.Controls.Add(txtRecipeName, 1, 0);
            tblOptions.Controls.Add(btnSearch, 2, 0);
            tblOptions.Controls.Add(btnNew, 3, 0);
            tblOptions.Dock = DockStyle.Fill;
            tblOptions.Location = new Point(3, 3);
            tblOptions.Name = "tblOptions";
            tblOptions.RowCount = 1;
            tblOptions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblOptions.Size = new Size(794, 44);
            tblOptions.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Left;
            lblName.AutoSize = true;
            lblName.BackColor = Color.SteelBlue;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(3, 8);
            lblName.Name = "lblName";
            lblName.Size = new Size(121, 28);
            lblName.TabIndex = 0;
            lblName.Text = "RecipeName";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Anchor = AnchorStyles.Left;
            txtRecipeName.BackColor = Color.SteelBlue;
            txtRecipeName.BorderStyle = BorderStyle.None;
            txtRecipeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRecipeName.ForeColor = Color.SteelBlue;
            txtRecipeName.Location = new Point(130, 7);
            txtRecipeName.Multiline = true;
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(125, 30);
            txtRecipeName.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Left;
            btnSearch.AutoSize = true;
            btnSearch.BackColor = Color.SteelBlue;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(261, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(141, 38);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Left;
            btnNew.AutoSize = true;
            btnNew.BackColor = Color.SteelBlue;
            btnNew.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.ForeColor = Color.Black;
            btnNew.Location = new Point(408, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(137, 38);
            btnNew.TabIndex = 3;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // gRecipe
            // 
            gRecipe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gRecipe.BackgroundColor = Color.AliceBlue;
            gRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipe.Dock = DockStyle.Fill;
            gRecipe.Location = new Point(3, 53);
            gRecipe.Name = "gRecipe";
            gRecipe.RowHeadersWidth = 51;
            gRecipe.Size = new Size(794, 394);
            gRecipe.TabIndex = 2;
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmSearch";
            Text = "RecipeApp";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblOptions.ResumeLayout(false);
            tblOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblOptions;
        private Label lblName;
        private TextBox txtRecipeName;
        private Button btnSearch;
        private DataGridView gRecipe;
        private Button btnNew;
    }
}