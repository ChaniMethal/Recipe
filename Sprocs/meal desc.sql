create or alter function dbo.MealDesc(@MealId int)
returns varchar(75)
as 
begin 
    declare @value VARCHAR(75) = ''

    select @value = concat(m.MealName, ' (', sum(r.Calories), ' Calories', ')')
    from Meal m 
    join MealCourse mc
    on m.MealId = mc.MealId
    join MealCourseRecipe mcr
    on mcr.MealCourseId = mc.MealCourseId
    join Recipe r 
    on mcr.RecipeId = r.RecipeId
    where m.MealId = @MealId
    group by m.MealName

    return @value
end 
go 
select MealDesc = dbo.MealDesc(m.MealId),*
from Meal m