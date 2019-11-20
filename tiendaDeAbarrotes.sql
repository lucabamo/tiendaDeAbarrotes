--Script para la base de datos de una tienda de abarrotes--
CREATE DATABASE TiendaAbarrotes
USE TiendaAbarrotes

CREATE SCHEMA Empresa
CREATE SCHEMA Transaccion
CREATE SCHEMA Inventario

--Tabla Empleado--
CREATE TABLE Empresa.Empleado(
	IdEmpleado BIGINT IDENTITY(1,1) NOT NULL,
	Nombre VARCHAR(200) NOT NULL,
	Domicilio VARCHAR(200) NOT NULL,
	FechaNac DATE NOT NULL,
	Edad INT, --Usado en trigger calcula edad--
	Usuario VARCHAR(200) NOT NULL,
	Contrasenia VARCHAR(100) NOT NULL,
	CONSTRAINT PK_EMPLEADO PRIMARY KEY(IdEmpleado)
)

--Tabla proveedor--
CREATE TABLE Empresa.Proveedor(
	IdProveedor BIGINT IDENTITY(1,1) NOT NULL,
	Nombre VARCHAR(200) NOT NULL,
	Telefono VARCHAR(80) NOT NULL,
	Email VARCHAR(200) NOT NULL,
	RFC VARCHAR(100) NOT NULL,
	DomicilioFiscal VARCHAR(200) NOT NULL,
	CONSTRAINT PK_PROVEEDOR PRIMARY KEY(IdProveedor)
)

--Tabla Producto--
CREATE TABLE Inventario.Producto(
	IdProducto BIGINT IDENTITY(1,1) NOT NULL,
	Nombre VARCHAR(200) NOT NULL,
	Existencia INT NOT NULL, --Aqu� est� bien este tipo de dato?--
	CostoProveedor REAL NOT NULL,
	CostoVenta REAL NOT NULL,
	CONSTRAINT PK_PRODUCTO PRIMARY KEY(IdProducto),
)

DROP TABLE Inventario.Producto



--Tabla Venta--
CREATE TABLE Transaccion.Venta(
	IdVenta BIGINT IDENTITY(1,1) NOT NULL,
	IdEmpleado BIGINT NOT NULL,
	FechaVenta DATE NOT NULL,
	Total REAL NOT NULL,
	CONSTRAINT PK_VENTA1 PRIMARY KEY(IdVenta),
	CONSTRAINT FK_EMPLEADO1 FOREIGN KEY(IdEmpleado) REFERENCES Empresa.Empleado(IdEmpleado)
)


CREATE TABLE Transaccion.Promocion(
	IdPromocion BIGINT IDENTITY(1,1) NOT NULL,
	IdProducto BIGINT NOT NULL,
	FechaInicio DATE NOT NULL,
	FechaFinal DATE NOT NULL,
	Descuento REAL NOT NULL, --Preguntar a la maestra--
	CONSTRAINT PK_PROMOCION PRIMARY KEY(IdPromocion),
	CONSTRAINT FK_PRODUCTO2 FOREIGN KEY(IdProducto) REFERENCES Inventario.Producto(IdProducto)
)

--Tabla detalle venta--
CREATE TABLE Transaccion.DetalleVenta(
	IdDetalleVenta BIGINT IDENTITY(1,1) NOT NULL,
	IdVenta BIGINT NOT NULL,
	IdPromocion BIGINT NOT NULL,
	IdProducto BIGINT NOT NULL,
	Cantidad INT NOT NULL,
	Subtotal REAL, --Usado para calcular subtotal--
	CONSTRAINT PK_DETALLEVENTA PRIMARY KEY (IdDetalleVenta),
	CONSTRAINT FK_VENTA2 FOREIGN KEY(IdVenta) REFERENCES Transaccion.Venta(IdVenta),
	CONSTRAINT FK_PROMOCION FOREIGN KEY(IdPromocion) REFERENCES Transaccion.Promocion(IdPromocion),
	CONSTRAINT FK_PRODUCTO1 FOREIGN KEY(IdProducto) REFERENCES Inventario.Producto(IdProducto)
)


CREATE TABLE Transaccion.Compra(
	IdCompra BIGINT IDENTITY(1,1) NOT NULL,
	IdProveedor BIGINT NOT NULL,
	IdEmpleado BIGINT NOT NULL,
	Fecha DATE NOT NULL,
	Total REAL NOT NULL,
	CONSTRAINT PK_COMPRA PRIMARY KEY(IdCompra),
	CONSTRAINT FK_PROVEEDOR1 FOREIGN KEY(IdProveedor) REFERENCES Empresa.Proveedor(IdProveedor),
	CONSTRAINT FK_EMPLEADO2 FOREIGN KEY(IdEmpleado) REFERENCES Empresa.Empleado(IdEmpleado)
)

CREATE TABLE Transaccion.DetalleCompra(
	IdDetalleCompra BIGINT IDENTITY(1,1) NOT NULL,
	IdCompra BIGINT NOT NULL,
	IdProducto BIGINT NOT NULL,
	Cantidad INT NOT NULL,
	Subtotal REAL,
	CONSTRAINT PK_DETALLECOMPRA PRIMARY KEY (IdDetalleCompra),
	CONSTRAINT FK_COMPRA1 FOREIGN KEY(IdCompra) REFERENCES Transaccion.Compra(IdCompra),
	CONSTRAINT FK_PRODUCTO3 FOREIGN KEY(IdProducto) REFERENCES Inventario.Producto(IdProducto)
)

DROP TABLE Transaccion.DetalleCompra

CREATE TABLE Transaccion.Devolucion(
	IdDevolucion BIGINT IDENTITY(1,1) NOT NULL,
	IdEmpleado BIGINT NOT NULL,
	IdVenta BIGINT NOT NULL,
	Fecha DATE NOT NULL,
	Motivo VARCHAR(300) NOT NULL,
	Monto REAL NOT NULL,
	CONSTRAINT PK_DEVOLUCION PRIMARY KEY(IdDevolucion),
	CONSTRAINT FK_EMPLEADO3 FOREIGN KEY(IdEmpleado) REFERENCES Empresa.Empleado(IdEmpleado),
	CONSTRAINT FK_VENTA3 FOREIGN KEY(IdVenta) REFERENCES Transaccion.Venta(IdVenta),
)

CREATE TABLE Transaccion.DetalleDevolucion(
	IdDevolucion BIGINT NOT NULL,
	IdProducto BIGINT NOT NULL,
	Cantidad INT NOT NULL,
	CONSTRAINT FK_DEVOLUCION1 FOREIGN KEY(IdDevolucion) REFERENCES Transaccion.Devolucion(IdDevolucion),
	CONSTRAINT FK_PRODUCTO4 FOREIGN KEY(IdProducto) REFERENCES Inventario.Producto(IdProducto)
)

CREATE TABLE Transaccion.Entrega(
	IdEntrega BIGINT IDENTITY(1,1) NOT NULL,
	IdProveedor BIGINT NOT NULL,
	IdEmpleado BIGINT NOT NULL,
	IdDevolucion BIGINT NOT NULL,
	FechaEntrega DATE NOT NULL,
	CONSTRAINT PK_ENTREGA PRIMARY KEY(IdEntrega),
	CONSTRAINT FK_PROVEEDOR2 FOREIGN KEY(IdProveedor) REFERENCES Empresa.Proveedor(IdProveedor),
	CONSTRAINT FK_EMPLEADO4 FOREIGN KEY(IdEmpleado) REFERENCES Empresa.Empleado(IdEmpleado),
	CONSTRAINT FK_DEVOLUCION2 FOREIGN KEY(IdDevolucion) REFERENCES Transaccion.Devolucion(IdDevolucion)
)

--Disparador para calcular la edad de un empleado al momento de la inserci�n--
CREATE TRIGGER Empresa.calculaEdad
ON Empresa.Empleado
AFTER INSERT, UPDATE
AS 
BEGIN 
	SET NOCOUNT ON
	DECLARE @ID AS BIGINT
	DECLARE @Edad AS INT
	SELECT @ID = idEmpleado FROM inserted 
	UPDATE Empresa.Empleado set Edad = CASE 
	WHEN dateadd(year, datediff (year, FechaNac, getdate()), FechaNac) > getdate()
            THEN datediff(year, FechaNac, getdate()) - 1
            ELSE datediff(year, FechaNac, getdate())
	END
	WHERE idEmpleado = @ID
END

--Disparador para insertar un detalle devoluci�n despu�s de haber insertado una devoluci�n
CREATE TRIGGER Transaccion.creaDetalleDevolucion
ON Transaccion.Devolucion
AFTER INSERT
AS 
BEGIN 
	SET NOCOUNT ON
	DECLARE @IdDevolucion AS BIGINT
	DECLARE @IdProducto AS BIGINT
	DECLARE @Cantidad AS INT 
	SELECT @IdDevolucion = Insertada.IdDevolucion, @IdProducto = DetalleVenta.IdProducto,
	@Cantidad = DetalleVenta.Cantidad FROM inserted Insertada
	INNER JOIN Transaccion.DetalleVenta DetalleVenta ON Insertada.IdVenta = DetalleVenta.IdVenta
	INSERT INTO Transaccion.DetalleDevolucion VALUES(@IdDevolucion,@IdProducto,@Cantidad)
END

--Trigger para calcular el subtotal de un detalle de venta a partir del precio del producto y la cantidad
CREATE TRIGGER Transaccion.calculaSubtotal
ON Transaccion.DetalleVenta
AFTER INSERT,UPDATE
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @IdVenta AS BIGINT
	DECLARE @IdProducto AS BIGINT
	DECLARE @Cantidad AS INT
	DECLARE @CostoVenta AS REAL
	SELECT @IdVenta = Insertada.IdVenta, @IdProducto = Insertada.IdProducto,
	@Cantidad = Insertada.Cantidad, @CostoVenta = Producto.CostoVenta FROM inserted Insertada
	INNER JOIN Inventario.Producto AS Producto ON Producto.IdProducto = Insertada.IdProducto
	UPDATE Transaccion.DetalleVenta SET Subtotal = (@CostoVenta * @Cantidad)
	WHERE IdVenta = @IdVenta AND IdProducto = @IdProducto
END

--Trigger para calcular el subtotal de un detalle de compra a partir del precio del producto y la cantidad
CREATE TRIGGER Transaccion.calculaSubtotalCompra
ON Transaccion.DetalleCompra
AFTER INSERT,UPDATE
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @IdCompra AS BIGINT
	DECLARE @IdProducto AS BIGINT
	DECLARE @Cantidad AS INT
	DECLARE @CostoProveedor AS REAL
	SELECT @IdCompra = Insertada.IdCompra, @IdProducto = Insertada.IdProducto,
	@Cantidad = Insertada.Cantidad, @CostoProveedor = Producto.CostoProveedor FROM inserted Insertada
	INNER JOIN Inventario.Producto AS Producto ON Producto.IdProducto = Insertada.IdProducto
	UPDATE Transaccion.DetalleCompra SET Subtotal = (@CostoProveedor * @Cantidad)
	WHERE IdCompra = @IdCompra AND IdProducto = @IdProducto
END
--Trigger para actualizar la existencia del producto despu�s de una devoluci�n
CREATE TRIGGER Transaccion.existenciaProductoDevolucion
ON Transaccion.Devolucion
AFTER INSERT,UPDATE
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @IdDevolucion AS BIGINT
	DECLARE @IdProducto AS BIGINT 
	DECLARE @Cantidad AS INT
	SELECT @IdDevolucion = Insertada.IdDevolucion, @IdProducto = DetalleVenta.IdProducto , 
	@Cantidad = DetalleDevolucion.Cantidad  FROM inserted Insertada 
	INNER JOIN Transaccion.DetalleVenta DetalleVenta ON Insertada.IdVenta = DetalleVenta.IdVenta
	INNER JOIN Transaccion.DetalleDevolucion DetalleDevolucion 
	ON DetalleVenta.IdProducto = DetalleDevolucion.IdProducto 
	AND Insertada.IdDevolucion = DetalleDevolucion.IdDevolucion
	UPDATE Inventario.Producto SET Existencia = Existencia+@Cantidad
	WHERE IdProducto = @IdProducto
END


---Trigger para actualizar el inventario cuando se realiza una compra--
CREATE TRIGGER Transaccion.ActualizarExistenciasCompra
	ON Transaccion.DetalleCompra
	AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @ID AS BIGINT
	DECLARE @Cantidad AS INT
	DECLARE @Existencias AS INT
	DECLARE @Resultado AS INT
	SELECT @ID = IdProducto, @Cantidad = Cantidad FROM inserted
	SELECT @Existencias = Existencia FROM Inventario.Producto WHERE IdProducto = @ID
	SELECT @Resultado = @Existencias + @Cantidad
	UPDATE Inventario.Producto SET Existencia = @Resultado WHERE IdProducto = @ID
END

--Trigger para actualizar el inventario cuando se realiza una venta--
CREATE TRIGGER Transaccion.ActualizarExistenciasVenta
	ON Transaccion.DetalleVenta
	AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @ID AS BIGINT
	DECLARE @Cantidad AS INT
	DECLARE @Existencias AS INT
	DECLARE @Resultado AS INT
	SELECT @ID = IdProducto, @Cantidad = Cantidad FROM inserted
	SELECT @Existencias = Existencia FROM Inventario.Producto WHERE IdProducto = @ID
	SELECT @Resultado = @Existencias - @Cantidad
	UPDATE Inventario.Producto SET Existencia = @Resultado WHERE IdProducto = @ID
END

--Trigger para calcular el descuento de una promoción y validar la fecha--
--CREATE TRIGGER Transaccion.validaPromocion
--ON

--Reglas
CREATE RULE R_Existencias AS @Existencia >= 0 AND @Existencia <=100

EXEC sp_bindrule 'R_Existencias', 'Inventario.Producto.Existencia' 

CREATE RULE R_Cantidad AS @Cantidad >= 1 AND @Cantidad <= 100
EXEC sp_bindrule 'R_Cantidad', 'Transaccion.DetalleCompra.Cantidad'

CREATE RULE R_Email AS @Email LIKE '%_@__%.__%'
EXEC sp_bindrule 'R_Email', 'Empresa.Proveedor.Email'



