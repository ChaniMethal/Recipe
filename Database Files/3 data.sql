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

insert Ingredient(IngredientName)
select 'Sugar'
union select 'Oil'
union select 'Egg'
union select 'Eggs'
union select 'Flour'
union select 'Vanilla Sugar'
union select 'Baking Powder'
union select 'Baking Soda'
union select 'Chocolate Chips'
union select 'Granny Smith Apples'
union select 'Vanilla Yogurt'
union select 'Orange Juice'
union select 'Honey'
union select 'Ice Cubes'
union select 'Club Bread'
union select 'Butter'
union select 'Shredded Cheese'
union select 'Cloves Garlic (Crushed)'
union select 'Black Pepper'
union select 'Salt'
union select 'Vanilla Pudding'
union select 'Whipped Cream Cheese'
union select 'Sour Cream Cheese'
union select 'Water'
union select 'Pizza Sauce'
union select 'Chicken'
union select 'Duck Sauce'
union select 'Onion Soup Mix'
union select 'Green Beans'
union select 'Potatoes'
union select 'Frozen French Fries'
union select 'Ice Cream'
union select 'Milk'

insert MeasurementType(MeasurementType)
select 'cup'
union select 'cups'
union select 'tsp'
union select 'tbsp'
union select 'a pinch'
union select 'stick'
union select 'oz'
union select 'thighs'
union select 'drizzle'
union select 'scoops'
union select 'bag'

insert IngredientDesc(RecipeId, IngredientId, IngredientSequence, MeasurementQuantity, MeasurementTypeId)
select (select r.RecipeId from recipe r where r.RecipeName = 'Chocolate Chip Cookies'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Sugar'),
    1, 1, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'cup')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Chocolate Chip Cookies'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Oil'),
    2, 0.5, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'cups')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Chocolate Chip Cookies'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Eggs'),
    3, 3, null
union select (select r.RecipeId from recipe r where r.RecipeName = 'Chocolate Chip Cookies'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Flour'),
    4, 2, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'cups')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Chocolate Chip Cookies'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Vanilla Sugar'),
    5, 0.5, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'tsp')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Chocolate Chip Cookies'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Baking Powder'),
    6, 2, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'tsp')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Chocolate Chip Cookies'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Baking Soda'),
    7, 0.5, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'tsp')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Chocolate Chip Cookies'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Chocolate Chips'),
    8, 1, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'cup')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Apple Yogurt Smoothie'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Granny Smith Apples'),
    1, 3, null 
union select (select r.RecipeId from recipe r where r.RecipeName = 'Apple Yogurt Smoothie'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Vanilla Yogurt'),
    2, 2, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'cups') 
union select (select r.RecipeId from recipe r where r.RecipeName = 'Apple Yogurt Smoothie'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Sugar'),
    3, 2, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'tsp')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Apple Yogurt Smoothie'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Orange Juice'),
    4, 0.5, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'cup')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Apple Yogurt Smoothie'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Honey'),
    5, 2, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'tbsp')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Apple Yogurt Smoothie'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Ice Cubes'),
    6, 6, null
union select (select r.RecipeId from recipe r where r.RecipeName = 'Cheese Bread'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Club Bread'),
    1, 1, null
union select (select r.RecipeId from recipe r where r.RecipeName = 'Cheese Bread'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Butter'),
    2, 4, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'oz')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Cheese Bread'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Shredded Cheese'),
    3, 8, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'oz')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Cheese Bread'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Cloves Garlic (crushed)'),
    4, 2, null
union select (select r.RecipeId from recipe r where r.RecipeName = 'Cheese Bread'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Black Pepper'),
    5, 0.25, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'tsp')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Cheese Bread'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Salt'),
    6, null, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'a pinch')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Butter Muffins'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Butter'),
    1, 1, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'stick')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Butter Muffins'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Sugar'),
    2, 3, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'cups')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Butter Muffins'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Vanilla Pudding'),
    3, 2, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'tbsp')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Butter Muffins'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Eggs'),
    4, 4, null
union select (select r.RecipeId from recipe r where r.RecipeName = 'Butter Muffins'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Whipped Cream Cheese'),
    5, 8, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'oz')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Butter Muffins'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Sour Cream Cheese'),
    6, 8, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'oz')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Butter Muffins'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Flour'),
    7, 1, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'Cup')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Butter Muffins'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Baking Powder'),
    8, 2, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'tsp')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Pizza'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Flour'),
    1, 1, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'cup')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Pizza'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Water'),
    2, 0.5, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'cup')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Pizza'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Pizza Sauce'),
    3, 0.5, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'cup') 
union select (select r.RecipeId from recipe r where r.RecipeName = 'Pizza'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Shredded Cheese'),
    4, 8, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'oz')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Fries'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Frozen French Fries'),
    1, 1, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'bag')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Fries'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Oil'),
    2, 1, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'Drizzle')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Fries'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Salt'),
    3, 1, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'tbsp')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Milk Shake'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Ice Cream'),
    1, 6, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'scoops')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Milk Shake'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Milk'),
    2, 2, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'cups')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Chicken'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Chicken'),
    1, 4, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'thighs')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Chicken'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Duck Sauce'),
    2, 1.5, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'cups')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Green Beans'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Green Beans'),
    1, 4, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'cups')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Green Beans'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Oil'),
    2, 1, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'Drizzle')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Green Beans'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Salt'),
    3, 1, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'tbsp')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Potatoes'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Potatoes'),
    1, 5, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'cups')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Potatoes'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Oil'),
    2, 1, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'Drizzle')
union select (select r.RecipeId from recipe r where r.RecipeName = 'Potatoes'),
    (select i.IngredientId from ingredient i where i.IngredientName = 'Onion Soup Mix'),
    3, 3, (select mt.MeasurementTypeId from MeasurementType mt where mt.MeasurementType = 'tbsp')



insert PrepSteps(RecipeId, StepSequence, StepDesc)
select (select r.RecipeId from recipe r where r.RecipeName = 'Chocolate Chip Cookies'), 1, 
    'combine sugar, oil and eggs in a bowl'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Chocolate Chip Cookies'), 2, 
    'mix well'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Chocolate Chip Cookies'), 3, 
    'add flour, vanilla sugar, baking powder and baking soda'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Chocolate Chip Cookies'), 4, 
    'beat for 5 minutes'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Chocolate Chip Cookies'), 5, 
    'add chocolate chips'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Chocolate Chip Cookies'), 6, 
    'freeze for 1-2 hours'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Chocolate Chip Cookies'), 7, 
    'roll into balls and place spread out on a cookie sheet'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Chocolate Chip Cookies'), 8, 
    'bake on 350 for 10 mi'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Apple Yogurt Smoothie'), 1, 
    'Peel the apples and dice'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Apple Yogurt Smoothie'), 2, 
    'Combine all ingredients in bowl except for apples and ice cubes'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Apple Yogurt Smoothie'), 3,
    'mix until smooth'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Apple Yogurt Smoothie'), 4,
    'add apples and ice cubes'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Apple Yogurt Smoothie'), 5,
    'pour into glasses'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Cheese Bread'), 1,
    'slit every bread 3/4 inch'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Cheese Bread'), 2,
    'Combine all ingredients in bowl'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Cheese Bread'), 3,
    'fill slits with cheese mixture'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Cheese Bread'), 4,
    'wrap bread into a foil and bake for 30 minutes'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Butter Muffins'), 1,
    'Cream butter with sugars'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Butter Muffins'), 2,
    'Add eggs and mix well'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Butter Muffins'), 3,
    'Slowly add rest of ingredients and mix well'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Butter Muffins'), 4,
    'fill muffin pans 3/4 full and bake for 30 minutes'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Pizza'), 1,
    'mix flour an water until it forms a dough'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Pizza'), 2,
    'kneed 3-4 minutes'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Pizza'), 3,
    'roll and out put on pizza sauce and then add cheese' 
union select (select r.RecipeId from recipe r where r.RecipeName = 'Pizza'), 4,
    'bake on 450 degrees for 12 minutes' 
union select (select r.RecipeId from recipe r where r.RecipeName = 'Fries'), 1,
    'pour bag on a baking tray' 
union select (select r.RecipeId from recipe r where r.RecipeName = 'Fries'), 2,
    'drizzle oil' 
union select (select r.RecipeId from recipe r where r.RecipeName = 'Fries'), 3,
    'evenly pour salt'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Fries'), 4,
    'bake 450 degrees for 12 minutes'  
union select (select r.RecipeId from recipe r where r.RecipeName = 'Milk Shake'), 1,
    'scoop ice cream into blender'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Milk Shake'), 2,
    'pour milk'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Milk Shake'), 3,
    'blend until desired consistency'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Chicken'), 1,
    'place chicken in pan'   
union select (select r.RecipeId from recipe r where r.RecipeName = 'Chicken'), 2,
    'add duck sauce'  
union select (select r.RecipeId from recipe r where r.RecipeName = 'Chicken'), 3,
    'bake on 350 degrees for an hour and a half'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Green Beans'), 1,
    'place green beans in pan'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Green Beans'), 2,
    'drizzle oil evenly on fries'   
union select (select r.RecipeId from recipe r where r.RecipeName = 'Green Beans'), 3,
    'add salt evenly' 
union select (select r.RecipeId from recipe r where r.RecipeName = 'Green Beans'), 4,
    'bake on 350 degrees for 25 minutes' 
union select (select r.RecipeId from recipe r where r.RecipeName = 'Potatoes'), 1,
    'place potatoes in pan'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Potatoes'), 2,
    'drizzle oil evenly' 
union select (select r.RecipeId from recipe r where r.RecipeName = 'Potatoes'), 3,
    'add onion soup mix evenly'
union select (select r.RecipeId from recipe r where r.RecipeName = 'Potatoes'), 4,
    'bake on 350 degrees for 45 minutes'  

Insert Meal(MealName, Active, DateCreated, UserId)
Select 'Breakfast Bash', 1, '10-29-2023', (select u.UserId from Users u where u.FirstName = 'Rivka' and u.LastName = 'Stein')
union select 'Scrumptious Lunch', 1, '12-03-2024', (select u.UserId from Users u where u.FirstName = 'Rivka' and u.LastName = 'Stein')
union select 'Hearty Dinner', 1, '01-01-2021', (select u.UserId from Users u where u.FirstName = 'Aaron' and u.LastName = 'Weiss')

Insert Course(CourseName, CourseSequence)
select 'Appetizer', 1
union select 'Drink', 1
union select 'Main', 2
union select 'Dessert', 3

;
with x as(
    Select MealName = 'Breakfast Bash', CourseName = 'Drink'
    union select 'Breakfast Bash', 'Main'
    union select 'Breakfast Bash', 'Dessert'
    union select 'Scrumptious Lunch', 'Main'
    union select 'Scrumptious Lunch', 'Main'
    union select 'Scrumptious Lunch', 'Drink'
    union select 'Hearty Dinner', 'Main'
    union select 'Hearty Dinner', 'Main'
)
insert MealCourse(MealId, CourseId)
select m.MealId, c.CourseId
from x
join Meal m  
on m.MealName = x.MealName
join Course c 
on c.CourseName = x.CourseName

;
with x as(
    Select MealName = 'Breakfast Bash', CourseName = 'Drink', RecipeName = 'Apple Yogurt Smoothie', IsMainDish = 0
    union select 'Breakfast Bash', 'Main', 'Cheese Bread', 1
    union select 'Breakfast Bash', 'Dessert', 'Butter Muffins', 0
    union select 'Scrumptious Lunch', 'Main', 'Pizza', 1
    union select 'Scrumptious Lunch', 'Main', 'Fries', 0
    union select 'Scrumptious Lunch', 'Drink', 'Milk Shake', 0
    union select 'Hearty Dinner', 'Main', 'Chicken', 1
    union select 'Hearty Dinner', 'Main', 'Potatoes', 0
    union select 'Hearty Dinner', 'Main', 'Green Beans', 0
)
insert MealCourseRecipe(MealCourseId, RecipeId, IsMainDish)
select mc.MealCourseId, r.RecipeId, x.IsMainDish
from x
join Meal m  
on m.MealName = x.MealName
join Course c 
on c.CourseName = x.CourseName
join Recipe r 
on r.RecipeName = x.RecipeName
join MealCourse mc 
on m.MealId = mc.MealId 
and c.CourseId = mc.CourseId

Insert CookBook(CookBookName, UserId, DateCreated, Price, Active)
Select 'Sweet & Simple Desserts', (select u.UserId from Users u where u.FirstName = 'Sarah' and u.LastName = 'Cohen'), '2024-01-10', 12.99, 1
union select 'Family Weeknight Meals', (select u.UserId from Users u where u.FirstName = 'Dovid' and u.LastName = 'Levy'), '2023-11-05', 18.50, 1
union select 'Budget 5-Ingredient Recipes', (select u.UserId from Users u where u.FirstName = 'Miriam' and u.LastName = 'Adler'), '2024-03-22', 9.99, 1
union select 'Healthy Lunch Prep', (select u.UserId from Users u where u.FirstName = 'Yaakov' and u.LastName = 'Friedman'), '2023-09-14', 14.25, 1
union select 'Shabbos Favorites', (select u.UserId from Users u where u.FirstName = 'Rivka' and u.LastName = 'Stein'), '2024-05-01', 22.00, 1
union select 'One-Pot Comfort Foods', (select u.UserId from Users u where u.FirstName = 'Aaron' and u.LastName = 'Weiss'), '2024-02-19', 16.75, 1
union select 'Kids Snack Ideas', (select u.UserId from Users u where u.FirstName = 'Sarah' and u.LastName = 'Cohen'), '2023-12-30', 7.50, 1
union select 'Treats for two', (select u.UserId from Users u where u.FirstName = 'Aaron' and u.LastName = 'Weiss'), '2024-07-11', 30, 0

;
with x as (
    Select CookBookName = 'Treats for two', RecipeName = 'Chocolate Chip Cookies', Sequence = 8
    union select 'Family Weeknight Meals', 'Chicken', 1
    union select 'Budget 5-Ingredient Recipes', 'Pizza', 3
    union select 'Treats for two', 'Apple Yogurt Smoothie', 4
    union select 'Shabbos Favorites', 'Potatoes', 6
    union select 'One-Pot Comfort Foods', 'Green Beans', 7
    union select 'Treats for two', 'Butter Muffins', 5
    union select 'Treats for two', 'Cheese Bread', 2
    union select 'Kids Snack Ideas', 'Fries', 9
    union select 'Sweet & Simple Desserts', 'Milk Shake', 10
)
Insert CookBookRecipe(CookBookId, RecipeId, Sequence)
Select cb.CookBookId, r.RecipeId, x.Sequence
from x 
join CookBook cb 
on x.CookBookName = cb.CookBookName
join recipe r 
on r.RecipeName = x.RecipeName

select * from CookBookRecipe
select * from CookBook
select * from MealCourseRecipe
select * from MealCourse
select * from Course
select * from Meal
select * from Meal
select * from PrepSteps
select * from IngredientDesc
select * from MeasurementType
select * from ingredient
select * from recipe 
select * from Cuisine 
select * from Users

 