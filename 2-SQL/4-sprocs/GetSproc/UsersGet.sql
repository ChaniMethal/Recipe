create or alter procedure dbo.UsersGet(
    @UserId int = 0, 
    @UserName varchar(101) = ' ', 
    @All bit = 0,
    @IncludeBlank bit = 0
    
)
as
begin
    select @UserId = nullif(@UserId,0), @IncludeBlank = nullif(@IncludeBlank,0)

    select u.UserId, u.FirstName, u.LastName, u.UserName
    from Users u 
    where u.UserId = @UserId
    or @All = 1
    or (@UserName <> '' and u.UserName like '%' + @UserName + '%')
    or @All = 1
    union select 0, '', '', ''
    where @IncludeBlank = 1
    order by u.UserId
end
go

exec UsersGet 

exec UsersGet @All = 1
