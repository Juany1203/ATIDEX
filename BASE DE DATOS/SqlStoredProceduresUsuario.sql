--Stored Procedure mostrarUsuario

create proc MostrarUsuario
as
select *from Usuario
go
exec MostrarUsuario


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
@Telefono  varchar(100) ,
@Email  varchar(300) ,
@SitioWeb  varchar(30), 
@Facebook  varchar (100),
@Twitter  varchar (100),
@IG  varchar (100)
as
insert into Usuario values (@Username, @Password, @Tipo, @Nombre, @Apellido1,@Apellido2, @Provincia,@Canton,@Distrito,@Direccion,@Telefono,@Email,@SitioWeb,@Facebook,@Twitter,@IG)
go
exec InsertarUsuario 'Entrenador', '1234',0,'Admin','Apellido1','Apellido2','Provincia','Provincia','Provincia','Provincia','Provincia','Provincia','','','',''


--stored procedure para modificar Usuario
create proc UpdateUsuario
@Id int,
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
Update Usuario set UsernameUsuario =@Username,Password = @Password,TipoUsuario = @Tipo,nombreUsuario= @Nombre,apellido1Usuario= @Apellido1,apellido2Usuario= @Apellido2,provinciaUsuario= @Provincia,cantonUsuario= @Canton,distritoUsuario= @Distrito,direccionUsuario= @Direccion,telefonoUsuario= @Telefono,correoElectronicoUsuario= @Email,sitiowebUsuario= @SitioWeb,perfilFBUsuario= @Facebook,perfilTWUsuario= @Twitter,perfilIGUsuario= @IG
where UsuarioID = @ID
go

--stored procedure para Eliminar Usuario

create proc EliminarUsuario
@IDUsuarioEliminar int
as
delete from Usuario where UsuarioID = @IDUsuarioEliminar
go
create proc InsertarBitacora
@Dia VARCHAR (100),
@mes VARCHAR (100),
@Año Varchar (100),
@Descripcion VARCHAR (100),
@IDEntrenador int
as
insert into Bitacora values(@Dia, @mes,@Año,@Descripcion,@IDEntrenador)
go

create proc MostrarBitacora
@IDUser int
as
select *from Bitacora 
where UserIDBitacora = @IDUser
go


create proc EditarrBitacora
@IDBitacora int,
@Dia VARCHAR (100),
@mes VARCHAR (100),
@Año Varchar (100),
@Descripcion VARCHAR (100),
@IDEntrenador int
as
Update Bitacora set Dia= @Dia,mes= @mes,año= @Año, Descripcion =  @Descripcion, UserIDBitacora = @IDEntrenador
go


create proc EliminarBitacora
@IDbitacora int
as
delete from Bitacora where ID_Bitacora = @IDbitacora
go