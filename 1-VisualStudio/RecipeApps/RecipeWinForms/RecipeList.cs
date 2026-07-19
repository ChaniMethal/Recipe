using RecipeWinForms;

namespace RecipeWinForm
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            LoadList();
            gRecipeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnNewRecipe.Click += BtnNewRecipe_Click;
            gRecipeList.CellDoubleClick += GRecipeList_CellDoubleClick;
            gRecipeList.KeyDown += GRecipeList_KeyDown;
            gRecipeList.AllowUserToAddRows = false;
            gRecipeList.ReadOnly = true;
        }

        private void GRecipeList_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                OpenRecipe();
            }
        }

        private void LoadList()
        {
            gRecipeList.DataSource = RecipeClass.GetRecipeList();
            gRecipeList.Columns["RecipeId"].Visible = false;
        }
        private void OpenRecipe()
        {
            Application.UseWaitCursor = true;

            try
            {
                if (gRecipeList.CurrentRow == null) return;

                int recipeId = (int)gRecipeList.CurrentRow.Cells["RecipeId"].Value;

                frmMain main = (frmMain)this.MdiParent;
                main.OpenForm(typeof(frmRecipe), recipeId);
            }
            finally { Application.UseWaitCursor = false; }
        }
        private void GetRecipeList()
        {
            frmMain main = (frmMain)this.MdiParent;
            main.OpenForm(typeof(frmRecipe));
        }
        private void GRecipeList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                OpenRecipe();
            }
        }

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            GetRecipeList();
        }
    }
}
