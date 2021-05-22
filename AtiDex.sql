create database AtiDex
use AtiDex
drop database Atidex

create table Pokemon
(
PokemonID int IDENTITY(0,1) PRIMARY KEY not null,
Nombre varchar(20) UNIQUE not null,
salud int not null,
ATespecial int not null,
DFespecial int not null,
ataque int not null,
defensa int not null, 
velocidad int not null,
generacion int not null,
legendario bit not null,
Imagenpokemon image, 
IDEntrenador int not null,

)

create table TABLA_INTERMEDIA_MovPokemon
(
PokemonID int foreign key(PokemonID) references Pokemon(PokemonID),
IDMovimiento int foreign key (IDMovimiento) references Movimientos (IDMovimiento),
)

create table Movimientos
(
IDMovimiento int IDENTITY(0,1) PRIMARY KEY not null,
NOMBREMovimiento varchar(15) not null,
DescripcionMovimiento varchar(15) not null,
tipoMovimiento varchar(10) not null,
PokemonID int not null,
)

create table TABLA_INTERMEDIA_TipPokemon
(
PokemonID int foreign key(PokemonID) references Pokemon(PokemonID),
MovID  int foreign key (MovID) references Tipos (MovID),
)


create table Tipos
(
MovID int IDENTITY(0,1) PRIMARY KEY not null,
MovNombre Varchar(15) not null,
)

create table Entrenadores
(
IDEntrenador int IDENTITY(0,1) PRIMARY KEY not null,
provincia varchar(10) not null,
canton varchar(10) not null,
distrito varchar(10) not null,
Exacto varchar(30) not null,
telefono int,
correoElectronico varchar(30) not null,
sitioweb varchar(30) not null, -- faltan las redes sociales
)

ALTER TABLE Pokemon
ADD FOREIGN KEY (IDEntrenador) references Entrenadores (IDEntrenador);