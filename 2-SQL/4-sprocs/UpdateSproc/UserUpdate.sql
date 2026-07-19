create or alter procedure dbo.UsersUpdate(
    @UserId int output,
    @FirstName varchar(50),
    @LastName varchar(50),
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0

    select @UserId = isnull(@UserId,0)

    if @UserId = 0
    begin 
        insert Users(FirstName, LastName)
        values(@FirstName, @LastName)

        select @UserId = SCOPE_IDENTITY()
    end 
    else 
    begin 
        update Users
        set 
            FirstName = @FirstName,
            LastName = @LastName
        where UserId = @UserId
    end 
    return @return
end 
go