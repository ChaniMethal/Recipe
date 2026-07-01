namespace RecipeWinForm
{
    partial class frmRecipeList
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
            gDataRecipe = new TableLayoutPanel();
            btnNewRecipe = new Button();
            gRecipeList = new DataGridView();
            gDataRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipeList).BeginInit();
            SuspendLayout();
            // 
            // gDataRecipe
            // 
            gDataRecipe.BackColor = Color.AliceBlue;
            gDataRecipe.ColumnCount = 1;
            gDataRecipe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gDataRecipe.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            gDataRecipe.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            gDataRecipe.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            gDataRecipe.Controls.Add(btnNewRecipe, 0, 0);
            gDataRecipe.Controls.Add(gRecipeList, 0, 1);
            gDataRecipe.Dock = DockStyle.Fill;
            gDataRecipe.Location = new Point(0, 0);
            gDataRecipe.Name = "gDataRecipe";
            gDataRecipe.RowCount = 2;
            gDataRecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 13.7777777F));
            gDataRecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 86.22222F));
            gDataRecipe.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            gDataRecipe.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            gDataRecipe.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            gDataRecipe.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            gDataRecipe.Size = new Size(800, 450);
            gDataRecipe.TabIndex = 0;
            // 
            // btnNewRecipe
            // 
            btnNewRecipe.AutoSize = true;
            btnNewRecipe.BackColor = Color.LightSteelBlue;
            btnNewRecipe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewRecipe.Location = new Point(3, 3);
            btnNewRecipe.Name = "btnNewRecipe";
            btnNewRecipe.Size = new Size(170, 56);
            btnNewRecipe.TabIndex = 0;
            btnNewRecipe.Text = "New Recipe";
            btnNewRecipe.UseVisualStyleBackColor = false;
            // 
            // gRecipeList
            // 
            gRecipeList.BackgroundColor = Color.AliceBlue;
            gRecipeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipeList.Dock = DockStyle.Fill;
            gRecipeList.Location = new Point(3, 65);
            gRecipeList.Name = "gRecipeList";
            gRecipeList.RowHeadersWidth = 51;
            gRecipeList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gRecipeList.Size = new Size(794, 382);
            gRecipeList.TabIndex = 1;
            // 
            // frmRecipeList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gDataRecipe);
            Name = "frmRecipeList";
            Text = "Recipe List";
            gDataRecipe.ResumeLayout(false);
            gDataRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipeList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel gDataRecipe;
        private Button btnNewRecipe;
        private DataGridView gRecipeList;
    }
}