create or alter procedure dbo.IngredientGet(
	@IngredientId int = 0,
	@All bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @IngredientId = isnull(@IngredientId,0)

	select m.IngredientId, m.IngredientName
	from Ingredient m
	where IngredientId = @IngredientId
	or @All = 1

	return @return
end
go

exec IngredientGet @All = 1
