create or alter procedure dbo.CuisineUpdate(
    @CuisineId int output,
    @CuisineName varchar(50),
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0

    select @CuisineId = ISNULL(@CuisineId,0)

    if @CuisineId = 0
    begin 
        insert Cuisine(CuisineName)
        values(@CuisineName)

        select @CuisineId = SCOPE_IDENTITY()
    end 
    ELSE
    begin 
        update Cuisine 
        set 
            CuisineName = @CuisineName
        where CuisineId = @CuisineId 
    end 
    return @return
end 
go 