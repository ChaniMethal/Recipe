using System.Data;
using System.Diagnostics;

namespace RecipeWinForms
{
    public partial class frmRecipes : Form
    {
        DataTable dtrecipe;
        public frmRecipes()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }
        

        public void ShowForm(int RecipeId)
        {
            dtrecipe = Recipe.Load(RecipeId);
            if (RecipeId == 0 )
            {
                dtrecipe.Rows.Add();
                dtrecipe.Rows[0]["DateCreated"] = DateTime.Today;
            }
            DataTable dtcuisines = Recipe.GetCuisineList();
            DataTable dtusername = Recipe.GetUserList();
            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WindowsFormsUtility.SetListBinding(lstCuisineName, dtcuisines, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetListBinding(lstUserName, dtusername, dtrecipe, "User");
            WindowsFormsUtility.SetControlBinding(txtCalories, dtrecipe);
            WindowsFormsUtility.SetControlBinding(dtpDateCreated, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtRecipeStatus, dtrecipe);
            this.Show();

        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Recipe.Delete(dtrecipe);
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Recipe.Save(dtrecipe);
        }
    }
}


