create or alter procedure RecipeIngredientGet(
    @IngredientDescId int = 0,
    @RecipeId int = 0,
    @All bit = 0,
    @Message varchar(500) = ''  output
)
as 
begin 
    declare @return int = 0

    select @All = isnull(@All,0), @IngredientDescId = isnull(@IngredientDescId,0), @RecipeId = isnull(@RecipeId,0)

    select id.IngredientDescId,id.IngredientId, id.RecipeId, id.MeasurementTypeId, Quantity = id.MeasurementQuantity, Sequence = id.IngredientSequence
    from IngredientDesc id 
    join Ingredient i 
    on i.IngredientId = id.IngredientId
    where id.IngredientDescId = @IngredientDescId
    or id.RecipeId = @RecipeId
    or @All = 1

    return @return
end 
go 

exec RecipeIngredientGet @all = 1