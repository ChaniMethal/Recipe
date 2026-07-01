create or alter procedure MeasurementTypeGet(
    @MeasurementTypeId int = 0,
    @All bit = 0,
    @Message varchar(100) = '' output
)
as 
begin 
    declare @return int = 0

    select @All = isnull(@All,0), @MeasurementTypeId = isnull(@MeasurementTypeId,0)

    select m.MeasurementTypeId, m.MeasurementType
    from MeasurementType m 
    where MeasurementTypeId = @MeasurementTypeId
    or @All = 1 

    return @return
end 
go 

exec MeasurementTypeGet

select * from MeasurementType