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
as
select *from TrainerPokemon
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