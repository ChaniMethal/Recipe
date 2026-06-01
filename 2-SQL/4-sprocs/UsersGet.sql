create or alter procedure dbo.UsersGet(
    @UserId int = 0, 
    @UserName varchar(101) = ' ', 
    @All bit = 0
)
as
begin
    select u.UserId, u.FirstName, u.LastName, u.UserName
    from Users u 
    where u.UserId = @UserId
    or @All = 1
    or (@UserName <> '' and u.UserName like '%' + @UserName + '%')
    order by u.UserId
end
go

exec UsersGet 

exec UsersGet @All = 1

exec UsersGet @UserName = ' '

exec UsersGet @UserName = null

exec UsersGet @UserName = 'a'

declare @UserId int

select top 1 @UserId = u.UserId from users u

exec UsersGet @UserId = @UserId
