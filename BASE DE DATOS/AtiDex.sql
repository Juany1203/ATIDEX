/* 
Proyecto: ATIDEX

Elaborado por:
- Juan Carlos Álvarez Vieto
- Juan Andrés Fernández Camacho
- Marcelo Fernández Solano
- Steven Vega Zúñiga 

*/

create database AtiDex
use AtiDex
drop database Atidex

create table Pokemon
(
PokemonID int IDENTITY(0,1) PRIMARY KEY not null,
nombrePokemon varchar(20) UNIQUE not null,
saludPokemon varchar not null,
ataqueEspecialPokemon varchar not null,
defensaEspecialPokemon varchar not null,      --El pokemonID no debería de ser (0, 1) en vez de (10, 1)
ataquePokemon varchar not null,
defensaPokemon varchar not null, 
velocidadPokemon varchar not null,
generacionPokemon varchar not null,
legendarioPokemon bit not null,
imagenPokemon image, 
)

create table Tipo
(
TipoID int IDENTITY(0,1) PRIMARY KEY not null,    --Programar restricción del UNIQUE
TipoNombre Varchar(15) UNIQUE not null,
)

create table Movimientos
(
MovimientoID int IDENTITY(0,1) PRIMARY KEY not null,
nombreMovimiento varchar(15) not null,
descripcionMovimiento varchar(15) not null,
TipoID int foreign key (TipoID) references Tipo(TipoID),
)

--Relaciona tabla Pokemon con tabla movimientos
create table TABLA_INTERMEDIA_MovPokemon
(
PokemonID int foreign key(PokemonID) references Pokemon(PokemonID),
IDMovimiento int foreign key (IDMovimiento) references Movimientos(MovimientoID),
)

create table intPOKETIPO
(
PokemonID int foreign key(PokemonID) references Pokemon(PokemonID),
TipoID int foreign key (TipoID) references Tipo(TipoID),
)

create table Admin 
(
AdminID int IDENTITY (0,1) PRIMARY KEY not null,
userNameAdmin VARCHAR (10) UNIQUE not null,
contrasenaAdmin VARCHAR (10) not null,
nombreAdmin VARCHAR (10) not null,
apellido1Admin VARCHAR (10) not null,
apellido2Admin VARCHAR (10) not null,
provinciaAdminr varchar(10) not null,
cantonAdmin varchar(10) not null,
distritoAdmin varchar(10) not null,
direccionAdmin varchar(30) not null,
telefonoAdmin varchar(9) not null,
correoElectronicoAdmin varchar(30) not null,
)

create table Entrenadores
(
EntrenadorID int IDENTITY(0,1) PRIMARY KEY not null,
UserNameEntrenador VARCHAR (10) UNIQUE not null,
contrasenaEntrenador VARCHAR (10) not null,
nombreEntrenador VARCHAR (10) not null,
apellido1Entrenador VARCHAR (10) not null,
apellido2Entrenador VARCHAR (10) not null,
provinciaEntrenador varchar(10) not null,
cantonEntrenador varchar(10) not null,
distritoEntrenador varchar(10) not null,
direccionEntrenador varchar(30) not null,
telefonoEntrenador varchar(9) not null,
correoElectronicoEntrenador varchar(30) not null,
sitiowebEntrenador varchar(30) not null, -- le quité el not null, qué pasa si el usuario no tiene uno? si mamon 
perfilFBEntrenador varchar (10) not null,
perfilTWEntrenador varchar (10) not null,
perfilIGEntrenador varchar (10) not null,
)


create table Bitacora
(
ID_Bitacora int IDENTITY (0, 1) PRIMARY KEY not null,
fecha date,
EntrenadorID int foreign key (EntrenadorID) references Entrenadores (EntrenadorID),
)


/* NOTAS IMPORTANTES
Todos los int's como cedula, ID's, telefonos, etc, los cambiamos para varchar, ya que a la hora de manipular, es más fácil manipular varchar's

*/

--QUERY's


