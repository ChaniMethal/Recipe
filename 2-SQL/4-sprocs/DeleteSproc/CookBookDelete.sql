create or alter procedure dbo.CookBookDelete(
    @CookBookId int,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0

	select @CookBookId = isnull(@CookBookId,0)
    
    delete CookBookRecipe 
    where CookBookId = @CookBookId
    
    delete CookBook 
    where CookBookId = @CookBookId

	return @return
end 
go 