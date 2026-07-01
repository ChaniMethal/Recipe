namespace RecipeWinForm
{
    partial class frmCookbookList
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnNewCookbook = new Button();
            gCookBookList = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gCookBookList).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.AliceBlue;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnNewCookbook, 0, 0);
            tableLayoutPanel1.Controls.Add(gCookBookList, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNewCookbook
            // 
            btnNewCookbook.AutoSize = true;
            btnNewCookbook.BackColor = Color.LightSteelBlue;
            btnNewCookbook.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewCookbook.Location = new Point(3, 3);
            btnNewCookbook.Name = "btnNewCookbook";
            btnNewCookbook.Size = new Size(158, 38);
            btnNewCookbook.TabIndex = 0;
            btnNewCookbook.Text = "New Cookbook";
            btnNewCookbook.UseVisualStyleBackColor = false;
            // 
            // gCookBookList
            // 
            gCookBookList.BackgroundColor = Color.AliceBlue;
            gCookBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gCookBookList.Dock = DockStyle.Fill;
            gCookBookList.Location = new Point(3, 47);
            gCookBookList.Name = "gCookBookList";
            gCookBookList.RowHeadersWidth = 51;
            gCookBookList.Size = new Size(794, 400);
            gCookBookList.TabIndex = 1;
            // 
            // frmCookbookList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "frmCookbookList";
            Text = "Cookbook List";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gCookBookList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnNewCookbook;
        private DataGridView gCookBookList;
    }
}