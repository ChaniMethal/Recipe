create or alter procedure dbo.PrepStepsGet(
	@PrepStepsId int = 0,
	@All bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @PrepStepsId = isnull(@PrepStepsId,0)

	select p.PrepStepsId, p.RecipeId, p.StepDesc, p.StepSequence
	from PrepSteps p 
	where PrepStepsId = @PrepStepsId
	or @All = 1

	return @return
end
go

exec prepStepsGet @All = 1
