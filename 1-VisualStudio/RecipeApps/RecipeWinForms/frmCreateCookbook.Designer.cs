namespace RecipeWinForm
{
    partial class frmCreateCookbook
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
            lstUserName = new ComboBox();
            btnCreateCookbook = new Button();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(lstUserName, 0, 0);
            tblMain.Controls.Add(btnCreateCookbook, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(787, 325);
            tblMain.TabIndex = 0;
            // 
            // lstUserName
            // 
            lstUserName.BackColor = Color.AliceBlue;
            lstUserName.Dock = DockStyle.Fill;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(3, 3);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(387, 36);
            lstUserName.TabIndex = 0;
            // 
            // btnCreateCookbook
            // 
            btnCreateCookbook.AutoSize = true;
            btnCreateCookbook.BackColor = Color.LightSteelBlue;
            btnCreateCookbook.Dock = DockStyle.Bottom;
            btnCreateCookbook.Location = new Point(443, 30);
            btnCreateCookbook.Margin = new Padding(50, 30, 50, 30);
            btnCreateCookbook.Name = "btnCreateCookbook";
            btnCreateCookbook.Size = new Size(294, 265);
            btnCreateCookbook.TabIndex = 1;
            btnCreateCookbook.Text = "Create Cookbook";
            btnCreateCookbook.UseVisualStyleBackColor = false;
            // 
            // frmCreateCookbook
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(787, 325);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmCreateCookbook";
            Text = "Hearty Hearth - Auto-Create a Cookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private ComboBox lstUserName;
        private Button btnCreateCookbook;
    }
}