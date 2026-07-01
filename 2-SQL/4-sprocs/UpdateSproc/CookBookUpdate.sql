create or alter proc dbo.CookBookUpdate(
    @CookBookId int output,
    @CookBookName varchar(100),
    @UserId int,
    @DateCreated date,
    @Price decimal(6,2),
    @Active bit,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0

    select @CookBookId = nullif(@CookBookId, 0)

    if @CookBookId is null 
    BEGIN
        insert CookBook(CookBookName, UserId, DateCreated, Price, Active)
        values(@CookBookName, @UserId, @DateCreated, @Price, @Active)

        select @CookBookId = scope_identity()
    end 
    else 
    begin 
        update CookBook
        set 
            CookBookName = @CookBookName, 
            UserId = @UserId, 
            DateCreated = @DateCreated, 
            Price = @Price, 
            Active = @Active
        where CookBookId = @CookBookId
    end 

    finished:
    return @return
end 
go 

