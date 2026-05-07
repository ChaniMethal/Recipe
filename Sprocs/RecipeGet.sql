create or alter procedure dbo.RecipeGet(
    @RecipeId int = 0, 
    @RecipeName varchar(100) = ' ', 
    @All bit = 0
)
as
begin
    select r.RecipeId, r.RecipeName, r.CuisineId, r.UserId, r.Calories, r.DateCreated, r.DatePublished, r.DateArchived, r.RecipeStatus
    from Recipe r 
    where r.RecipeId = @RecipeId
    or @All = 1
    or (@RecipeName <> '' and r.RecipeName like '%' + @RecipeName + '%')
    order by r.RecipeId
end
go

exec RecipeGet 

exec RecipeGet @All = 1

exec RecipeGet @RecipeName = ' '

exec RecipeGet @RecipeName = null

exec RecipeGet @RecipeName = 'r'

declare @RecipeId int

select top 1 @RecipeId = r.RecipeId from recipe r 

exec RecipeGet @RecipeId = @RecipeId
