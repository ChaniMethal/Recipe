create or alter procedure dbo.IngredientUpdate(
    @IngredientDescId int output,
    @RecipeId int,
    @IngredientId int,
    @Sequence int,
    @Quantity decimal(10,2),
    @MeasurementTypeId int = null,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0

    select @IngredientDescId = isnull(@IngredientDescId,0)

    if @IngredientDescId = 0
    begin 
        insert IngredientDesc(RecipeId, IngredientId, IngredientSequence, MeasurementQuantity, MeasurementTypeId)
        values(@RecipeId, @IngredientId, @Sequence, @Quantity, @MeasurementTypeId)

        select @IngredientDescId = SCOPE_IDENTITY()
    end 
    else 
    begin 
        update IngredientDesc
        set 
            RecipeId = @RecipeId,
            IngredientId = @IngredientId,
            IngredientSequence = @Sequence, 
            MeasurementQuantity = @Quantity, 
            MeasurementTypeId = @MeasurementTypeId
        where IngredientDescId = @IngredientDescId
    end 
    return @return
end 
go