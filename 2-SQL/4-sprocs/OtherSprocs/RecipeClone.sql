create or alter procedure dbo.RecipeClone(
    @RecipeId int = 0,
    @NewRecipeId int output,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0

    select @RecipeId = ISNULL(@RecipeId,0), @NewRecipeId = 0

    insert Recipe(CuisineId, UserId, RecipeName, Calories, DateCreated)
    select CuisineId, UserId, RecipeName + ' - clone', Calories, GETDATE()
    from Recipe
    where RecipeId = @RecipeId

    SELECT @NewRecipeId = SCOPE_IDENTITY()

    insert IngredientDesc(RecipeId, IngredientId, IngredientSequence, MeasurementQuantity, MeasurementTypeId)
    select @NewRecipeId, IngredientId, IngredientSequence, MeasurementQuantity, MeasurementTypeId
    from IngredientDesc
    where RecipeId = @RecipeId

    insert PrepSteps(RecipeId, StepSequence, StepDesc)
    select @NewRecipeId, StepSequence, StepDesc
    from PrepSteps
    where RecipeId = @RecipeId

    return @return
end 
go 

