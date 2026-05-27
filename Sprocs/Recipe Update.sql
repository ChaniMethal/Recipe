create or alter proc dbo.RecipeUpdate(
    @RecipeId int output,
    @CuisineId int,
    @UserId int,
    @RecipeName varchar(100),
    @Calories int,
    @DateCreated datetime,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0

    select 
        @RecipeId = nullif(@RecipeId, 0),
        @Calories = isnull(@Calories, 0)

    if @Calories <= 0
    begin
        select @return = 1, @Message = 'Calories must be greater than zero.'
        goto finished
    end

    if @RecipeId is null
    begin
        insert Recipe(CuisineId, UserId, RecipeName, Calories, DateCreated)
        values(@CuisineId, @UserId, @RecipeName, @Calories, @DateCreated)

        select @RecipeId = scope_identity()
    end
    else
    begin
        update Recipe
        set 
            CuisineId = @CuisineId,
            UserId = @UserId,
            RecipeName = @RecipeName,
            Calories = @Calories
        where RecipeId = @RecipeId
    end

    finished:
    return @return
end
go