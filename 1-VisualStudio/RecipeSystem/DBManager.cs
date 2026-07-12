using CPUFramework;

namespace RecipeSystem
{
    public class DBManager
    {
        public static void SetConnectionString(string connectionstring, bool tryopen, string user = "", string password = "")
        {
            SQLUtility.SetConnectionString(connectionstring,tryopen,user,password);
        }
    }
}
