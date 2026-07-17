using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeSystem
{
    public class CookBookClass
    {
        public static DataTable LoadRecipes(int CookBookId)
        {
            DataTable dt = new();

            SqlCommand cmd = SQLUtility.GetSqlCommand("CookBookRecipeGet");

            SQLUtility.SetParamValues(cmd, "@CookBookId", CookBookId);

            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable Load(int CookBookId)
        {
            DataTable dt = new();

            SqlCommand cmd = SQLUtility.GetSqlCommand("CookBookGet");

            SQLUtility.SetParamValues(cmd, "@CookBookId", CookBookId);

            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static void Save(DataTable dtcookbook)
        {
            if (dtcookbook.Rows.Count == 0)
            {
                throw new Exception("Cannot save CookBook because there are no rows in the table.");
            }

            SQLUtility.SaveDataTable(dtcookbook, "CookBookUpdate");
        }
        public static void Delete(DataTable dtcookbook)
        {
            if (dtcookbook.Rows.Count == 0)
            {
                throw new Exception("Cannot delete cookbook because there are no rows in the table.");
            }

            int cookbookid = Convert.ToInt32(dtcookbook.Rows[0]["CookBookId"]);

            SqlCommand cmd = SQLUtility.GetSqlCommand("CookBookDelete");
            SQLUtility.SetParamValues(cmd, "@CookBookId", cookbookid);

            SQLUtility.ExecuteSQL(cmd);
        }
        public static int AutoCreate(int userid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookBookAutoCreate");

            cmd.Parameters["@UserId"].Value = userid;
            cmd.Parameters["@NewCookBookId"].Value = 0;

            SQLUtility.ExecuteSQL(cmd);

            int newcookbookid = (int)cmd.Parameters["@NewCookBookId"].Value;

            return newcookbookid;
        }

        public static void DeleteRecipe(int cookbookrecipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookBookRecipeDelete");
            SQLUtility.SetParamValues(cmd, "@CookBookRecipeId", cookbookrecipeid);
            SQLUtility.ExecuteSQL(cmd);
        }
        public static void AllowOnlyNumbers(KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            MessageBox.Show("Only numbers are allowed.", Application.ProductName);
            e.Handled = true;
        }
        public static DataTable GetCookBookList()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookBookGet");
            SQLUtility.SetParamValues(cmd, "@All", 1);

            return SQLUtility.GetDataTable(cmd);
        }
    }
}
