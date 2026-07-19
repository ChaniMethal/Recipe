create or alter procedure dbo.UsersDelete(
    @UserId int,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0

    select @UserId = isnull(@UserId,0)

    begin try 
        begin tran;

        delete mcr
        from MealCourseRecipe mcr
        join MealCourse mc
            on mc.MealCourseId = mcr.MealCourseId
        join Meal m
            on m.MealId = mc.MealId
        where m.UserId = @UserId;

        delete mcr
        from MealCourseRecipe mcr
        join Recipe r
            on r.RecipeId = mcr.RecipeId
        where r.UserId = @UserId;

        delete mc
        from MealCourse mc
        join Meal m
            on m.MealId = mc.MealId
        where m.UserId = @UserId;

        delete cbr
        from CookBookRecipe cbr
        join CookBook cb
            on cb.CookBookId = cbr.CookBookId
        where cb.UserId = @UserId;

        delete cbr
        from CookBookRecipe cbr
        join Recipe r
            on r.RecipeId = cbr.RecipeId
        where r.UserId = @UserId;

        delete id
        from IngredientDesc id
        join Recipe r
            on r.RecipeId = id.RecipeId
        where r.UserId = @UserId;

        delete ps
        from PrepSteps ps
        join Recipe r
            on r.RecipeId = ps.RecipeId
        where r.UserId = @UserId;

        delete CookBook
        where UserId = @UserId;

        delete Meal
        where UserId = @UserId;

        delete Recipe
        where UserId = @UserId;

        delete Users
        where UserId = @UserId;

        commit tran;
    end try 
    begin catch 
        rollback tran;
        throw;
    end catch;

    return @return
end 
go