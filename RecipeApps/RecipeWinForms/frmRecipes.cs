using CPUFramework;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmRecipes : Form
    {
        public frmRecipes()
        {
            InitializeComponent();
        }

        public void ShowForm(int RecipeId)
        {
            string sql = "select r.RecipeName, c.CuisineName, u.FirstName, u.LastName, r.Calories, r.DateCreated, r.DateArchived, r.DatePublished, r.RecipeStatus " +
                "from Recipe r " +
                "join Users u on u.UserId = r.UserId " +
                "join Cuisine c on c.CuisineId = r.CuisineId " +
                " where r.RecipeId = " +
                RecipeId.ToString();
            DataTable dt = SQLUtility.GetDataTable(sql);
            lblRecipeName.DataBindings.Add("Text", dt, "RecipeName");
            lblCuisineName.DataBindings.Add("Text", dt, "CuisineName");
            txtUserFirstName.DataBindings.Add("Text", dt, "FirstName");
            txtUserLastName.DataBindings.Add("Text", dt, "LastName");
            txtCalories.DataBindings.Add("Text", dt, "Calories");
            txtDateCreated.DataBindings.Add("Text", dt, "DateCreated");
            txtDateArchived.DataBindings.Add("Text", dt, "DateArchived");
            txtDatePublished.DataBindings.Add("Text", dt, "DatePublished");
            txtRecipeStatus.DataBindings.Add("Text", dt, "RecipeStatus");
            this.Show();

        }
    }
}


