create or alter procedure dbo.PrepStepsUpdate(
    @PrepStepsId int output,
    @RecipeId int,
    @StepSequence int,
    @StepDesc varchar(500),
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0

    select @PrepStepsId = isnull(@PrepStepsId, 0)

    if @PrepStepsId = 0
    begin 
        insert PrepSteps(RecipeId, StepSequence, StepDesc)
        values (@RecipeId, @StepSequence, @StepDesc)

        select @PrepStepsId = SCOPE_IDENTITY()
    end 
    else 
    begin 
        update PrepSteps
        set 
            RecipeId = @RecipeId, 
            StepSequence = @StepSequence, 
            StepDesc = @StepDesc
        where PrepStepsId = @PrepStepsId
    end 
    return @return 
end 
go 

select * from PrepSteps