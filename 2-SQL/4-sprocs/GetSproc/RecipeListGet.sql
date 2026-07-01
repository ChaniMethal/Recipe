create or alter procedure dbo.RecipeListGet(
    @RecipeId int = 0, 
    @RecipeName varchar(100) = '', 
    @All bit = 0
)
as
begin
    select r.RecipeId, r.RecipeName, r.RecipeStatus, UserName = CONCAT(u.FirstName, ' ', u.LastName), r.Calories, IngredientCount = COUNT(id.IngredientId)
    from Recipe r
    join IngredientDesc id
        on id.RecipeId = r.RecipeId
    join Ingredient i 
        on i.IngredientId = id.IngredientId
    join Users u
        on u.UserId = r.UserId
where 
        r.RecipeId = @RecipeId
        or @All = 1
        or (@RecipeName <> '' and r.RecipeName like '%' + @RecipeName + '%')
group by r.RecipeId, r.RecipeName, r.RecipeStatus, u.FirstName, u.LastName, r.Calories
order by 
    case r.RecipeStatus
        when 'Published' then 1
        when 'Draft' then 2
        when 'Archived' then 3
        else 4
    end,
    r.RecipeName
    
end
go