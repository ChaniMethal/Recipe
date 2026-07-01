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

        delete MealCourseRecipe
        where MealCourseId in 
        (
            select mc.MealCourseId
            from MealCourse mc
            join Meal m 
                on m.MealId = mc.MealId
            where m.UserId = @UserId
        )
        or RecipeId in 
        (
            select RecipeId
            from Recipe
            where UserId = @UserId
        )

        delete MealCourse
        where MealId in 
        (
            select MealId
            from Meal m 
            where UserId = @UserId
        )

        delete CookBookRecipe
        where CookBookId in 
        (
            select CookBookId
            from CookBook
            where UserId = @UserId
        )
        or RecipeId in 
        (
            select RecipeId
            from Recipe
            where UserId = @UserId
        )

        delete IngredientDesc
        where RecipeId in 
        (
            select RecipeId
            from Recipe
            where UserId = @UserId
        )

        delete PrepSteps
        where RecipeId in 
        (
            select RecipeId
            from Recipe
            where UserId = @UserId
        )

        delete CookBook 
        where UserId = @UserId

        delete Meal 
        where UserId = @UserId

        delete Recipe 
        where UserId = @UserId

        delete Users
        where UserId = @UserId

    commit tran
end try 
begin catch 
    ROLLBACK tran;
    THROW
end catch 

    return @return
end 
go