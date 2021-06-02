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



-- Tabla del pokemon generico

create table Pokemon
(
PokemonID int IDENTITY(0,1) PRIMARY KEY not null,
nombrePokemon varchar(20) UNIQUE not null,
generacionPokemon varchar not null,
legendarioPokemon bit not null,
imagenPokemon image, 
)


-- tabla de todos los usuarios

create table Usuario
(
UsuarioID int IDENTITY(0,1) PRIMARY KEY not null,
UserNameUsuario VARCHAR (10) UNIQUE not null,
password VARCHAR (10) not null,
TipoUsuario bit not null, -- Esto indica si el ususario es admin o entrenador, 1 si es admin 0 si es entrenador
nombreUsuario VARCHAR (10) not null,
apellido1Usuario VARCHAR (10) not null,
apellido2Usuario VARCHAR (10) not null,
provinciaUsuario varchar(10) not null,
cantonUsuario varchar(10) not null,
distritoUsuario varchar(10) not null,
direccionUsuario varchar(30) not null,
telefonoUsuario varchar(9) not null,
correoElectronicoUsuario varchar(30) not null,
sitiowebUsuario varchar(30), 
perfilFBUsuario varchar (10),
perfilTWUsuario varchar (10),
perfilIGUsuario varchar (10),
)

-- tabla que contiene los pokemons por entrenador


create Table TrainerPokemon(
TrainerPokemonID int IDENTITY(0,1) PRIMARY KEY not null,
EntrenadorIDTrainerPokemon int foreign key(EntrenadorIDTrainerPokemon) references Usuario(UsuarioID),
PokemonID int foreign key(PokemonID) references Pokemon(PokemonID),
saludTrainerPokemon varchar not null,
ataqueEspecialTrainerPokemon varchar not null,
defensaTrainerEspecialPokemon varchar not null,     
ataqueTrainerPokemon varchar not null,
defensaTrainerPokemon varchar not null, 
velocidadTrainerPokemon varchar not null,
EstadoPokemon varchar(10) not null,
)

-- tabla del los tipos de pokemon y movimientos que hay

create table Tipo
(
TipoID int IDENTITY(0,1) PRIMARY KEY not null,  
TipoNombre Varchar(15) UNIQUE not null,
)

-- Movimientos para asignar


create table Movimientos
(
MovimientoID int IDENTITY(0,1) PRIMARY KEY not null,
nombreMovimiento varchar(150) not null,
descripcionMovimiento varchar(150) not null,
TipoID int foreign key (TipoID) references Tipo(TipoID),
)


--Relaciona tabla Pokemon por entrenador con tabla movimientos
create table TABLA_INTERMEDIA_MovPokemon
(
TrainerPokemon_IntermediaID int foreign key(TrainerPokemon_IntermediaID) references TrainerPokemon(TrainerPokemonID),
Movimiento_IntermediaID int foreign key (Movimiento_IntermediaID) references Movimientos(MovimientoID),
)

--tabla intermedia entre los pokemones genericos y los tipos


create table intPOKETIPO
(
PokemonID int foreign key(PokemonID) references Pokemon(PokemonID),
TipoID int foreign key (TipoID) references Tipo(TipoID),
)

-- tabla de las bitacoras para los entrenadores

create table Bitacora
(
ID_Bitacora int IDENTITY (0, 1) PRIMARY KEY not null,
fecha date,
UserIDBitacora int foreign key (UserIDBitacora) references Usuario (UsuarioID),
)

