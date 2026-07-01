create or alter procedure CookBookRecipeGet(
    @CookBookId int = 0,
    @RecipeId int = 0,
    @All bit = 0,
    @Message varchar(500) = '' OUTPUT
)
as 
begin 
    declare @return int = 0

    select @All = isnull (@All,0), @CookBookId = ISNULL(@CookBookId,0), @RecipeId = ISNULL(@RecipeId,0)

    select cbr.CookBookRecipeId,cb.CookBookId, cb.UserId, Recipe = r.RecipeName,Sequence = cbr.[Sequence]
    from CookBook cb
    join CookBookRecipe cbr
    on cb.CookBookId = cbr. CookBookId
    join Recipe r 
    on r.RecipeId = cbr.RecipeId
    where cb.CookBookId = @CookBookId
    or r.RecipeId = @RecipeId
    or @All = 1
    
    return @return 
end 
go 

exec CookBookRecipeGet @All = 1