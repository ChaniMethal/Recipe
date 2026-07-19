create or alter procedure dbo.MealListGet(
    @MealId int = 0,
    @MealName varchar(100) = '',
    @All bit = 0
)
as 
begin 
    select m.MealName, UserName = CONCAT(u.FirstName, ' ', u.LastName), NumCalories = SUM(r.Calories), NumCourses = COUNT(mc.CourseId), NumRecipes = COUNT(mcr.RecipeId)
    from Meal m 
    join Users u 
        on u.UserId = m.UserId
    left join MealCourse mc 
        on mc.MealId = m.MealId
    left join MealCourseRecipe mcr 
        on mcr.MealCourseId = mc.MealCourseId
    left join Recipe r 
        on r.RecipeId = mcr.RecipeId
    where m.MealId = @MealId
    or @All = 1
    group by m.MealId, m.MealName, u.FirstName, u.LastName
    order by m.MealName
end 
go 

exec MealListGet @All = 1
