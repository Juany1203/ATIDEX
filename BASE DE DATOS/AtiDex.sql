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
nombrePokemon varchar(50) UNIQUE not null,
generacionPokemon varchar(50) not null,
legendarioPokemon bit not null,
imagenPokemon image, 
)


-- tabla de todos los usuarios

create table Usuario
(
UsuarioID int IDENTITY(0,1) PRIMARY KEY not null,
UserNameUsuario VARCHAR (100) UNIQUE not null,
Password VARCHAR (100) not null,
TipoUsuario bit not null, -- Esto indica si el ususario es admin o entrenador, 1 si es admin 0 si es entrenador
nombreUsuario VARCHAR (100) not null,
apellido1Usuario VARCHAR (100) not null,
apellido2Usuario VARCHAR (100) not null,
provinciaUsuario varchar(100) not null,
cantonUsuario varchar(100) not null,
distritoUsuario varchar(100) not null,
direccionUsuario varchar(300) not null,
telefonoUsuario varchar(30) not null,
correoElectronicoUsuario varchar(30) not null,
sitiowebUsuario varchar(30), 
perfilFBUsuario varchar (50),
perfilTWUsuario varchar (50),
perfilIGUsuario varchar (50),
)

-- tabla que contiene los pokemons por entrenador


create Table TrainerPokemon(
TrainerPokemonID int IDENTITY(0,1) PRIMARY KEY not null,
EntrenadorIDTrainerPokemon int foreign key(EntrenadorIDTrainerPokemon) references Usuario(UsuarioID),
PokemonID int foreign key(PokemonID) references Pokemon(PokemonID),
NickName varchar(60) not null,
saludTrainerPokemon varchar(50) not null,
ataqueEspecialTrainerPokemon varchar(50) not null,
defensaTrainerEspecialPokemon varchar(50) not null,     
ataqueTrainerPokemon varchar(50) not null,
defensaTrainerPokemon varchar(50) not null, 
velocidadTrainerPokemon varchar(50) not null,
EstadoPokemon bit,
)

-- tabla del los tipos de pokemon y movimientos que hay

create table Tipo
(
TipoID int IDENTITY(0,1) PRIMARY KEY not null,  
TipoNombre Varchar(50) UNIQUE not null,
)
 
-- Movimientos para asignar


create table Movimientos
(
MovimientoID int IDENTITY(0,1) PRIMARY KEY not null,
nombreMovimiento varchar(50) not null,
descripcionMovimiento varchar(50) not null,
TipoID int foreign key (TipoID) references Tipo(TipoID),
)


--Relaciona tabla Pokemon por entrenador con tabla movimientos
create table TABLA_INTERMEDIA_MovPokemon
(
MovPokemonID int IDENTITY(0,1) PRIMARY KEY not null,
TrainerPokemon_IntermediaID int foreign key(TrainerPokemon_IntermediaID) references TrainerPokemon(TrainerPokemonID),
Movimiento_IntermediaID int foreign key (Movimiento_IntermediaID) references Movimientos(MovimientoID),
EntrenadorID int foreign key (EntrenadorID) references Usuario(UsuarioID),
)

--tabla intermedia entre los pokemones genericos y los tipos
drop table TrainerPokemon

create table intPOKETIPO
(
PokemonID int foreign key(PokemonID) references Pokemon(PokemonID),
TipoID int foreign key (TipoID) references Tipo(TipoID),
)

-- tabla de las bitacoras para los entrenadores

create table Bitacora
(
ID_Bitacora int IDENTITY (0, 1) PRIMARY KEY not null,
Dia varchar(50) not null,
mes varchar(50) not null,
año varchar(50) not null,
Descripcion varchar(500) not null,
UserIDBitacora int foreign key (UserIDBitacora) references Usuario (UsuarioID),
)
drop table TrainerPokemon

--TABLAS 

insert into Tipo
values 
('Bicho'),
('Dragón'),
('Eléctrico'),
('Hada'),
('Lucha'),
('Fuego'),
('Volador'),
('Fantasma'),
('Tierra'),
('Hielo'),
('Veneno'),
('Psíquico'),
('Roca'),
('Acero'),
('Agua');
insert into Movimientos
values
('Destructor Pound', 'Ningún efecto', 27),
('Karate Chop','Alta probabilidad de Golpe Crítico', 26),
('Double Slap', 'Golpea de 2 a 5 veces seguidas', 30),
('Comet Punch', 'Golpea de 2 a 5 veces seguidas', 31),
('Mega Punch','Ningún efecto', 33),
('Pay Day','Recolecta dinero tras batallas.', 26),
('Fire Punch', '10% de quemar al rival', 24),
('Ice Punch', '10% de congelar al rival', 30),
('Thunder Punch', '10% de paralizar al rival', 32),
('Scratch', 'Ningún efecto', 27),
('Vice Grip', 'Ningún efecto', 31),
('Guillotine','Puede debilitar al Pokémon rival de un solo golpe',32),
('Razor Wind', 'Debe cargarse el primer turno.', 31),
('Swords Dance','Aumenta dos niveles el Ataque al usuario', 28),
('Cut', 'Ningún efecto', 28),
('Gust','Golpea a Pokémon en mitad de un Vuelo.', 26),
('Wing Attack', 'Ningún efecto', 27);

select *from Usuario