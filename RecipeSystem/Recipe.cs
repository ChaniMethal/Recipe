using System.Data;
using System.Diagnostics;

namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipe(string RecipeName)
        {
            string sql = "select RecipeId, RecipeName from Recipe r where r.RecipeName like '%" + RecipeName + "%'";

            DataTable dt = SQLUtility.GetDataTable(sql);
            return dt;
        }
        public static DataTable Load(int RecipeId)
        {
            string sql = "select * from Recipe  where RecipeId = " + RecipeId;
            return SQLUtility.GetDataTable(sql);
        }
        public static DataTable GetRecipeList()
        {
            return SQLUtility.GetDataTable("select RecipeId, RecipeName from Recipe");
        }
        public static DataTable GetUserList()
        {
            return SQLUtility.GetDataTable("select UserId, UserName from Users");
        }
        public static DataTable GetCuisineList()
        {
            return SQLUtility.GetDataTable("select CuisineId, CuisineName from Cuisine");
        }

        public static void Save(DataTable dtrecipe)
        {
                SQLUtility.DebugPrintDataTable(dtrecipe);
                DataRow r = dtrecipe.Rows[0];
                int id = r["RecipeId"] == DBNull.Value ? 0 : (int)r["RecipeId"];
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
        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
        }

    }
}
