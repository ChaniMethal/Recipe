create or alter function dbo.RecipeDesc(@RecipeId int)
returns varchar(250)
as 
begin 
    declare @value varchar(250) = ''

    select @value = concat(r.RecipeName, ' (', c.CuisineName, ') has ', count(distinct i.IngredientId),' ingredients and ',
        count(distinct p.PrepStepsId),' steps.')
    from Recipe r 
    left join Cuisine c 
        on c.CuisineId = r.CuisineId
    left join IngredientDesc i 
        on i.RecipeId = r.RecipeId 
    left join PrepSteps p
        on p.RecipeId = r.RecipeId
    where r.RecipeId = @RecipeId
    group by r.RecipeId, r.RecipeName, c.CuisineName

    return @value
end 
go

select RecipeDesc = dbo.RecipeDesc(r.RecipeId), *
from Recipe r
