create or alter procedure dbo.CookBookRecipeDelete(
    @CookBookRecipeId int,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    delete CookBookRecipe
    where CookBookRecipeId = @CookBookRecipeId

    return @return
end
go