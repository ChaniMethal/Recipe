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

            cmd.Parameters["@RecipeName"].Value = RecipeName;

            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable Load(int RecipeId)
        {
            DataTable dt = new();

            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");

            cmd.Parameters["@RecipeId"].Value = RecipeId;

            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable GetRecipeList()
        {
            DataTable dt = new();

            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");

            cmd.Parameters["@All"].Value = 1;

            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable GetUserList()
        {
            DataTable dt = new();

            SqlCommand cmd = SQLUtility.GetSqlCommand("UserGet");

            cmd.Parameters["@All"].Value = 1;

            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable GetCuisineList()
        {
            DataTable dt = new();

            SqlCommand cmd = SQLUtility.GetSqlCommand("CuisineGet");

            cmd.Parameters["@All"].Value = 1;

            dt = SQLUtility.GetDataTable(cmd);
            return dt;
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
