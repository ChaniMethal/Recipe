using NUnit.Framework.Internal;
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

            TestContext.Out.WriteLine("insert recipe with name = " + recipename);

            r["RecipeName"] = recipename;
            r["UserId"] = userid;
            r["CuisineId"] = cuisineid;
            r["DateCreated"] = datecreated;
            r["Calories"] = calories;

            Recipe.Save(dt);

            int newid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe where recipename = '" + recipename + "' order by recipeid desc");

            ClassicAssert.IsTrue(newid > 0, "recipe with name = " + recipename + " is not found in DB");
            TestContext.Out.WriteLine("recipe with name " + recipename + " is found in db with pk value = " + newid);
        }
        [Test]
        public void DeleteRecipeWithDraftStatus()
        {
            string sql = @"
            select top 1 r.*
            from Recipe r
            left join IngredientDesc i on i.RecipeId = r.RecipeId
            left join PrepSteps p on p.RecipeId = r.RecipeId
            left join MealCourseRecipe m on m.RecipeId = r.RecipeId
            left join CookBookRecipe c on c.RecipeId = r.RecipeId
            where r.RecipeStatus = 'draft'
            and i.IngredientId is null
            and p.PrepStepsId is null
            and m.MealCourseRecipeId is null
            and c.CookBookRecipeId is null";

            DataTable dt = SQLUtility.GetDataTable(sql);

            int recipeid = 0;
            string recipedesc = "";

            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["RecipeId"];
                recipedesc = dt.Rows[0]["RecipeName"].ToString();
            }

            Assume.That(recipeid > 0, "No draft recipes in DB.");

            TestContext.Out.WriteLine("existing draft recipe, with id = " + recipeid + " " + recipedesc);
            TestContext.Out.WriteLine("ensure that app can delete draft recipe " + recipeid);

            Recipe.Delete(dt);

            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from Recipe where RecipeId = " + recipeid);

            ClassicAssert.IsTrue(dtafterdelete.Rows.Count == 0, "draft recipe was not deleted");

            TestContext.Out.WriteLine("Draft recipe with id = " + recipeid + " " + recipedesc + " was deleted");
        }
        [Test]
        public void DeleteRecipeWithArchivedRecipe()
        {
            string sql = @"
            select top 1 r.*
            from Recipe r
            left join IngredientDesc i on i.RecipeId = r.RecipeId
            left join PrepSteps p on p.RecipeId = r.RecipeId
            left join MealCourseRecipe m on m.RecipeId = r.RecipeId
            left join CookBookRecipe c on c.RecipeId = r.RecipeId
            where DateDiff(day, r.DateArchived, GETDATE()) > 30
            and i.IngredientId is null
            and p.PrepStepsId is null
            and m.MealCourseRecipeId is null
            and c.CookBookRecipeId is null";

            DataTable dt = SQLUtility.GetDataTable(sql);
            int recipeid = 0;
            string recipedesc = "";

            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["RecipeId"];
                recipedesc = dt.Rows[0]["RecipeName"].ToString();
            }
            Assume.That(recipeid > 0, "No archived recipes in DB.");
            TestContext.Out.WriteLine("existing archived recipe, with id = " + recipeid + " " + recipedesc);
            TestContext.Out.WriteLine("ensure that app can delete archived recipe " + recipeid);
            Recipe.Delete(dt);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from Recipe where RecipeId = " + recipeid);
            ClassicAssert.IsTrue(dtafterdelete.Rows.Count == 0, "archived recipe was not deleted");
            TestContext.Out.WriteLine("Archived recipe with id = " + recipeid + " " + recipedesc + " was deleted");
        }

        [Test]
        public void GetFirstColumnFirstRowValueAsString()
        {
            string s = SQLUtility.GetFirstColumnFirstRowValueAsString(
                "select top 1 LastName from users where LastName is not null"
            );

            TestContext.Out.WriteLine("lastname = [" + s + "]");

            ClassicAssert.IsTrue(s != "", "Should return a lastname");
        }
        [Test]
        public void ChangeExistingRecipeToInvalidCuisineId()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");

            DataTable dt = Recipe.Load(recipeid);

            dt.Rows[0]["CuisineId"] = -1;

            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));

            TestContext.Out.WriteLine(ex.Message);
        }
        [Test]
        public void ChangeExistingRecipeDateCreatedToInvalidDate()
        {
            int recipeid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe where DatePublished is not null");

            Assume.That(recipeid > 0, "No published recipes in DB, can't run test");

            DataTable dt = Recipe.Load(recipeid);

            DateTime datepublished = (DateTime)dt.Rows[0]["DatePublished"];
            DateTime invalidDateCreated = datepublished.AddDays(1);

            TestContext.Out.WriteLine("DatePublished = " + datepublished);
            TestContext.Out.WriteLine("Change DateCreated to invalid date = " + invalidDateCreated);

            dt.Rows[0]["DateCreated"] = invalidDateCreated;

            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));

            TestContext.Out.WriteLine(ex.Message);
        }

        [Test]
        public void ChangeExistingDuplicateRecipeName()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");

            string recipename = SQLUtility.GetFirstColumnFirstRowValueAsString(
                "select top 1 recipename from recipe where recipeid <> " + recipeid
            );

            Assume.That(recipename != "", "No other recipe name found");

            TestContext.Out.WriteLine("change recipename to duplicate name " + recipename);

            DataTable dt = Recipe.Load(recipeid);

            dt.Rows[0]["RecipeName"] = recipename;

            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));

            TestContext.Out.WriteLine(ex.Message);
        }
        [Test]
        public void ChangeExistingRecipeCalories()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            int calories = SQLUtility.GetFirstColumnFirstRowValue("select calories from Recipe where recipeid = " + recipeid);
            TestContext.Out.WriteLine("Calories for recipeid " + recipeid + " is " + calories);
            calories = calories + 1;
            TestContext.Out.WriteLine("change calories to " + calories);
            DataTable dt = Recipe.Load(recipeid);

            dt.Rows[0]["calories"] = calories;
            Recipe.Save(dt);

            int newcalories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            ClassicAssert.IsTrue(newcalories == calories, "calories for recipe (" + recipeid + ") = " + newcalories);
            TestContext.Out.WriteLine("calories for recipe (" + recipeid + ") = " + newcalories);
        }
        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable(
       "select top 1 r.* from recipe r " +
       "where isnull(r.RecipeStatus, '') <> 'draft' " +
       "and (r.DateArchived is null or datediff(day, r.DateArchived, getdate()) <= 30) " +
       "order by r.recipeid desc"
   );

            int recipeid = 0;
            string recipedesc = "";

            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeName"].ToString();
            }

            Assume.That(recipeid > 0, "No non-deletable recipes in DB, can't run test");

            TestContext.Out.WriteLine("existing non-deletable recipe, with id = " + recipeid + " " + recipedesc);
            TestContext.Out.WriteLine("ensure that app cannot delete recipe " + recipeid);

            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));

            TestContext.Out.WriteLine(ex.Message);

            DataTable dtafterdelete = SQLUtility.GetDataTable(
                "select * from Recipe where RecipeId = " + recipeid
            );

            ClassicAssert.IsTrue(dtafterdelete.Rows.Count == 1, "non-deletable recipe was deleted");
        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No presidents in DB, can't run test");
            TestContext.Out.WriteLine("existing president with id = " + recipeid);
            TestContext.Out.WriteLine("ensure that app loads president " + recipeid);
            DataTable dt = Recipe.Load(recipeid);
            int loadedid = (int)dt.Rows[0]["recipeid"];
            ClassicAssert.IsTrue(loadedid == recipeid, loadedid + " <> " + recipeid);
            TestContext.Out.WriteLine("Loaded president ("  +  loadedid + ")");
        }

        [Test]
        public void GetListOfRecipes()
        {
            int recipecount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from recipe");
            Assume.That(recipecount > 0, "No recipe in DB, can't test");
            TestContext.Out.WriteLine("Num of recipes in DB = " + recipecount);
            TestContext.Out.WriteLine("Ensure that num of rows return by app matches " + recipecount);
            
            DataTable dt = Recipe.GetRecipeList();

            ClassicAssert.IsTrue(dt.Rows.Count == recipecount, "num rows returned by app (" + dt.Rows.Count + ") <> ");
            TestContext.Out.WriteLine("Number of rows in Recipes return by app = " + dt.Rows.Count);
        }
        private int GetExistingRecipeId()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
        }
    }
}
