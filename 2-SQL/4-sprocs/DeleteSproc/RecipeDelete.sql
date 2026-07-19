create or alter procedure dbo.RecipeDelete
    @RecipeId int,
    @Message varchar(500) = '' output
as 
begin
    declare @return int = 0
    if exists( select * from Recipe r
    where r.RecipeId = @RecipeId
    and not (
        Datediff(day, r.DateArchived, GETDATE()) > 30 
        or r.RecipeStatus = 'draft'
    )
)
begin 
    select @return = 1, 
           @Message = 'Cannot delete Recipe unless it is drafted or archived for more than 30 days.'
    goto finished
end

    begin try 
        begin tran;

        delete MealRecipe
        where RecipeId = @RecipeId;

        delete CookBookRecipe
        where RecipeId = @RecipeId;

        delete IngredientDesc 
        where RecipeId = @RecipeId;

        delete PrepSteps 
        where RecipeId = @RecipeId;

        delete Recipe 
        where RecipeId = @RecipeId;
    commit 
    end try 
    begin catch 
        ROLLBACK;
        THROW
    end catch 

    finished:
    return @return
end
go