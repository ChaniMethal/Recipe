/*
Our website development is underway! 
Below is the layout of the pages on our website, please provide the SQL to produce the necessary result sets.

Note: 
a) When the word 'specific' is used, pick one record (of the appropriate type, recipe, meal, etc.) for the query. 
    The way the website works is that a list of items are displayed and then the user picks one and navigates to the "details" page.
b) Whenever you have a record for a specific item include the name of the picture for that item. That is because the website will always show a picture of the item.
*/

/*
Home Page
    One result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
*/
select ItemName = 'Recipes', Count = Count (*) from Recipe
union all select 'Meals', Count (*) from Meal
union all select 'CookBooks', Count (*) from CookBook

/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. Archived recipes should appear gray on the website.
	In order for the recipe name to be gray on the website, surround the archived recipe names with: <span style="color:gray">recipe name</span>
    In the resultset show the Recipe with its status, dates it was published and archived in mm/dd/yyyy format (blank if not archived), user, number of calories and number of ingredients.
    Tip: You'll need to use the convert function for the dates
*/
select RecipeName = (case when r.DateArchived is not null then '<span style="color:gray">' + r.RecipeName +  '</span>'else RecipeName end), 
    r.RecipeStatus, DatePublished = CONVERT(varchar, r.DatePublished, 101), DateArchived = isnull(CONVERT(varchar, r.DateArchived, 101), ''), r.UserId, r.Calories, NumOfIngredients = COUNT(id.IngredientId)
from Recipe r 
join IngredientDesc id 
on id.RecipeId = r.RecipeId
group by r.RecipeName, r.RecipeStatus, r.DatePublished, r.DateArchived,r.UserId, r.Calories
order by (case when r.DateArchived is null then 0 else 1 end), r.DatePublished

/*
Recipe details page:
    Show for a specific recipe (three result sets):
        a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
        b) List of ingredients: show the measurement quantity, measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
        c) List of prep steps sorted by sequence.
*/
--Recipe Header:
select r.RecipeName, r.Calories, NumOfIngredients = COUNT(distinct id.IngredientId), NumOfSteps = COUNT(distinct ps.PrepStepsId), r.RecipePicture
from Recipe r
join IngredientDesc id 
on id.RecipeId = r.RecipeId
left join PrepSteps ps 
on ps.RecipeId = r.RecipeId
where r.RecipeName = 'Chocolate Chip Cookies'
group by r.RecipeName, r.Calories, r.RecipePicture

--List of Ingredients 
select ListofIngredients = CONCAT(id.MeasurementQuantity, ' ', mt.MeasurementType, ' ', i.IngredientName), r.RecipePicture
from Ingredient i 
join IngredientDesc id 
on id.IngredientId = i.IngredientId
join MeasurementType mt 
on mt.MeasurementTypeId = id.MeasurementTypeId
join Recipe r 
on r.RecipeId = id.RecipeId
where r.RecipeName = 'Chocolate Chip Cookies'
order by id.IngredientSequence

--PrepSteps
select ps.StepDesc, r.RecipePicture
from PrepSteps ps 
join Recipe r 
on ps.RecipeId = r.RecipeId
where r.RecipeName = 'Chocolate Chip Cookies'
order by ps.StepSequence
/*
Meal list page:
    For all active meals, show the meal name, user that created the meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
*/
select m.MealName, u.FirstName, u.LastName, NumOfCalories = Sum(r.Calories), NumOfCourses = count( mc.MealCourseId), NumOfRecipes = COUNT(r.RecipeId)
from Meal m 
left join MealCourse mc 
on mc.MealId = m.MealId
left join MealCourseRecipe mcr 
on mcr.MealCourseId = mc.MealCourseId
left join Recipe r 
on r.RecipeId = mcr.RecipeId
join users u 
on u.UserId = m.UserId
where m.Active = 1
group by m.MealName, u.FirstName, u.LastName
order by m.MealName

/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, user, date created.
        b) List of all recipes: Result set should have one column, including the course type, whether the dish is serverd as main/side (if it's the main course), and recipe name. 
			Format for main course: CourseType: Main/Side dish - Recipe Name. 
            Format for non-main course: CourseType: Recipe Name
            Main dishes of the main course should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
					Main: Side dish - Roasted cucumbers with mustard
*/
--a)
select m.MealName, u.FirstName, u.LastName, m.DateCreated
from Meal m 
join users u 
on u.UserId = m.UserId

--b) 
select Recipes =  case 
        when c.CourseType = 'Main' and c.IsMainDish = 1
            then '<b>Main: Main dish - ' + r.RecipeName + '</b>'
        when c.CourseType = 'Main' and c.IsMainDish = 0
            then c.CourseType +': ' + 'Side Dish - ' +r.RecipeName
        else c.CourseType + ': ' + r.RecipeName
        end
from course c 
Join MealCourse mc 
on c.CourseId = mc.CourseId
join Meal m 
on m.MealId = mc.MealId
join MealCourseRecipe mcr
on mcr.MealCourseId = mc.MealCourseId
join Recipe r 
on r.RecipeId = mcr.RecipeId
where m.MealName = 'Scrumptious Lunch'


/*
Cookbook list page:
    Show all active cookbooks with author and number of recipes per book. Sorted by book name.
*/
select cb.CookBookName, u.FirstName, u.LastName, NumOfRecipes = COUNT(cbr.RecipeId)
from CookBook cb 
join Users u 
on u.UserId = cb.UserId
join CookBookRecipe cbr 
on cbr.CookBookId = cb.CookBookId
where Active = 1
group by cb.CookBookName, u.FirstName, u.LastName
order by cb.CookBookName

/*
Cookbook details page:
    Show for specific cookbook:
    a) Cookbook header: cookbook name, user, date created, price, number of recipes.
    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  
        Note: User will click on recipe to see all ingredients and steps.
*/
--a) 
select cb.CookBookName, u.FirstName, u.LastName, cb.DateCreated, cb.Price, NumberOfRecipes = COUNT(cbr.RecipeId), cb.CookBookPicture
from CookBook cb 
join CookBookRecipe cbr 
on cb.CookBookId = cbr.CookBookId
join users u 
on u.UserId = cb.UserId
where cb.CookBookName = 'Sweet & Simple Desserts'
group by cb.CookBookName, u.FirstName, u.LastName, cb.DateCreated, cb.Price, cb.CookBookPicture

--b)
select r.RecipeName, c.CuisineName, NumOfIngredients = COUNT(distinct id.IngredientId), NumOfSteps = COUNT(distinct ps.PrepStepsId), cbr.[Sequence], r.RecipePicture
From Recipe r 
left join Cuisine c 
on c.CuisineId = r.CuisineId
left join IngredientDesc id 
on id.RecipeId = r.RecipeId
left join PrepSteps ps 
on ps.RecipeId = r.RecipeId
left join CookBookRecipe cbr
on cbr.recipeid = r.RecipeId
left join CookBook cb 
on cb.CookBookId = cbr.CookBookId
where cb.CookBookName = 'Sweet & Simple Desserts'
group by r.RecipeName, c.CuisineName, cbr.Sequence, r.RecipePicture
order by cbr.Sequence

/*
April Fools Page:
    On April 1st we have a page with a joke cookbook. For that page provide the following.
    a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name with the first letter capitalized and all others lower case.
        There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
        Note: ".jpg" file extension must be at the end of the reversed picture name EX: Recipe_Seikooc_pihc_etalocohc.jpg
    b) When the user clicks on any recipe they should see a spoof steps lists showing the step instructions for the LAST step of EACH recipe in the system. No sequence required.
        Hint: Use CTE
*/

--a)
select RecipeName = upper(left(REVERSE(r.RecipeName),1)) + lower(substring(reverse(r.RecipeName),2,len(r.RecipeName))), 
RecipePicture = 'Recipe_' + reverse(SUBSTRING(r.RecipePicture, 8, len(r.RecipePicture)-7-4)) + '.jpg'
from recipe r 

--b)
;
with x as(
    select r.RecipeId, MaxStep = MAX(ps.StepSequence)
    from PrepSteps ps 
    join Recipe r 
    on r.RecipeId = ps.RecipeId
    group by r.RecipeId
) 
select ps.RecipeId, ps.StepDesc
from x 
join PrepSteps ps 
on ps.RecipeId = x.RecipeId
and ps.StepSequence = x.MaxStep

/*
For site administration page:
5 seperate reports
    a) List of how many recipes each user created per status. Show 0 if user has no recipes at all.
    b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
    c) For each user, show three columns: Total number of meals, Total Active meals, Total Inactive meals. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    d) For each user, show three columns: Total number of cookbooks, Total Active cookbooks, Total Inactive cookbooks. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    e) List of archived recipes that were never published, and how long it took for them to be archived.
*/

--a)
select u.UserId,u.FirstName, u.LastName, NumOfRecipes = (r.RecipeId)
from users u 
left join recipe r 
on u.UserId = r.UserId
group by u.UserId, u.FirstName, u.LastName
order by NumOfRecipes

--b)
select u.UserId,u.FirstName, u.LastName, NumOfRecipes = (r.RecipeId), AvgTimeToPublish = isnull(avg(DATEDIFF(DAY, r.DateCreated, r.DatePublished)),'')
from users u 
left join recipe r 
on u.UserId = r.UserId
group by u.UserId, u.FirstName, u.LastName
order by NumOfRecipes, AvgTimeToPublish

--c)
select u.UserId, u.FirstName, u.LastName, 
    TotalMeals = COUNT(m.MealId), 
    TotalActiveMeals = SUM(case when m.Active = 1 then 1 else 0 end), 
    TotalInactiveMeals = SUM(case when m.Active = 0 then 1 else 0 end)
from Users u 
left join Meal m 
on m.UserId = u.UserId
group by u.UserId, u.FirstName, u.LastName
order by TotalMeals desc, TotalActiveMeals desc

--d)
select u.UserId, u.FirstName, u.LastName, 
    TotalCookBooks =  COUNT(cb.CookBookId), 
    TotalActiveCookBooks = SUM(case when cb.Active = 1 then 1 else 0 end),
    TotalInactiveCookBooks = SUM(case when cb.Active = 0 then 1 else 0 end)
from users u 
left join CookBook cb 
on cb.UserId = u.UserId
group by u.UserId, u.FirstName, u.LastName
order by TotalActiveCookBooks, TotalInactiveCookBooks

select DaysTookToArchive =  DATEDIFF(day, DateCreated, DateArchived), r.RecipeName, r.DateCreated, r.DateArchived
from Recipe r 
where r.DateArchived is not null
and r.DatePublished is null
order by DaysTookToArchive
/*
For user dashboard page:
    a) For a specific user, show one result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
        Tip: If you would like, you can use a CTE to get the User Id once instead of in each union select
    b) List of the user's recipes, display the status and the number of hours between the status it's in and the one before that. Omit recipes in drafted status.
    
    OPTIONAL CHALLENGE QUESTION
    c) Show a list of cuisines and the count of recipes the user has per cuisine, 0 if none
        Hint: Start by writing a CTE to give you cuisines for which the user does have recipes. 
*/
--a)
;
with x as(
    select *
    from Users u 
    where u.FirstName = 'Sarah'
    and u.LastName = 'Cohen'
)
select ItemName = 'Recipes', ItemCount = COUNT(r.RecipeId)
from x 
left join Recipe r 
on r.UserId = x.UserId
union select 'Meals', COUNT(m.MealId)
from x 
left join Meal m 
on m.UserId = x.UserId
union select 'CookBooks', COUNT(cb.CookBookId)
from x 
left join CookBook cb 
on cb.UserId = x.UserId
order by ItemCount

--b) HoursBetweenStatuses =

select u.FirstName, u.LastName, r.RecipeName, r.RecipeStatus, 
    HoursBetweenStatuses = (case
        when r.RecipeStatus = 'published' 
            then DATEDIFF(HOUR, r.DateCreated, r.DatePublished)
        when r.RecipeStatus = 'archived'
            then DATEDIFF(HOUR, isnull(r.DatePublished, r.DateCreated) ,r.DateArchived)
        end
    )
from Users u 
left join Recipe r 
on r.UserId = u.UserId
where r.DatePublished is not null 
or r.DateCreated is not null
order by HoursBetweenStatuses, RecipeStatus

-- c)
/*   OPTIONAL CHALLENGE QUESTION
    c) Show a list of cuisines and the count of recipes the user has per cuisine, 0 if none
        Hint: Start by writing a CTE to give you cuisines for which the user does have recipes. 
        */

;
with x as (
    select u.UserId
    from Users u
    where u.FirstName = 'Sarah'and u.LastName = 'Cohen'
),
UserCuisine as (
    select c.CuisineId, c.CuisineName, NumRecipes = count(r.RecipeId)
    from Cuisine c
    left join Recipe r
    on r.CuisineId = c.CuisineId
    and r.UserId = (select x.UserId from x)
    group by c.CuisineId, c.CuisineName
)
select uc.CuisineName, uc.NumRecipes
from UserCuisine uc
order by uc.CuisineName

