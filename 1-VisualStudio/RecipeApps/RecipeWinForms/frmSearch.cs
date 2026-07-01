using System.Data;
using System.Diagnostics;
namespace RecipeWinForm
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
            btnNew.Click += BtnNew_Click;
            WindowsFormsUtility.FormatGridForSearchResults(gRecipe, "Recipe");
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if(rowindex > -1)
            {
                id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
            }
            frmRecipe frm = new frmRecipe();
            frm.ShowForm(id);
        }
        private void SearchForRecipe(string RecipeName)
        {
            DataTable dt = Recipe.SearchRecipe(RecipeName);
            gRecipe.DataSource = dt;
            gRecipe.Columns["RecipeId"].Visible = false;
        }

        private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }
        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForRecipe(txtRecipeName.Text);
        }
        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }

    }
}
