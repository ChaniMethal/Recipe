using CPUFramework;
using Microsoft.Data.SqlClient;
using System.Data;

namespace RecipeWinForm
{
    public class RecipeIngredient
    {
        public static DataTable LoadByRecipeId(int RecipeId)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeIngredientGet");
            cmd.Parameters["@RecipeId"].Value = RecipeId;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static void SaveTable(DataTable dt, int RecipeId)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r["RecipeId"] = RecipeId;
            }
            SQLUtility.SaveDataTable(dt, "IngredientUpdate");
        }
        public static void Delete(int ingredientdescid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeIngredientDelete");
            cmd.Parameters["@IngredientDescId"].Value = ingredientdescid;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
