create or alter proc RecipeUpdate(
    @RecipeId int output,
    @CuisineId int,
    @UserId int,
    @RecipeName varchar (100),
    @Calories int,
)
as 
begin 
    declare @return int = 0

    select @RecipeId = nullif(@RecipeId,0), @TermEnd = nullif(@TermEnd,0), @Num = ISNULL(@Num,0)
    if @TermEnd is null and exists (select * from President p where p.TermEnd is null and p.PresidentId <> @PresidentId)
    begin 
        select @return = 1, @Message = 'There can be only one current president at a time.'
        goto finished
    end