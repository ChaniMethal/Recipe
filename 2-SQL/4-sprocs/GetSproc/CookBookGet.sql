create or alter procedure dbo.CookBookGet(
    @CookBookId int = 0, 
    @CookBookName varchar(100) = '', 
    @All bit = 0
)
as 
begin 
    select cb.CookBookId, cb.CookBookName, cb.UserId, cb.Price, cb.DateCreated, cb.Active
    from CookBook cb 
    where cb.CookBookId = @CookBookId
    or @All = 1
    order by cb.CookBookId
end 
go 

exec CookBookGet @All = 1