create or alter procedure dbo.IngredientDelete(
    @IngredientId int,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0

    select @IngredientId = isnull(@IngredientId,0)
    
    begin try 
        begin tran;

    delete IngredientDesc
    where IngredientId = @IngredientId

    delete Ingredient
    where IngredientId = @IngredientId
  
    commit tran
end try 
begin catch 
    ROLLBACK tran;
    THROW
end catch 

    return @return
end 
go