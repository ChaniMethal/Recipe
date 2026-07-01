create or alter procedure dbo.CuisineDelete(
    @CuisineId int,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0

    select @CuisineId = isnull(@CuisineId,0)
 
begin try 
    begin tran;
    
    delete MealCourseRecipe
    where RecipeId in 
    (
        select RecipeId
        from Recipe
        where CuisineId = @CuisineId
    )

    delete CookBookRecipe
    where RecipeId in 
    (
        select RecipeId
        from Recipe
        where CuisineId = @CuisineId
    )

    delete IngredientDesc
    where RecipeId in 
    (
        select RecipeId
        from Recipe
        where CuisineId = @CuisineId
    )

    delete PrepSteps
    where RecipeId in 
    (
        select RecipeId
        from Recipe
        where CuisineId = @CuisineId
    )

    delete Recipe 
    where CuisineId = @CuisineId

    delete Cuisine
    where CuisineId = @CuisineId
    
commit tran
end try 
begin catch 
    ROLLBACK tran;
    THROW
end catch 

    return @return
end 
go