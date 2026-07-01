create or alter procedure dbo.RecipeIngredientDelete(
	@IngredientDescId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select IngredientDescId = isnull(@IngredientDescId,0)

	delete IngredientDesc where IngredientDescId = @IngredientDescId

	return @return
end
go