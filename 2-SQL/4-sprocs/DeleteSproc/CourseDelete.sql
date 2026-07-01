create or alter procedure dbo.CoursesDelete(
    @CourseId int,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0

    select @CourseId = isnull(@CourseId,0)

    begin try 
        begin tran;

    delete MealCourseRecipe 
    where MealCourseId in 
    (
        select MealCourseId
        from MealCourse
        where CourseId = @CourseId
    )
    delete MealCourse
    where CourseId = @CourseId

    delete Course 
    where CourseId = @CourseId

commit tran
end try 
begin catch 
    ROLLBACK tran;
    THROW
end catch 

    return @return
end 
go
