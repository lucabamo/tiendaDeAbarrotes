--Scrip para la base de datos de una tienda de abarrotes--
CREATE DATABASE TiendaAbarrotes
USE TiendaAbarrotes

CREATE SCHEMA Administracion
CREATE SCHEMA Transaccion

CREATE TABLE Administracion.Empleado(
	IdEmpleado BIGINT IDENTITY(1,1) NOT NULL,
	Nombre VARCHAR(200) NOT NULL,
	Domicilio VARCHAR(200) NOT NULL,
	FechaNac DATE NOT NULL,
	Edad INT,
	Usuario VARCHAR(200) NOT NULL,
	Contrasenia VARCHAR(100) NOT NULL,
	CONSTRAINT PK_EMPLEADO PRIMARY KEY(IdEmpleado)
)

CREATE TABLE Transaccion.Venta(
	IdVenta BIGINT IDENTITY(1,1) NOT NULL,
	IdEmpleado BIGINT NOT NULL,
	FechaVenta DATE NOT NULL,
	Total REAL NOT NULL,
	CONSTRAINT PK_VENTA PRIMARY KEY(IdVenta),
	CONSTRAINT FK_EMPLEADO FOREIGN KEY(IdEmpleado) REFERENCES Administracion.Empleado(IdEmpleado)
)