create or alter procedure dbo.MeasurementDelete(
    @MeasurementTypeId int,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0

    select @MeasurementTypeId = ISNULL(@MeasurementTypeId,0)

    begin try 
        begin tran;

    delete IngredientDesc
    where MeasurementTypeId = @MeasurementTypeId

    delete MeasurementType
    where MeasurementTypeId = @MeasurementTypeId

commit tran
end try 
begin catch 
    ROLLBACK tran;
    THROW
end catch 

    return @return
end 
go

exec MeasurementDelete @MeasurementTypeId = 0