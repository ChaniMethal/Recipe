create or alter procedure dbo.PrepStepsDelete(
	@PrepStepsId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select PrepStepsId = isnull(@PrepStepsId,0)

	delete PrepSteps where PrepStepsId = @PrepStepsId

	return @return
end
go