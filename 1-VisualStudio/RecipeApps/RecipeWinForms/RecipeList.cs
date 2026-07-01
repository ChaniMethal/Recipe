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
            gRecipeList.DoubleClick += GRecipeList_DoubleClick;
            gRecipeList.KeyDown += GRecipeList_KeyDown;
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
            gRecipeList.DataSource = DataMaintenance.GetDataList("RecipeList");
        }
        private void OpenRecipe()
        {
            Application.UseWaitCursor = true;

            try
            {
                if (gRecipeList.CurrentRow == null) return;

                int recipeId = (int)gRecipeList.CurrentRow.Cells["RecipeId"].Value;

                frmDashboard main = (frmDashboard)this.MdiParent;
                main.OpenForm(typeof(frmRecipe), recipeId);
            }
            finally { Application.UseWaitCursor = false; }
        }
        private void GetRecipeList()
        {
            frmDashboard main = (frmDashboard)this.MdiParent;
            main.OpenForm(typeof(frmRecipe));
        }
        private void GRecipeList_DoubleClick(object? sender, EventArgs e)
        {
            OpenRecipe();
        }

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            GetRecipeList();
        }
    }
}
