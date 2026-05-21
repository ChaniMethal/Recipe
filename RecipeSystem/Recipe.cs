using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipe(string RecipeName)
        {
            DataTable dt = new();

            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");

            SQLUtility.SetParamValues(cmd, "@RecipeName", RecipeName);

            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable Load(int RecipeId)
        {
            DataTable dt = new();

            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");

            SQLUtility.SetParamValues(cmd, "@RecipeId", RecipeId);

            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable GetRecipeList()
        {
            DataTable dt = new();

            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");

            SQLUtility.SetParamValues(cmd, "@All", 1);

            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable GetUserList()
        {
            DataTable dt = new();

            SqlCommand cmd = SQLUtility.GetSqlCommand("UsersGet");

            SQLUtility.SetParamValues(cmd, "@All", 1);

            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable GetCuisineList()
        {
            DataTable dt = new();

            SqlCommand cmd = SQLUtility.GetSqlCommand("CuisineGet");

            SQLUtility.SetParamValues(cmd, "@All", 1);

            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Save(DataTable dtrecipe)
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
                SQLUtility.ExecuteSQL(sql);
            }
        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];

            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDelete");
            SQLUtility.SetParamValues(cmd, "@RecipeId", id);

            SQLUtility.ExecuteSQL(cmd);
        }

    }
}
