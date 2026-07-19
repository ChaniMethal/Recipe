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
    
    delete mcr
        from MealCourseRecipe mcr
        join Recipe r on r.RecipeId = mcr.RecipeId
        where r.CuisineId = @CuisineId;

    delete cbr
        from CookBookRecipe cbr
        join Recipe r on r.RecipeId = cbr.RecipeId
        where r.CuisineId = @CuisineId;

    delete id
        from IngredientDesc id
        join Recipe r on r.RecipeId = id.RecipeId
        where r.CuisineId = @CuisineId;

    delete ps
        from PrepSteps ps
        join Recipe r on r.RecipeId = ps.RecipeId
        where r.CuisineId = @CuisineId;

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