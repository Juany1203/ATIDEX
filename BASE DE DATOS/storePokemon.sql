-- stored procedure para insertar Pokemon

create proc InsertarPokemon
@nombrePokemon VARCHAR (50),
@generacionPokemon VARCHAR (50),
@legendarioPokemon bit,
@imagenPokemon image
as
insert into Pokemon values (@nombrePokemon, @generacionPokemon, @legendarioPokemon, @imagenPokemon)
go

-- stored procedure para editar Pokemon
create proc EditarPokemon
@PokemonID int,
@nombrePokemon VARCHAR (50),
@generacionPokemon VARCHAR (50),
@legendarioPokemon bit,
@imagenPokemon image

as Update Pokemon set nombrePokemon = @nombrePokemon, generacionPokemon
= @generacionPokemon, legendarioPokemon = @legendarioPokemon, imagenPokemon = @imagenPokemon
where PokemonID = @PokemonID
go

--stored procedure para eliminar Pokemon

create proc EliminarPokemon
@PokemonIDEliminar int
as
delete from Pokemon where PokemonID = @PokemonIDEliminar
go

Create proc MostrarPokemon
as
select *from Pokemon
go


Create proc MostrarTrainerPokemon
@EntrenadorID int
as
select *from TrainerPokemon where EntrenadorIDTrainerPokemon = @EntrenadorID
go

-- Stored procedures para Trainer pokemon


create proc InsertarTrainerPokemon
@EntrenadorID int,
@PokemonID int,
@NickName VARCHAR (50),
@Salud VARCHAR (50),
@Ataque VARCHAR (50),
@Defensa VARCHAR (50),
@ATKespecial VARCHAR (50),
@DEFespecial VARCHAR (50),
@Velocidad VARCHAR (50),
@EstadoPokemon bit

as
insert into TrainerPokemon values (@EntrenadorID, @PokemonID, @NickName,@Salud, @Ataque,@Defensa,@ATKespecial,@DEFespecial,@Velocidad,@EstadoPokemon)
go

create proc EditarTrainerPokemon
@TrainerPokemonID int,
@EntrenadorID int,
@PokemonID int,
@NickName VARCHAR (50),
@Salud VARCHAR (50),
@Ataque VARCHAR (50),
@Defensa VARCHAR (50),
@ATKespecial VARCHAR (50),
@DEFespecial VARCHAR (50),
@Velocidad VARCHAR (50),
@EstadoPokemon bit
as
update TrainerPokemon set EntrenadorIDTrainerPokemon = @EntrenadorID,PokemonID = @PokemonID, NickName = @NickName,
saludTrainerPokemon = @Salud, ataqueTrainerPokemon = @Ataque, defensaTrainerPokemon = @Defensa, ataqueEspecialTrainerPokemon = @ATKespecial,defensaTrainerEspecialPokemon = @DEFespecial, 
velocidadTrainerPokemon = @Velocidad, EstadoPokemon = @EstadoPokemon
where TrainerPokemonID = @TrainerPokemonID
go



create proc EliminarTrainerPokemon
@TrainerPokemon int
as
delete from TrainerPokemon where TrainerPokemonID = @TrainerPokemon
go
-- TrainerPokemonMov Funciones
create proc EditarTrainerPokemonMov
@TrainerPokemonMov int,
@MovimientoID int,
@TrainerPokemonID int 
as
update TABLA_INTERMEDIA_MovPokemon set Movimiento_IntermediaID = @MovimientoID, TrainerPokemon_IntermediaID = @TrainerPokemonID
where MovPokemonID = @TrainerPokemonMov
go

create proc EliminarTrainerPokemonMov
@TrainerPokemonMov int
as
delete from TABLA_INTERMEDIA_MovPokemon where MovPokemonID = @TrainerPokemonMov
go

create proc MostrarTrainerPokemonMov
@EntrenadorID int
as
select  *from TABLA_INTERMEDIA_MovPokemon
where  EntrenadorID = @EntrenadorID
go

create proc InsertTrainerPokemonMov
@TrainerPokemonID int,
@MovimientosID int,
@EntrenadorID int
as
insert into TABLA_INTERMEDIA_MovPokemon values (@TrainerPokemonID,@MovimientosID, @EntrenadorID)
go

--Procedimientos Visitante

--Busqueda pokemon
Create proc VisitantePokemon
@nombre varchar (50),
@generacion varchar (50)
as
if (NULLIF(@nombre, '') IS NULL and NULLIF(@generacion, '') IS NULL)
begin
select *from Pokemon 
end
else
begin
select *from Pokemon where nombrePokemon = @nombre or generacionPokemon = @generacion
end
go


drop proc VisitantePokemon

exec VisitantePokemon '','' 


--Busqueda entrenador

Create proc VisitanteEntrenador
@nombre varchar (50),
@Apellido1 varchar (50),
@provincia varchar (50)
as
if (NULLIF(@nombre, '') IS NULL and NULLIF(@Apellido1, '') IS NULL and NULLIF(@provincia, '') IS NULL)
begin
select *from Usuario
end
else
begin
select *from Usuario where nombreUsuario = @nombre or apellido1Usuario = @Apellido1 or provinciaUsuario = @provincia
end
go

exec VisitanteEntrenador 'Juan Carlos','', ''

--Busqueda movimiento

Create proc VisitanteMovimiento
@nombre varchar (50)
as
if (NULLIF(@nombre, '') IS NULL)
begin
select *from Movimientos
end
else
begin
select *from Movimientos where nombreMovimiento = @nombre 
end
go

exec VisitanteMovimiento 'achu'