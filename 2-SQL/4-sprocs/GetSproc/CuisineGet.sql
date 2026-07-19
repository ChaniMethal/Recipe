create or alter procedure dbo.CuisineGet(
    @CuisineId int = 0, 
    @CuisineName varchar(50) = ' ', 
    @All bit = 0,
    @IncludeBlank bit = 0
)
as
begin
    declare @return int = 0

    select @All =isnull(@All,0), @CuisineId = nullif(@CuisineId, 0), @IncludeBlank = nullif(@IncludeBlank, 0)

    select c.CuisineId, c.CuisineName
    from Cuisine c
    where c.CuisineId = @CuisineId
    or (@CuisineName <> '' and c.CuisineName like '%' + @CuisineName + '%')
    or @All = 1
    union select 0, ''
    where @IncludeBlank = 1
    order by c.CuisineId
end
go

exec CuisineGet @all = 1