create proc InsertarTipo
@NombreTipo varchar (100)
as 
insert into Tipo values (@NombreTipo) 
go

create proc EditarTipo
@IdTipo int,
@NombreTipo varchar (100)
as 
update Tipo set TipoNombre = @NombreTipo
where TipoID = @IdTipo 
go

create proc EliminarTipo
@IdTipo int
as
delete from Tipo where TipoID = @IdTipo
go

drop proc EliminarTipo