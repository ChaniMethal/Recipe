using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CPUFramework;
using Microsoft.Data.SqlClient;

namespace RecipeWinForm
{
    internal class RecipeSteps
    {
        public static DataTable LoadByRecipeId(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeStepsGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static void SaveTable(DataTable dt, int RecipeId)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r["RecipeId"] = RecipeId;
            }
            SQLUtility.SaveDataTable(dt, "PrepStepsUpdate");
        }
        public static void Delete(int prepstepsid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("PrepStepsDelete");
            cmd.Parameters["@PrepStepsId"].Value = prepstepsid;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
