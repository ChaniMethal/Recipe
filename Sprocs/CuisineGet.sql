create or alter procedure dbo.CuisineGet(
    @CuisineId int = 0, 
    @CuisineName varchar(50) = ' ', 
    @All bit = 0
)
as
begin
    select c.CuisineId, c.CuisineName
    from Cuisine c
    where c.CuisineId = @CuisineId
    or @All = 1
    or (@CuisineName <> '' and c.CuisineName like '%' + @CuisineName + '%')
    order by c.CuisineId
end
go

exec CuisineGet 

exec CuisineGet @All = 1

exec CuisineGet @CuisineName = ' '

exec CuisineGet @CuisineName = null

exec CuisineGet @CuisineName = 'a'

declare @CuisineId int

select top 1 @CuisineId = c.CuisineId from Cuisine c

exec CuisineGet @CuisineId = @CuisineId
