using NUnit.Framework.Legacy;
using System.Data;

namespace RecipeTest
{
    public class RecipeTest
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server = tcp:chanim.database.windows.net,1433; Initial Catalog = RecipeDB; Persist Security Info = False; User ID = ChaniM; Password = Azure2026!; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
        }

        [Test]
        [TestCase("Yehuda", "Test1", "2015-01-01", 230)]
        [TestCase("Yisrael", "Test2", "2024-04-15", 180)]
        public void InsertNewRecipe(string firstname, string lastname, DateTime datecreated, int calories)
        {
            DataTable dt = SQLUtility.GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();

            Assume.That(dt.Rows.Count == 1);

            int userid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 userid from users");
            int cuisineid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 cuisineid from cuisine");

            Assume.That(userid > 0, "Can't run test no users in DB");
            Assume.That(cuisineid > 0, "Can't run test no cuisines in DB");

            string recipename = firstname + " " + lastname + " " + DateTime.Now.ToString("yyyMMddHHmmss");

            TestContext.WriteLine("insert recipe with name = " + recipename);

            r["RecipeName"] = recipename;
            r["UserId"] = userid;
            r["CuisineId"] = cuisineid;
            r["DateCreated"] = datecreated;
            r["Calories"] = calories;

            Recipe.Save(dt);

            int newid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe where recipename = '" + recipename + "' order by recipeid desc");

            ClassicAssert.IsTrue(newid > 0, "recipe with name = " + recipename + " is not found in DB");
            TestContext.WriteLine("recipe with name " + recipename + " is found in db with pk value = " + newid);
        }


        [Test]
        public void ChangeExistingRecipeCalories()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            int calories = SQLUtility.GetFirstColumnFirstRowValue("select calories from Recipe where recipeid = " + recipeid);
            TestContext.WriteLine("Calories for recipeid " + recipeid + " is " + calories);
            calories = calories + 1;
            TestContext.WriteLine("change calories to " + calories);
            DataTable dt = Recipe.Load(recipeid);

            dt.Rows[0]["calories"] = calories;
            Recipe.Save(dt);

            int newcalories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            ClassicAssert.IsTrue(newcalories == calories, "calories for recipe (" + recipeid + ") = " + newcalories);
            TestContext.WriteLine("calories for recipe (" + recipeid + ") = " + newcalories);
        }
        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable
                ("select top 1 r.* from recipe r " +
                "left join IngredientDesc i on i.RecipeId = r.RecipeId " +
                "left join PrepSteps p on p.RecipeId = r.RecipeId " +
                "left join MealCourseRecipe m on m.RecipeId = r.RecipeId " +
                "left join CookBookRecipe c on c.RecipeId = r.RecipeId " +
                "where i.IngredientId is null " +
                "and p.PrepStepsId is null " +
                "and m.MealCourseRecipeId is null " +
                "and c.CookBookRecipeId is null " +
                "order by r.recipeid desc");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeName"].ToString();
            }
            Assume.That(recipeid > 0, "No recipes without related record in DB, can't run test");
            TestContext.WriteLine("existing recipe without user, with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure that app can delete " + recipeid);
            Recipe.Delete(dt);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            ClassicAssert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + " exists in DB");
            TestContext.WriteLine("Record with recipeid " + recipeid + " does not exist in DB");
        }
        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No presidents in DB, can't run test");
            TestContext.WriteLine("existing president with id = " + recipeid);
            TestContext.WriteLine("ensure that app loads president " + recipeid);
            DataTable dt = Recipe.Load(recipeid);
            int loadedid = (int)dt.Rows[0]["recipeid"];
            ClassicAssert.IsTrue(loadedid == recipeid, loadedid + " <> " + recipeid);
            TestContext.WriteLine("Loaded president ("  +  loadedid + ")");
        }

        [Test]
        public void GetListOfRecipes()
        {
            int recipecount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from recipe");
            Assume.That(recipecount > 0, "No recipe in DB, can't test");
            TestContext.WriteLine("Num of recipes in DB = " + recipecount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + recipecount);
            
            DataTable dt = Recipe.GetRecipeList();

            ClassicAssert.IsTrue(dt.Rows.Count == recipecount, "num rows returned by app (" + dt.Rows.Count + ") <> ");
            TestContext.WriteLine("Number of rows in Recipes return by app = " + dt.Rows.Count);
        }
        private int GetExistingRecipeId()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
        }
    }
}
