use RecipeDB
go
drop table if exists CookBookRecipe
drop table if exists CookBook
drop table if exists MealCourseRecipe
drop table if exists MealCourse
drop table if exists Course
drop table if exists Meal
drop table if exists PrepSteps
drop table if exists IngredientDesc
drop table if exists MeasurementType
drop table if exists Ingredient
drop table if exists Recipe
drop table if exists Cuisine
drop table if exists Users
go 
create table dbo.Users(
    UserId int not null identity primary key,
    FirstName varchar(50) not null constraint ck_Users_First_Name_is_not_blank check(FirstName <>''),
    LastName varchar(50) not null constraint ck_Users_Last_Name_is_not_blank check(LastName <> ''),
    UserName as concat(lower(FirstName), '.', lower(LastName)) persisted
        constraint u_Users_Name unique
)
go
create table dbo.Cuisine(
    CuisineId int not null identity primary key,
    CuisineName varchar(50) not null
        constraint u_Cuisine_Name unique 
        constraint ck_Cuisine_Name_is_not_blank check(CuisineName <> '')
)
go
create table dbo.Recipe(
    RecipeId int not null identity primary key,
    CuisineId int not null constraint f_Cuisine_Recipe foreign key references Cuisine(CuisineId),
    UserId int not null constraint f_Users_Recipe foreign key references Users(UserId),
    RecipeName varchar(100) not null
        constraint u_Recipe_Name UNIQUE
        constraint ck_Recipe_Name_is_not_blank check(RecipeName <>''),
    Calories int not null constraint ck_Recipe_Calories_greater_than_zero check(Calories > 0),
    DateCreated datetime not null constraint ck_Recipe_Date_Created_valid 
        check(DateCreated between '12-09-2003' and GETDATE()),
    DatePublished datetime null constraint ck_Recipe_Date_Published_before_current_date check(DatePublished < GETDATE()),
    DateArchived datetime null constraint ck_Recipe_Date_Archived_before_current_date check(DateArchived < GETDATE()),
    RecipeStatus as 
        CASE
            When DateArchived is not null then 'archived'
            When DatePublished is not null then 'published'
        else 'draft'
        end,
    RecipePicture as concat('Recipe_', REPLACE(RecipeName, ' ', '_'), '.jpg') persisted,
    constraint ck_Recipe_Date_Published_after_Date_Created check(DatePublished > DateCreated),
    constraint ck_Recipe_Date_Archived_after_Date_Created check(DateArchived > DateCreated),
    constraint ck_Recipe_Date_Archived_after_Date_Published check(DateArchived > DatePublished)
)
GO
create table dbo.Ingredient(
    IngredientId int not null identity primary key,
    IngredientName varchar(100) not null 
        constraint u_Ingredient_Name unique 
        constraint ck_Ingredient_Name_is_not_blank check(IngredientName <>''),
    IngredientPicture as concat('Ingredient_', REPLACE(IngredientName, ' ', '_'), '.jpg') persisted
)
go
create table dbo.MeasurementType(
    MeasurementTypeId int not null identity primary key,
    MeasurementType varchar(100)
        constraint u_Measurement_Type unique 
        constraint ck_Measurement_Type_is_not_blank check(MeasurementType <>'')
)
go
create table dbo.IngredientDesc(
    IngredientDescId int not null identity primary key,
    RecipeId int not null constraint f_IngredientDesc_Recipe foreign key references Recipe(RecipeId),
    IngredientId int not null constraint f_IngredientDesc_Ingredient foreign key references Ingredient(IngredientId),
    IngredientSequence int not null constraint ck_IngredientDesc_IngredientSequence_greater_then_zero check(IngredientSequence > 0),
    MeasurementQuantity decimal(6,2) null constraint ck_IngredientDesc_MeasurementQuantity_is_positive check(MeasurementQuantity > 0),
    MeasurementTypeId int null constraint f_IngredientDesc_MeasurementType foreign key references MeasurementType(MeasurementTypeId),
    constraint u_IngredientId_RecipeId unique (IngredientId, RecipeId)
)
go
create table dbo.PrepSteps(
    PrepStepsId int not null identity primary key,
    RecipeId int not null constraint f_Recipe_PrepSteps foreign key references Recipe(RecipeId),
    StepSequence int not null constraint ck_PrepSteps_StepSequence_greater_then_zero check(StepSequence > 0),
    StepDesc varchar(500) not null 
        constraint ck_PrepSteps_StepDesc_not_blank check(StepDesc <>'')
        constraint u_RecipeId_StepDesc unique(RecipeId, StepDesc)
)
go
create table dbo.Meal(
    MealId int not null identity primary key,
    MealName varchar (100) not null 
        constraint u_Meal_MealName unique 
        constraint ck_Meal_MealName_not_blank check(MealName <>''),
    MealPicture as concat('Meal_', REPLACE(MealName, ' ', '_'), '.jpg') persisted,
    Active bit not null,
    DateCreated date not null constraint ck_Meal_DateCreated_valid check(DateCreated between '12-09-2003' and GETDATE()),
    UserId int not null constraint f_Meal_User foreign key references Users(UserID)
)
go
create table dbo.Course(
    CourseId int not null identity primary key,
    CourseName varchar(100) not null constraint ck_Course_Name_valid check(CourseName in ('Appetizer', 'Main', 'Side', 'Dessert', 'Drink')),
    CourseSequence int not null constraint ck_Course_Sequence_greater_then_zero check(CourseSequence > 0),
    
)
create table dbo.MealCourse(
    MealCourseId int not null identity primary key,
    MealId int not null constraint f_Meal_MealCourse foreign key references Meal(MealId),
    CourseId int not null constraint f_Course_MealCourse foreign key references Course(CourseId),
    constraint u_MealId_CourseId unique (MealId, CourseId)
)
go
create table dbo.MealCourseRecipe(
    MealCourseRecipeId int not null identity primary key,
    RecipeId int not null constraint f_Recipe_MealCourseRecipe foreign key references Recipe(RecipeId),
    MealCourseId int not null constraint f_MealCourse_MealCourseRecipe foreign key references MealCourse(MealCourseId),
    IsMainDish bit not null constraint df_Course_IsMainDish_default_0 default(0)
    constraint u_RecipeId_MealCourseId unique(RecipeId, MealCourseId)

)
create table dbo.CookBook(
    CookBookId int not null identity primary key,
    CookBookName varchar(100) not null constraint ck_CookBook_Name unique,
    UserId int not null constraint f_Users_CookBook foreign key references Users(UserId),
    DateCreated date not null constraint ck_CookBook_DateCreated_valid
        check(DateCreated between '12-09-2003' and GETDATE()),
    Price decimal(6,2) not null constraint ck_CookBook_Price_greater_then_0 check(Price > 0),
    Active bit not null,
    CookBookPicture as concat('CookBook_', REPLACE(CookBookName, ' ', '_'), '.jpg') persisted
)
go
create table dbo.CookBookRecipe(
    CookBookRecipeId int not null identity primary key,
    CookBookId int not null constraint f_CookBook_CookBookRecipe foreign key references CookBook(CookBookId),
    RecipeId int not null constraint f_Recipe_CookBookRecipe foreign key references Recipe(RecipeId),
    Sequence int not null constraint ck_CookBookRecipe_Sequence_greater_then_0 check(Sequence > 0),
    constraint u_CookBookId_RecipeId unique (CookBookId, RecipeId)
)
go
