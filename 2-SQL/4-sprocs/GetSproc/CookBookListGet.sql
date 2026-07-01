create or alter procedure dbo.CookBookListGet(
    @CookBookId int = 0,
    @CookBookName varchar(200) = '',
    @All bit = 0
)
as 
begin 
    select c.CookBookId, c.CookBookName, Author = CONCAT(u.FirstName, ' ', u.LastName), NumRecipes = COUNT(cr.RecipeId), c.Price
    from CookBook c 
    join Users u 
        on u.UserId = c.UserId
    join CookBookRecipe cr 
        on cr.CookBookId = c.CookBookId
        where c.CookBookId = @CookBookId
        or @All = 1
    group by c.CookBookId, c.CookBookName, u.FirstName, u.LastName, c.Price
    order by c.CookBookName
end 
go 

exec CookbookListGet @All = 1