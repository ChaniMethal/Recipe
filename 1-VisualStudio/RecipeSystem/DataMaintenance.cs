using System.Data;


namespace RecipeSystem
{
    public static class DataMaintenance
    {
        public static void DeleteRowForDataMaintenance(DataTable dt, string tablename, int rowindex)
        {
            string idcol = "";
            string sproc = "";

            if(tablename == "Users")
            {
                idcol = "UserId";
                sproc = "UsersDelete";
            }
            if (tablename == "Cuisine")
            {
                idcol = "CuisineId";
                sproc = "CuisineDelete";
            }
            if (tablename == "Ingredient")
            {
                idcol = "IngredientId";
                sproc = "IngredientDelete";
            }
            if (tablename == "MeasurementType")
            {
                idcol = "MeasurementTypeId";
                sproc = "MeasurementDelete";
            }
            if (tablename == "Courses")
            {
                idcol = "CourseId";
                sproc = "CoursesDelete";
            }

            int id = (int)dt.Rows[rowindex][idcol];

            SqlCommand cmd = SQLUtility.GetSqlCommand(sproc);
            SQLUtility.SetParamValues(cmd, "@" + idcol, id);

            SQLUtility.ExecuteSQL(cmd);
        }
        public static DataTable GetDataList(string tablename, bool includeblank = false)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand(tablename + "Get");
            SQLUtility.SetParamValues(cmd, "@All", 1);
            if (includeblank == true)
            {
                SQLUtility.SetParamValues(cmd, "@IncludeBlank", includeblank);
            }
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static void SaveDataList(DataTable dt, string tablename)
        {
            SQLUtility.SaveDataTable(dt, tablename + "Update");
        }

        public static void DeleteRow(string tablename, int id)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(tablename + "Delete");
            SQLUtility.SetParamValues(cmd, $"@{tablename}Id", id);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static DataTable GetDashboard()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDashboardGet");
            return SQLUtility.GetDataTable(cmd);
        }
    }
}

