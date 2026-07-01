namespace RecipeWinForm
{
    partial class frmDataMaintenance
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
            gDataMaintenance = new DataGridView();
            btnSaveDataMaintenance = new Button();
            tblButtons = new TableLayoutPanel();
            rdoUsers = new RadioButton();
            rdoCuisines = new RadioButton();
            rdoMeasurements = new RadioButton();
            rdoIngredients = new RadioButton();
            rdoCourses = new RadioButton();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gDataMaintenance).BeginInit();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.09091F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.90909F));
            tblMain.Controls.Add(gDataMaintenance, 1, 0);
            tblMain.Controls.Add(btnSaveDataMaintenance, 1, 1);
            tblMain.Controls.Add(tblButtons, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(906, 484);
            tblMain.TabIndex = 0;
            // 
            // gDataMaintenance
            // 
            gDataMaintenance.BackgroundColor = Color.AliceBlue;
            gDataMaintenance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gDataMaintenance.Dock = DockStyle.Fill;
            gDataMaintenance.Location = new Point(175, 3);
            gDataMaintenance.Name = "gDataMaintenance";
            gDataMaintenance.RowHeadersWidth = 51;
            gDataMaintenance.Size = new Size(728, 434);
            gDataMaintenance.TabIndex = 1;
            // 
            // btnSaveDataMaintenance
            // 
            btnSaveDataMaintenance.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveDataMaintenance.AutoSize = true;
            btnSaveDataMaintenance.BackColor = Color.LightSteelBlue;
            btnSaveDataMaintenance.Location = new Point(809, 443);
            btnSaveDataMaintenance.Name = "btnSaveDataMaintenance";
            btnSaveDataMaintenance.Size = new Size(94, 38);
            btnSaveDataMaintenance.TabIndex = 2;
            btnSaveDataMaintenance.Text = "Save";
            btnSaveDataMaintenance.UseVisualStyleBackColor = false;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 1;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblButtons.Controls.Add(rdoUsers, 0, 0);
            tblButtons.Controls.Add(rdoCuisines, 0, 1);
            tblButtons.Controls.Add(rdoMeasurements, 0, 3);
            tblButtons.Controls.Add(rdoIngredients, 0, 2);
            tblButtons.Controls.Add(rdoCourses, 0, 4);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 3);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 5;
            tblButtons.RowStyles.Add(new RowStyle());
            tblButtons.RowStyles.Add(new RowStyle());
            tblButtons.RowStyles.Add(new RowStyle());
            tblButtons.RowStyles.Add(new RowStyle());
            tblButtons.RowStyles.Add(new RowStyle());
            tblButtons.Size = new Size(166, 434);
            tblButtons.TabIndex = 3;
            // 
            // rdoUsers
            // 
            rdoUsers.AutoSize = true;
            rdoUsers.Location = new Point(3, 3);
            rdoUsers.Name = "rdoUsers";
            rdoUsers.Size = new Size(80, 32);
            rdoUsers.TabIndex = 0;
            rdoUsers.TabStop = true;
            rdoUsers.Text = "Users";
            rdoUsers.UseVisualStyleBackColor = true;
            // 
            // rdoCuisines
            // 
            rdoCuisines.AutoSize = true;
            rdoCuisines.Location = new Point(3, 41);
            rdoCuisines.Name = "rdoCuisines";
            rdoCuisines.Size = new Size(103, 32);
            rdoCuisines.TabIndex = 1;
            rdoCuisines.TabStop = true;
            rdoCuisines.Text = "Cuisines";
            rdoCuisines.UseVisualStyleBackColor = true;
            // 
            // rdoMeasurements
            // 
            rdoMeasurements.AutoSize = true;
            rdoMeasurements.Location = new Point(3, 117);
            rdoMeasurements.Name = "rdoMeasurements";
            rdoMeasurements.Size = new Size(160, 32);
            rdoMeasurements.TabIndex = 3;
            rdoMeasurements.TabStop = true;
            rdoMeasurements.Text = "Measurements";
            rdoMeasurements.UseVisualStyleBackColor = true;
            // 
            // rdoIngredients
            // 
            rdoIngredients.AutoSize = true;
            rdoIngredients.Location = new Point(3, 79);
            rdoIngredients.Name = "rdoIngredients";
            rdoIngredients.Size = new Size(131, 32);
            rdoIngredients.TabIndex = 2;
            rdoIngredients.TabStop = true;
            rdoIngredients.Text = "Ingredients";
            rdoIngredients.UseVisualStyleBackColor = true;
            // 
            // rdoCourses
            // 
            rdoCourses.AutoSize = true;
            rdoCourses.Location = new Point(3, 155);
            rdoCourses.Name = "rdoCourses";
            rdoCourses.Size = new Size(101, 32);
            rdoCourses.TabIndex = 4;
            rdoCourses.TabStop = true;
            rdoCourses.Text = "Courses";
            rdoCourses.UseVisualStyleBackColor = true;
            // 
            // frmDataMaintenance
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(906, 484);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmDataMaintenance";
            Text = "Hearty Hearth- Data Maintenance";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gDataMaintenance).EndInit();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private DataGridView gDataMaintenance;
        private Button btnSaveDataMaintenance;
        private TableLayoutPanel tblButtons;
        private RadioButton rdoUsers;
        private RadioButton rdoCuisines;
        private RadioButton rdoMeasurements;
        private RadioButton rdoIngredients;
        private RadioButton rdoCourses;
    }
}