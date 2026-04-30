using CPUFramework;
using CPUWindowsFormsFramework;
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
            string sql = "select r.RecipeId, r.RecipeName, r.CuisineId, c.CuisineName, r.UserId, u.UserName, r.Calories, r.DateCreated, r.DateArchived, r.DatePublished, r.RecipeStatus " +
                "from Recipe r " +
                "join Users u on u.UserId = r.UserId " +
                "join Cuisine c on c.CuisineId = r.CuisineId " +
                " where r.RecipeId = " +
                RecipeId.ToString();
            dtrecipe = SQLUtility.GetDataTable(sql);
            if (RecipeId == 0 )
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtcuisines = SQLUtility.GetDataTable("select CuisineId, CuisineName from Cuisine");
            DataTable dtusername = SQLUtility.GetDataTable("select UserId, UserName from Users");
            if (RecipeId == 0)
            {
                dtrecipe.Rows.Add();
                dtrecipe.Rows[0]["CuisineId"] = dtcuisines.Rows[0]["CuisineId"];
                dtrecipe.Rows[0]["UserId"] = dtusername.Rows[0]["UserId"];
            }
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
        private void Delete()
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
        }
        private void Save()
        {
            SQLUtility.DebugPrintDataTable(dtrecipe);
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";

            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update recipe set",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"CuisineId = '{r["CuisineId"]}',",
                    $"UserId = '{r["UserId"]}',",
                    $"Calories = '{r["Calories"]}',",
                    $"DateCreated = '{r["DateCreated"]}'",
                    $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {
                sql = "insert Recipe(RecipeName, CuisineId, UserId, Calories, DateCreated) ";
                sql += $"select '{r["RecipeName"]}', '{r["CuisineId"]}', '{r["UserId"]}','{r["Calories"]}', '{r["DateCreated"]}'";

            }
            Debug.Print(sql);
            SQLUtility.ExecuteSQL(sql);
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}


