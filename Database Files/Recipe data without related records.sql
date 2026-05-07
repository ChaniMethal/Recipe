use RecipeDB
go

delete CookBookRecipe
delete MealCourseRecipe
delete MealCourse
delete CookBook
delete IngredientDesc
delete PrepSteps
delete Course
delete Meal
delete Ingredient
delete MeasurementType
delete Recipe
delete Cuisine
delete Users
go

insert Users(FirstName, LastName)
select 'Sarah', 'Cohen'
union select 'Dovid', 'Levy'
union select 'Miriam', 'Adler'
union select 'Yaakov', 'Friedman'
union select 'Rivka', 'Stein'
union select 'Aaron', 'Weiss'

insert Cuisine(CuisineName)
select 'American'
union select 'French'
union select 'English'

insert Recipe(CuisineId, UserId, RecipeName, Calories, DateCreated, DatePublished, DateArchived)
select (select CuisineId from Cuisine c where c.CuisineName = 'American'), 
    (select u.UserId from users u where u.FirstName = 'Sarah' and u.LastName = 'Cohen'),
    'Chocolate Chip Cookies', 488, '11-15-2022', '11-25-2022', null
union select (select CuisineId from Cuisine c where c.CuisineName = 'French'),
    (select u.UserId from users u where u.FirstName = 'Dovid' and u.LastName = 'Levy'),
    'Apple Yogurt Smoothie', 339, '05-06-2021', '06-05-2021', null
union select (select CuisineId from Cuisine c where c.CuisineName = 'English'), 
    (select u.UserId from users u where u.FirstName = 'Miriam' and u.LastName = 'Adler'),
    'Cheese Bread', 120, '06-25-2024', '06-30-2024', '07-25-2024'
union select (select CuisineId from Cuisine c where c.CuisineName = 'American'), 
    (select u.UserId from users u where u.FirstName = 'Yaakov' and u.LastName = 'Friedman'),
    'Butter Muffins', 148, '02-14-2012', '04-15-2012', '02-11-2024'
union select (select CuisineId from Cuisine c where c.CuisineName = 'American'), 
    (select u.UserId from users u where u.FirstName = 'Yaakov' and u.LastName = 'Friedman'),
    'Pizza', 54, '02-14-2022', '04-15-2022', null
union select (select CuisineId from Cuisine c where c.CuisineName = 'American'), 
    (select u.UserId from users u where u.FirstName = 'Yaakov' and u.LastName = 'Friedman'),
    'Fries', 150, '07-14-2022', '09-27-2022', null
union select (select CuisineId from Cuisine c where c.CuisineName = 'American'), 
    (select u.UserId from users u where u.FirstName = 'Yaakov' and u.LastName = 'Friedman'),
    'Milk Shake', 350, '12-14-2022', '04-15-2023', null
union select (select CuisineId from Cuisine c where c.CuisineName = 'American'), 
    (select u.UserId from users u where u.FirstName = 'Sarah' and u.LastName = 'Cohen'),
    'Chicken', 30, '02-14-2024', '04-15-2024', null
union select (select CuisineId from Cuisine c where c.CuisineName = 'American'), 
    (select u.UserId from users u where u.FirstName = 'Sarah' and u.LastName = 'Cohen'),
    'Potatoes', 37, '02-14-2024', '04-15-2024', null
union select (select CuisineId from Cuisine c where c.CuisineName = 'American'), 
    (select u.UserId from users u where u.FirstName = 'Sarah' and u.LastName = 'Cohen'),
    'Green Beans', 20, '02-14-2012', null, null

select * from recipe 
select * from Cuisine 
select * from Users
