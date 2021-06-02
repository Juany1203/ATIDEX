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