--Note: some of these scripts are needed for specific items, when the instructions say "specific" pick one item in your data and specify it in the where clause using a unique value that identifies it, do not use the primary key.

--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.

delete id
from IngredientDesc id 
join Recipe r 
on r.RecipeId = id.RecipeId
join Users u 
on u.UserId = r.UserId
where u.FirstName = 'Sarah'
and u.LastName = 'Cohen'

delete ps
from PrepSteps ps 
join Recipe r 
on r.RecipeId = ps.RecipeId
join Users u 
on u.UserId = r.UserId
where u.FirstName = 'Sarah'
and u.LastName = 'Cohen'

delete mcr
from MealCourseRecipe mcr 
join MealCourse mc
on mc.MealCourseId = mcr.MealCourseId
join Meal m 
on m.MealId = mc.MealId
join Users u 
on u.UserId = m.UserId
where u.FirstName = 'Sarah'
and u.LastName = 'Cohen'

delete mcr
from MealCourseRecipe mcr 
join Recipe r 
on r.RecipeId = mcr.RecipeId
join Users u 
on u.UserId = r.UserId
where u.FirstName = 'Sarah'
and u.LastName = 'Cohen'

delete mc 
from MealCourse mc 
join Meal m 
on m.MealId = mc.MealId
join Users u 
on u.UserId = m.UserId
where u.FirstName = 'Sarah'
and u.LastName = 'Cohen'


delete cbr
from CookBookRecipe cbr 
join CookBook cb 
on cb.CookBookId = cbr.CookBookId
join Users u 
on u.UserId = cb.UserId
where u.FirstName = 'Sarah'
and u.LastName = 'Cohen'

delete cbr
from CookBookRecipe cbr 
join Recipe r 
on cbr.RecipeId = r.RecipeId
join Users u 
on u.UserId = r.UserId
where u.FirstName = 'Sarah'
and u.LastName = 'Cohen'

delete cb
from CookBook cb 
join Users u 
on u.UserId = cb.UserId
where u.FirstName = 'Sarah'
and u.LastName = 'Cohen'

delete m 
from Meal m 
join Users u 
on u.UserId = m.UserId
where u.FirstName = 'Sarah'
and u.LastName = 'Cohen'


delete r 
from Recipe r 
join Users u 
on u.UserId = r.UserId
where u.FirstName = 'Sarah'
and u.LastName = 'Cohen'

delete u 
from Users u 
where u.FirstName = 'Sarah'
and u.LastName = 'Cohen'
--2) Sometimes we want to clone a recipe as a starting point and then edit it. 
--For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name.
insert Recipe(CuisineId, UserId, RecipeName, Calories, DateCreated, DatePublished, DateArchived)
select r.CuisineId, r.UserId, r.RecipeName + ' - clone', r.Calories, r.DateCreated, r.DatePublished, r.DateArchived
from recipe r 
where r.RecipeName = 'Pizza'

insert IngredientDesc(RecipeId, IngredientId, IngredientSequence, MeasurementQuantity, MeasurementTypeId)
select (select r.RecipeId from Recipe r where r.RecipeName = 'Pizza - clone'), id.IngredientId, id.IngredientSequence, id.MeasurementQuantity, id.MeasurementTypeId
from IngredientDesc id 
where id.RecipeId = (select r.RecipeId from Recipe r where r.RecipeName = 'Pizza')
/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name.

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted

*/
insert CookBook(CookBookName, UserId, DateCreated, Price, Active)
select concat('Recipes by ', u.FirstName , ' ', u.LastName), 
    (select u.UserId from users u where u.FirstName = 'Yaakov' and u.LastName = 'Friedman'),
    GETDATE(), (COUNT(r.RecipeId) * 1.33), 1
from Recipe r 
join Users u 
on u.UserId  = r.UserId
where u.FirstName = 'Yaakov' and u.LastName = 'Friedman'
group by u.UserId,u.FirstName, u.LastName

;with x as( 
	select u.UserId, cb.CookBookId
	from Users u 
	join cookbook cb 
	on cb.userId = u.UserID
	where u.FirstName = 'Yaakov' and u.LastName = 'Friedman'
	and cb.CookBookName = concat('Recipes by ', u.FirstName , ' ', u.LastName)
)
insert CookBookRecipe(CookBookId, RecipeId, Sequence)
select  x.CookBookId, r.RecipeId, (ROW_NUMBER() over (order by r.RecipeName))
from Recipe r 
join x 
on x.UserId = r.UserId

/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count for butter went down by 2 per ounce, and 10 per stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/
update r 
set r.Calories = (
	r.Calories + case 
		when mt.MeasurementType = 'oz' then -2 * id.MeasurementQuantity
		when mt.MeasurementType = 'stick' then -10 * id.MeasurementQuantity
	end
)
from recipe r 
join IngredientDesc id 
on id.RecipeId = r.RecipeId
join Ingredient i 
on i.IngredientId = id.IngredientId
join MeasurementType mt 
on mt.MeasurementTypeId = id.MeasurementTypeId
where i.IngredientName = 'Butter'

/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
;
with x as(
	select AvgPublishTime =  AVG(datediff(hour,r.DateCreated, r.DatePublished))
	from Recipe r 
	where r.DatePublished is not null
)
select u.FirstName, u.LastName, 
	Email = CONCAT(left(u.FirstName,1), u.LastName, '@heartyhearth.com'),
	Alert = CONCAT('Your recipe ', r.RecipeName, ' is sitting in draft for ', datediff(hour,r.DateCreated, GETDATE()), 
	' hours. That is ', (datediff(hour,r.DateCreated, GETDATE()) - x.AvgPublishTime), ' hours more than the average ', x.AvgPublishTime, 
	' hours all other recipes took to be published.' )
from Recipe r 
join users u 
on u.UserId = r.UserId
cross join x 
where r.RecipeStatus = 'draft'
and datediff(hour,r.DateCreated, GETDATE()) > x.AvgPublishTime

/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and receive a 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/
;
with x as(
	select AmountOfCookBooks = COUNT(cb.CookBookId), AvgPrice = AVG(cb.Price), TotalAfterDiscount = (SUM(cb.Price) * .75)
	from CookBook cb 
)
select EmailBody = CONCAT('Order cookbooks from HeartyHearth.com! We have ', x.AmountOfCookBooks, 
' books for sale, average price is $', x.AvgPrice, '. You can order them all and receive a 25% discount, for a total of', x.TotalAfterDiscount, 
'. Click <a href = "www.heartyhearth.com/order/', newid(),  '>here</a> to order.')
from x 