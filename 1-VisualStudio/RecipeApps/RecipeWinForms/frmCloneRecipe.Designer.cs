namespace RecipeWinForm
{
    partial class frmCloneRecipe
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
            lstRecipe = new ComboBox();
            btnClone = new Button();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lstRecipe, 0, 0);
            tblMain.Controls.Add(btnClone, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 59.0909081F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 40.9090919F));
            tblMain.Size = new Size(826, 407);
            tblMain.TabIndex = 0;
            // 
            // lstRecipe
            // 
            lstRecipe.BackColor = Color.AliceBlue;
            lstRecipe.FormattingEnabled = true;
            lstRecipe.Location = new Point(40, 40);
            lstRecipe.Margin = new Padding(40);
            lstRecipe.Name = "lstRecipe";
            lstRecipe.Size = new Size(465, 36);
            lstRecipe.TabIndex = 0;
            // 
            // btnClone
            // 
            btnClone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClone.AutoSize = true;
            btnClone.BackColor = Color.LightSteelBlue;
            btnClone.Location = new Point(573, 270);
            btnClone.Margin = new Padding(3, 30, 3, 3);
            btnClone.Name = "btnClone";
            btnClone.Size = new Size(250, 70);
            btnClone.TabIndex = 1;
            btnClone.Text = "Clone";
            btnClone.UseVisualStyleBackColor = false;
            // 
            // frmCloneRecipe
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(826, 407);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmCloneRecipe";
            Text = "Hearty Hearth - Clone a Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private ComboBox lstRecipe;
        private Button btnClone;
    }
}