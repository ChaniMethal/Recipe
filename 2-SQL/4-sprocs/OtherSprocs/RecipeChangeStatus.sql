create or alter procedure dbo.RecipeChangeStatus(
    @RecipeId int,
    @RecipeStatus varchar(20),
    @StatusDate datetime,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0

    if @RecipeStatus = 'draft'
    begin 
        update Recipe
        set DateCreated = @StatusDate,
            DatePublished = null,
            DateArchived = null
        where RecipeId = @RecipeId
    end 

    if @RecipeStatus = 'publish'
    begin 
        update Recipe
        set DatePublished = @StatusDate,
            DateArchived = null
        where RecipeId = @RecipeId
    end 

    if @RecipeStatus = 'archive'
    begin 
        update Recipe
        set DateArchived = @StatusDate
        where RecipeId = @RecipeId
        
    end 
    return @Return
end 
go