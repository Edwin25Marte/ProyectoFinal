create database PAlquiler
go
use PAlquiler
go 
create table Client(
	ClienteId int identity primary key not null,
	Nombres varchar(30),
	Apellidos varchar(30),
	Direccion varchar(255),
	FechaNacimineto datetime,
	FechaReg datetime,
	Telefono varchar(12),
	Celular varchar(12),
	Email varchar(100)
);

go
create table Peli(
	PeliculaId int identity primary key not null,
	GeneroId int,
	ActorId int, 
	Nombre varchar(100),
	Precio decimal, 
	FechaSalida datetime,
	Sipnosis varchar(255)
);

go 
create table Fact(
	FacturaId int identity primary key not null,
	ClienteId int, 
	Fecha datetime,
	Monto decimal,
	Observaciones varchar(255)
);

go
create table FactDetalle(
	DetalleId int identity primary key not null,
	FacturaId int, 
	PeliculaId int,
	Cliente varchar(50),
	Pelicula varchar(30),
	Cantidad int,
	Precio decimal, 
	Importe decimal
);

go
create table Actores(
	ActorId int identity primary key not null,
	Nombre varchar(30),
	FechaDebut datetime,
	FechaNacimiento datetime
);

go 
create table Generos(
	GeneroId int identity primary key not null,
	Nombre varchar(30),
	Fecha datetime,
	Descripcion varchar(255)
);

go
create table Us(
	UsuarioId int primary key identity(1,1),
	Nombre varchar(30),
	NombreUsuario varchar(50),
	Pass varchar(20),
	Fecha datetime,
	Telefono varchar(12),
	Direccion varchar(255)
);

go 
create table GenAct(
	GAId int identity primary key not null,
	ActorId int,
	GeneroId int,
	Actor varchar(30),
	Genero varchar(30)
);

go
set dateformat dmy;
go
insert into Us(Nombre,NombreUsuario,Pass,Fecha,Telefono, Direccion) values('Edwin', 'root', 'edwin25', '03/04/2018', '829-986-1905', 'Salcedo');

