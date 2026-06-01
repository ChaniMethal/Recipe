/*
Users
-UserID primary key
-FirstName varchar (50) not blank
-LastName varchar (50) not blank
-UserName unique not blank

Cuisine
-CuisineId primary key
-CuisineName varchar(50) unique, not blank

Recipe
-RecipeId primary key
-RecipeName varchar(100) unique not blank
-CuisineId fk
-Calories int greater then 0
-DateCreated date time not null after date creation of website, before current date
-DatePublished date time null before current date, after datecreated
-DateArchived date time null before current date, afterdatecreated/datepublished
-RecipeStatus as
    Case
        When DateArchived is not null then 'archived'
        When DatePublished is not null then 'published'
    else 'draft'
-UserId foreign key references
-RecipePicture concat('Recipe_', RecipeName, '.jpg) persisted


Ingredient
-IngredientId primary key
-IngredientName varchar (100) unique, not blank
-IngredientPicture concat('Ingredient_', IngredientName, '.jpg) persisted

MeasurementType
-MeasurementTypeId primary key
-MeasurementType varchar (100) unique, not blank

IngredientDesc
-IngredientDescId primary key
-RecipeId fk
-IngredientId fk
-Sequence int, greater than zero
-MeasurementQuantity decimal 
-MeasurementTypeId fk
-constraint, ingredient and recipe is unique

PrepSteps
-PrepStepsId primary key
-RecipeId fk
-StepSequence int,greater than zero
-StepDesc varchar (500) unique, not blank


Meals
-MealId primary key
-MealName varchar(100)unique and not blank
-MealPicture concat('Meal_', MealName, '.jpg) persisted
-Active bit
-DateCreated date, after date created of website, before current date
-UserId

Course
-CourseId primary key
-CourseName unique
-CourseOrder 
-Description varchar(200)
-CourseType varchar(50) in ('Appetizer', 'Main', 'Desset')
-IsMainDish bit (rest 0)

MealCourse
-MealCourseId primary key
-MealId fk
-CourseId fk
- unique meal, course

MealCourseRecipe
-MealCourseRecipeId prmary key
-RecipeId fk
-MealCourse fk 
-Sequence int

CookBook
-CookBookId primary key
-CookBookName varchar (100)
-UserId fk
-DateCreated date, after creation of website and before the current date
-Price decimal(6,2) greater then 0
-Active bit
-CookBookPicture concat('CookBook_', CookBookName, '.jpg) persisted

CookBookRecipe
-CookBookRecipeId primary key
-CookBookId fk
-RecipeId fk
-Sequence int
- CookbookId and recipeid unique s



