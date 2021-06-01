--Stored Procedure mostrarUsuario

create proc MostrarUsuario
as
select *from Usuario
go


--stored procedure para insertar Usuario

create proc InsertarUsuario

@Username VARCHAR (100),
@Password VARCHAR (100),
@Tipo bit, 
@Nombre VARCHAR (100),
@Apellido1 VARCHAR (100),
@Apellido2 VARCHAR (100),
@Provincia  varchar(100),
@Canton  varchar(100),
@Distrito  varchar(100) ,
@Direccion  varchar(300),
@Telefono  varchar(9) ,
@Email  varchar(300) ,
@SitioWeb  varchar(30), 
@Facebook  varchar (100),
@Twitter  varchar (100),
@IG  varchar (100)
as
insert into Usuario values (@Username, @Password, @Tipo, @Nombre, @Apellido1,@Apellido2, @Provincia,@Canton,@Distrito,@Direccion,@Telefono,@Email,@SitioWeb,@Facebook,@Twitter,@IG)
go
exec InsertarUsuario 'admin', '1234',1,'Admin','Apellido1','Apellido2','Provincia','Provincia','Provincia','Provincia','Provincia','Provincia','','','',''
--stored procedure para modificar Usuario

--stored procedure para Eliminar Usuario

