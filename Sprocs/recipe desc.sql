create or alter function dbo.RecipeDesc(@RecipeId int)
returns varchar(250)
as 
begin 
    declare @value varchar(250) = ''

    select @value = CONCAT(r.RecipeName, ' (', c.CuisineName, ') has ', count(i.IngredientId), ' ingredients and ', count(p.PrepStepsId), ' steps.' )
    from recipe r 
    left join Cuisine c 
    on c.CuisineId = r.CuisineId
    left join IngredientDesc i 
    on i.RecipeId = r.RecipeId 
    left join PrepSteps p
    on p.RecipeId = r.RecipeId
    where r.RecipeId = @RecipeId
    group by r.RecipeName, c.CuisineName, i.IngredientId, p.PrepStepsId

    return @value
end 
go
select RecipeDesc = dbo.RecipeDesc(r.RecipeId),*
from Recipe r 