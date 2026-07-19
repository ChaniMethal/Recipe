create or alter procedure dbo.CookBookGet(
    @CookBookId int = 0,
    @CookBookName varchar(100) = '',
    @All bit = 0
)
as
begin
    if @All = 1
    begin
        select cb.CookBookId, cb.CookBookName, Author = concat(u.FirstName, ' ', u.LastName), NumRecipes = count(cbr.RecipeId), cb.Price
        from CookBook cb
        join Users u
            on u.UserId = cb.UserId
        left join CookBookRecipe cbr
            on cbr.CookBookId = cb.CookBookId
        group by cb.CookBookId, cb.CookBookName, u.FirstName, u.LastName, cb.Price
        order by cb.CookBookName;
    end
    else
    begin
        select cb.CookBookId, cb.CookBookName, cb.UserId, cb.Price, cb.DateCreated, cb.Active
        from CookBook cb
        where cb.CookBookId = @CookBookId
           or (
                @CookBookName <> ''
                and cb.CookBookName like '%' + @CookBookName + '%'
           )
        order by cb.CookBookId;
    end
end
go
