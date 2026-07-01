create or alter procedure dbo.CookBookAutoCreate(
    @UserId int,
    @NewCookBookId int output,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0

    select @UserId = isnull(@UserId,0), @NewCookBookId = 0

    if @UserId = 0
    begin 
        select @return = 1, @Message = 'Please select a user.'
        goto finished
    end 
    
    declare @CookBookName varchar(100)

    select @CookBookName = 'Recipes by ' + u.FirstName + ' ' + u.LastName
    from Users u
    where u.UserId = @UserId

    if exists(select * from CookBook where CookBookName = @CookBookName)
    begin
        select @return = 1,
               @Message = 'Cannot create cookbook because this cookbook already exists.'
        goto finished
    end
    
    declare @NumRecipes int = 0

    select @NumRecipes = count(*)
    from Recipe 
    where UserId = @UserId

    if @NumRecipes = 0
    begin 
        select @return = 1, @Message = 'Cannot create cookbook because this user has no recipes.'
        goto finished
    end

    insert CookBook(CookBookName, UserId, DateCreated, Price, Active)
    select 'Recipes by ' + u.FirstName + ' ' + u.LastName, u.UserId, GETDATE(), @NumRecipes * 1.33, 1
    from Users u 
    left join Recipe r 
    on u.UserId = r.UserId
    where u.UserId = @UserId
    group by u.UserId, u.FirstName, u.LastName

    select @NewCookBookId = CONVERT(int, SCOPE_IDENTITY())

    insert CookBookRecipe(CookBookId, RecipeId, [Sequence])
    select @NewCookBookId, r.RecipeId, ROW_NUMBER() over (order by r.RecipeName)
    from Recipe r 
    where r.UserId = @UserId
    order by r.RecipeName

    finished:
    RETURN @return
end 
go 