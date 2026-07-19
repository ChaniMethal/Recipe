create or alter procedure dbo.RecipeGet(
    @RecipeId int = 0, 
    @RecipeName varchar(100) = '', 
    @All bit = 0
)
as
begin
    if @RecipeId > 0
        or (@All = 0 and @RecipeName = '')
    begin
        select r.RecipeId, r.RecipeName, r.CuisineId, c.CuisineName, r.UserId, u.UserName, r.Calories, r.DateCreated, r.DatePublished, r.DateArchived, r.RecipeStatus, RecipeDesc = dbo.RecipeDesc(r.RecipeId)
        from Recipe r
        join Cuisine c
            on c.CuisineId = r.CuisineId
        join Users u
            on u.UserId = r.UserId
        where r.RecipeId = @RecipeId;
    end
    else
    begin
        select  r.RecipeId, r.RecipeName, r.RecipeStatus, u.UserName, r.Calories, IngredientCount = count(id.IngredientId)
        from Recipe r
        join Users u
            on u.UserId = r.UserId
        left join IngredientDesc id
            on id.RecipeId = r.RecipeId
        where @All = 1
           or (
                @RecipeName <> ''
                and r.RecipeName like '%' + @RecipeName + '%'
           )
        group by r.RecipeId, r.RecipeName, r.RecipeStatus, u.UserName, r.Calories
        order by
            case r.RecipeStatus
                when 'Published' then 1
                when 'Draft' then 2
                when 'Archived' then 3
                else 4
            end,
            r.RecipeName;
    end
end
go