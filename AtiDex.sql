create database AtiDex
use AtiDex

create table Pokemon
(

PokemonID int IDENTITY(0,1) PRIMARY KEY,
Nombre varchar(20) UNIQUE,
salud int,
ATespecial varchar(30),
DFespecial varchar(30),
ataque int,
defensa int, 
velocidad int,
generacion int,
legendario bit not null,
Imagenpokemon image, 
)


create table Movimientos
(
IDMovimiento varchar(6) PRIMARY KEY,
NOMBREMovimiento varchar(15),
DescripcionMovimiento varchar(15),
tipoMovimiento varchar(10),
PokemonID int,
)

create table Tipos
(
MovID Varchar(6) PRIMARY KEY,
MovNombre Varchar(15),
PokemonID int,
)
ALTER TABLE Movimientos
ADD FOREIGN KEY (PokemonID) REFERENCES Pokemon(PokemonID);

ALTER TABLE Tipos
ADD FOREIGN KEY (PokemonID) REFERENCES Pokemon(PokemonID);