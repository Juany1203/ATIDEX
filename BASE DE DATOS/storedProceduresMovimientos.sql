/* 
Proyecto: ATIDEX
Procedimientos para los movimientos

Elaborado por:
- Juan Carlos Álvarez Vieto
- Juan Andrés Fernández Camacho
- Marcelo Fernández Solano
- Steven Vega Zúñiga 
*/

-- Crea procedimiento para mostrar la tabla de Movimientos
create proc MostrarMovimientos
as
Select *
From Movimientos
go

-- Crea procedimiento para insertar nuevo movimientos
create proc InsertarMovimientos
@nombreMovimiento VARCHAR (100),
@descripcionMovimiento VARCHAR (100),
@TipoID int
as
insert into Movimientos values (@nombreMovimiento, @descripcionMovimiento, @TipoID)
go

-- Crea procedimiento para modificar un movimiento
create proc ModificarMovimientos
@MovimientoID int,
@nombreMovimiento VARCHAR (100),
@descripcionMovimiento VARCHAR (100),
@TipoID int
as
Update Movimientos set nombreMovimiento = @nombreMovimiento, descripcionMovimiento = @descripcionMovimiento, TipoID = @TipoID
where MovimientoID = @MovimientoID
go

-- Crea procedimiento para eliminar un movimiento

create proc EliminarMovimientos
@MovimientoID int
as
Delete from Movimientos
where MovimientoID = @MovimientoID
go