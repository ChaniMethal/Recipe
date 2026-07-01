create or alter procedure CoursesGet(
    @CourseId int = 0,
    @All bit = 0,
    @Message varchar(100) = '' output
)
as 
begin 
    declare @return int = 0

    select @All = isnull(@All,0), @CourseId = isnull(@CourseId,0)

    select c.CourseId, c.CourseName, c.CourseSequence
    from Course c
    where CourseId = @CourseId
    or @All = 1 

    return @return
end 
go 

exec CoursesGet

select * from Course