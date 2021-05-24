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
sitioweb varchar(30) , -- le quité el not null, qué pasa si el usuario no tiene uno?
perfilFB varchar (10),
perfilTW varchar (10),
perfilIG varchar (10),
)
create table GestionMovPK
(
GestionPKID int foreign key(GestionPKID) references Pokemon(PokemonID),  
IDEntrenador int foreign key (IDEntrenador) references Entrenador (IDEntrenador),
IDMovimiento int foreign key (IDMovimiento) references Movimientos (IDMovimiento),
)
create table GestionPK
(
IDEntrenador int foreign key (IDEntrenador) references Entrenador (IDEntrenador),
PokemonID int foreign key (PokemonID) references Pokemon (Pokemon ID),
estado varchar (30) not null,
)
create table Bitacora(
fecha date,
aventura varchar (70),
IDEntrenador int foreign key (IDEntrenador) references Entrenador (IDEntrenador),
)
create table Usuario(
email varchar (30) UNIQUE not null,
username varchar (15) PRIMARY KEY UNIQUE not null,
contrasena varchar (20) not null,
)

create table Cliente(
nombreCl varchar (15) not null,
apellido1Cl varchar (15) not null,
apellido2Cl varchar (15) not null,
cedulaCl int UNIQUE not null,
provinciaCl varchar (15) not null,
cantonCl varchar (15) not null,
distrito varchar (15) not null,
emailCL  varchar (15) not null UNIQUE,
telefonoCl int not null,
ubicacionCL varchar (15) not null,
)

ALTER TABLE Pokemon
ADD FOREIGN KEY (IDEntrenador) references Entrenadores (IDEntrenador);
