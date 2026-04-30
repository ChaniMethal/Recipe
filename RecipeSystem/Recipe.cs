using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CPUFramework;

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
    }
}
