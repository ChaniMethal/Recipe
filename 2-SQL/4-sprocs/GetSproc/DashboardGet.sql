create or alter proc dbo.RecipeDashboardGet(
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0

    select DashboardType = 'recipe',
           DashboardText = cast(count(*) as varchar(10))
    from Recipe

    union select DashboardType = 'meal',
           DashboardText = cast(count(*) as varchar(10))
    from Meal

    union select DashboardType = 'cookbook',
           DashboardText = cast(count(*) as varchar(10))
    from Cookbook

    return @return
end 
go