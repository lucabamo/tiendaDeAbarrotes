--
DROP DATABASE TiendaAbarrotes

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
	CONSTRAINT PK_PROVEEDOR PRIMARY KEY(IdProveedor),
	CONSTRAINT UQ_EMAIL UNIQUE (Email),
	CONSTRAINT UQ_RFC   UNIQUE (RFC)
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

--DROP TABLE Inventario.Producto

--Tabla Venta--
CREATE TABLE Transaccion.Venta(
	IdVenta BIGINT IDENTITY(1,1) NOT NULL,
	IdEmpleado BIGINT NOT NULL,
	FechaVenta DATE NOT NULL,
	Total REAL NOT NULL,
	CONSTRAINT PK_VENTA1 PRIMARY KEY(IdVenta),
	CONSTRAINT FK_EMPLEADO1 FOREIGN KEY(IdEmpleado) REFERENCES Empresa.Empleado(IdEmpleado)
)

--Tabla de una promoción--
CREATE TABLE Transaccion.Promocion(
	IdPromocion BIGINT IDENTITY(1,1) NOT NULL,
	IdProducto BIGINT NOT NULL,
	FechaInicio DATE NOT NULL,
	FechaFinal DATE NOT NULL,
	Descuento REAL NOT NULL, --Se maneja por porcentaje, por ejemplo .10 es el 10 porciente de descuento 
	--al precio del producto
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

--DROP TABLE Transaccion.DetalleCompra

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
	IdDetalleDevolucion BIGINT IDENTITY(1,1) NOT NULL,
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

--DROP TRIGGER Transaccion.calculaSubtotal


--FINAL TRIGGER--
--Trigger para calcular el subtotal de un detalle de venta a partir del precio del producto y la cantidad
CREATE TRIGGER Transaccion.calculaSubtotal
ON Transaccion.DetalleVenta
AFTER INSERT,UPDATE
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @IdVenta AS BIGINT
	DECLARE @IdDetalle AS BIGINT 
	DECLARE @IdProducto AS BIGINT
	DECLARE @Cantidad AS INT
	DECLARE @CostoVenta AS REAL
	DECLARE @Resultado AS REAL
	DECLARE @TotalVenta AS REAL
	DECLARE @Subtotal AS REAL
	DECLARE @Descuento AS REAL
	DECLARE @IdPromocion AS BIGINT
	DECLARE @FechaInicio AS DATE
	DECLARE @FechaFinal AS DATE
	SELECT @IdVenta = Insertada.IdVenta, @IdProducto = Insertada.IdProducto, @IdDetalle = Insertada.IdDetalleVenta,
	@Cantidad = Insertada.Cantidad, @CostoVenta = Producto.CostoVenta,  @IdPromocion = Insertada.IdPromocion,
	@Descuento = Promocion.Descuento,  @FechaInicio = Promocion.FechaInicio, 
	@FechaFinal = Promocion.FechaFinal FROM inserted Insertada
	INNER JOIN Inventario.Producto AS Producto ON Producto.IdProducto = Insertada.IdProducto
	INNER JOIN Transaccion.Promocion AS Promocion ON Promocion.IdPromocion = Insertada.IdPromocion
	IF GETDATE() NOT BETWEEN @FechaInicio AND @FechaFinal 
	BEGIN
		UPDATE Transaccion.Promocion SET Descuento = 0
		WHERE IdPromocion = @IdPromocion 
	END
	UPDATE Transaccion.DetalleVenta SET Subtotal = (@CostoVenta * @Cantidad - (@Descuento * @CostoVenta * @Cantidad ))
	WHERE IdVenta = @IdVenta AND IdProducto = @IdProducto AND IdDetalleVenta = @IdDetalle
	SELECT @Subtotal = (@CostoVenta * @Cantidad)
	SELECT @TotalVenta = Total FROM Transaccion.Venta WHERE IdVenta = @IdVenta
	SELECT @Resultado = @TotalVenta + @Subtotal
	UPDATE Transaccion.Venta SET Total = @Resultado WHERE IdVenta = @IdVenta
END

--Trigger para actualizar el total de la venta despues de eliminar
CREATE TRIGGER Transaccion.actualizaTotalVenta
ON Transaccion.DetalleVenta
AFTER DELETE
AS 
BEGIN
	SET NOCOUNT ON
	DECLARE @IdVenta AS BIGINT
	DECLARE @Resultado AS REAL
	DECLARE @TotalVenta AS REAL
	DECLARE @Subtotal AS REAL
	SELECT @IdVenta = IdVenta, @Subtotal = Subtotal FROM deleted
    SELECT @TotalVenta = Total FROM Transaccion.Venta WHERE IdVenta = @IdVenta
	SELECT @Resultado = @TotalVenta - @Subtotal
	UPDATE Transaccion.Venta SET Total = @Resultado WHERE IdVenta = @IdVenta
END

--Trigger para calcular el subtotal de un detalle de compra a partir del precio del producto y la cantidad
CREATE TRIGGER Transaccion.calculaSubtotalCompra
ON Transaccion.DetalleCompra
AFTER INSERT,UPDATE
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @IdCompra AS BIGINT
	DECLARE @IdDetalle AS BIGINT
	DECLARE @IdProducto AS BIGINT
	DECLARE @Cantidad AS INT
	DECLARE @CostoProveedor AS REAL
	DECLARE @Resultado AS REAL
	DECLARE @TotalCompra AS REAL
	DECLARE @Subtotal AS REAL
	SELECT @IdCompra = Insertada.IdCompra, @IdProducto = Insertada.IdProducto, @IdDetalle = Insertada.IdDetalleCompra,
	@Cantidad = Insertada.Cantidad, @CostoProveedor = Producto.CostoProveedor FROM inserted Insertada
	INNER JOIN Inventario.Producto AS Producto ON Producto.IdProducto = Insertada.IdProducto
	UPDATE Transaccion.DetalleCompra SET Subtotal = (@CostoProveedor * @Cantidad)
	WHERE IdCompra = @IdCompra AND IdProducto = @IdProducto AND IdDetalleCompra = @IdDetalle
	SELECT @Subtotal = (@CostoProveedor * @Cantidad)
	SELECT @TotalCompra = Total FROM Transaccion.Compra WHERE IdCompra = @IdCompra
	SELECT @Resultado = @TotalCompra + @Subtotal
	UPDATE Transaccion.Compra SET Total = @Resultado WHERE IdCompra = @IdCompra
END

--Trigger para actualizar inventario al momento de un compra al proveedor
CREATE TRIGGER Transaccion.actualizaTotalCompra
ON Transaccion.DetalleCompra
AFTER DELETE
AS 
BEGIN
	SET NOCOUNT ON
	DECLARE @IdCompra AS BIGINT
	DECLARE @Resultado AS REAL
	DECLARE @TotalCompra AS REAL
	DECLARE @Subtotal AS REAL
	SELECT @IdCompra = IdCompra, @Subtotal = Subtotal FROM deleted
    SELECT @TotalCompra = Total FROM Transaccion.Compra WHERE IdCompra = @IdCompra
	SELECT @Resultado = @TotalCompra - @Subtotal
	UPDATE Transaccion.Compra SET Total = @Resultado WHERE IdCompra = @IdCompra
END

DROP TRIGGER Transaccion.existenciaProductoDevolucion

--Trigger para actualizar la existencia del producto despu�s de una devoluci�n
CREATE TRIGGER Transaccion.existenciaProductoDevolucion
ON Transaccion.DetalleDevolucion
AFTER INSERT,UPDATE
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @IdDevolucion AS BIGINT
	DECLARE @IdProducto AS BIGINT 
	DECLARE @Cantidad AS INT
	DECLARE @Costo AS REAL
	SELECT @IdDevolucion = Insertada.IdDevolucion, @IdProducto = Insertada.IdProducto , 
	@Cantidad = Insertada.Cantidad, @Costo = producto.CostoVenta  FROM inserted Insertada 
	INNER JOIN Inventario.Producto AS producto ON Insertada.IdProducto = producto.IdProducto
	UPDATE Inventario.Producto SET Existencia = Existencia+@Cantidad
	WHERE IdProducto = @IdProducto
	UPDATE Transaccion.Devolucion SET Monto = (@Cantidad * @Costo)
	WHERE IdDevolucion = @IdDevolucion
END


--Actualiza el total devolucion después de eliminar un detalle
CREATE TRIGGER Transaccion.actualizaTotalDevolucion
ON Transaccion.DetalleDevolucion
AFTER DELETE
AS 
BEGIN
	SET NOCOUNT ON
	DECLARE @IdDevolucion AS BIGINT
	DECLARE @Resultado AS REAL
	DECLARE @TotalDev AS REAL
	DECLARE @Cantidad AS INT
	DECLARE @CostoProducto AS INT
	SELECT @IdDevolucion = detalleDev.IdDevolucion, 
	@Cantidad = detalleDev.Cantidad, @CostoProducto = producto.CostoVenta FROM deleted AS detalleDev
	INNER JOIN Inventario.Producto AS producto ON detalleDev.IdProducto = producto.IdProducto
    SELECT @TotalDev = Monto FROM Transaccion.Devolucion WHERE IdDevolucion = @IdDevolucion
	SELECT @Resultado = @TotalDev - (@CostoProducto * @Cantidad)
	UPDATE Transaccion.Devolucion SET Monto = @Resultado WHERE IdDevolucion = @IdDevolucion
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

--Reglas
--Regla numerica que restringe el número de existencias de un producto
CREATE RULE R_Existencias AS @Existencia BETWEEN 0 AND 100

EXEC sp_bindrule 'R_Existencias', 'Inventario.Producto.Existencia' 

--Cantidad de producto que se puede comprar
CREATE RULE R_Cantidad AS @Cantidad BETWEEN 1 AND 100
EXEC sp_bindrule 'R_Cantidad', 'Transaccion.DetalleCompra.Cantidad'

--Regla texto para el correo del proveedor
CREATE RULE R_Email AS @Email LIKE '%_@__%.__%'
EXEC sp_bindrule 'R_Email', 'Empresa.Proveedor.Email'


------------------EXTRA----------------------------------------------------

DROP TRIGGER Transaccion.validaPromocion

--Trigger para validar la fecha de una promoción--
CREATE TRIGGER Transaccion.validaFechaPromocion
	ON Transaccion.DetalleVenta
	AFTER INSERT
	AS
	BEGIN 
		SET NOCOUNT ON
		DECLARE @IdDetalle AS BIGINT
		DECLARE @IdPromocion AS BIGINT 
		DECLARE @Descuento AS REAL
		DECLARE @FechaInicio AS DATE
		DECLARE @FechaFinal AS DATE
		SELECT @IdDetalle = Insertada.IdDetalleVenta, @IdPromocion = Insertada.IdPromocion,
		@Descuento = Promocion.Descuento, @FechaInicio = Promocion.FechaInicio, 
		@FechaFinal = Promocion.FechaFinal FROM inserted Insertada
		INNER JOIN Transaccion.Promocion AS Promocion ON Promocion.IdPromocion = Insertada.IdPromocion	
		IF GETDATE() NOT BETWEEN @FechaInicio AND @FechaFinal 
			BEGIN
				UPDATE Transaccion.Promocion SET Descuento = 0
				WHERE IdPromocion = @IdPromocion 
			END
END 

--Trigger para calcular el descuento de una promoción y validar la fecha--
CREATE TRIGGER Transaccion.validaPromocion
	ON Transaccion.DetalleVenta
	AFTER INSERT
	AS
	BEGIN 
		SET NOCOUNT ON
		DECLARE @IdDetalle AS BIGINT
		DECLARE @IdVenta AS BIGINT
		DECLARE @IdProducto AS BIGINT
		DECLARE @IdPromocion AS BIGINT 
		DECLARE @Cantidad AS INT
		DECLARE @CostoVenta AS REAL
		DECLARE @Descuento AS REAL
		SELECT @IdDetalle = Insertada.IdDetalleVenta, @IdVenta = Insertada.IdVenta, 
		@IdProducto = Insertada.IdProducto, @IdPromocion = Insertada.IdPromocion,
		@Cantidad = Insertada.Cantidad, @CostoVenta = Producto.CostoVenta, 
		@Descuento = Promocion.Descuento FROM inserted Insertada
		INNER JOIN Inventario.Producto AS Producto ON Producto.IdProducto = Insertada.IdProducto
		INNER JOIN Transaccion.Promocion AS Promocion ON Promocion.IdPromocion = Insertada.IdPromocion
		UPDATE Transaccion.DetalleVenta SET Subtotal = (@CostoVenta * @Cantidad - (@Descuento * @CostoVenta * @Cantidad ))
		WHERE IdVenta = @IdVenta AND IdProducto = @IdProducto AND IdDetalleVenta = @IdDetalle
END 


--Trigger para calcular el subtotal de un detalle de venta a partir del precio del producto y la cantidad
CREATE TRIGGER Transaccion.calculaSubtotal
ON Transaccion.DetalleVenta
AFTER INSERT,UPDATE
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @IdVenta AS BIGINT
	DECLARE @IdDetalle AS BIGINT 
	DECLARE @IdProducto AS BIGINT
	DECLARE @Cantidad AS INT
	DECLARE @CostoVenta AS REAL
	DECLARE @Resultado AS REAL
	DECLARE @TotalVenta AS REAL
	DECLARE @Subtotal AS REAL
	SELECT @IdVenta = Insertada.IdVenta, @IdProducto = Insertada.IdProducto, @IdDetalle = Insertada.IdDetalleVenta,
	@Cantidad = Insertada.Cantidad, @CostoVenta = Producto.CostoVenta FROM inserted Insertada
	INNER JOIN Inventario.Producto AS Producto ON Producto.IdProducto = Insertada.IdProducto
	UPDATE Transaccion.DetalleVenta SET Subtotal = (@CostoVenta * @Cantidad)
	WHERE IdVenta = @IdVenta AND IdProducto = @IdProducto AND IdDetalleVenta = @IdDetalle
	SELECT @Subtotal = (@CostoVenta * @Cantidad)
	SELECT @TotalVenta = Total FROM Transaccion.Venta WHERE IdVenta = @IdVenta
	SELECT @Resultado = @TotalVenta + @Subtotal
	UPDATE Transaccion.Venta SET Total = @Resultado WHERE IdVenta = @IdVenta
END

------------NO SIRVE-------------
DROP TRIGGER Transaccion.creaDetalleDevolucion
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

SELECT DetalleDevolucion.IdDetalleDevolucion,Devolucion.Motivo, Producto.Nombre,
DetalleDevolucion.Cantidad 
FROM Transaccion.DetalleDevolucion AS DetalleDevolucion
INNER JOIN Transaccion.Devolucion Devolucion ON Devolucion.IdDevolucion = DetalleDevolucion.IdDevolucion 
INNER JOIN Inventario.Producto AS Producto ON Producto.IdProducto = DetalleDevolucion.IdProducto
ORDER BY DetalleDevolucion.IdDetalleDevolucion

SELECT detalleVenta.IdDetalleVenta,detalleVenta.Cantidad FROM Transaccion.DetalleVenta AS detalleVenta 
INNER JOIN Transaccion.Venta AS venta ON venta.IdVenta = detalleVenta.IdVenta
INNER JOIN Transaccion.Devolucion AS devolucion ON devolucion.IdVenta = detalleVenta.IdVenta 
WHERE detalleVenta.IdProducto = 2 AND venta.IdVenta = 2



SELECT * FROM Transaccion.DetalleVenta
SELECT * FROM Transaccion.DetalleDevolucion
SELECT * FROM Transaccion.Devolucion

SELECT DISTINCT producto.IdProducto, producto.Nombre FROM Inventario.Producto AS producto 
INNER JOIN Transaccion.DetalleDevolucion AS detalledev ON detalledev.IdProducto = producto.IdProducto
WHERE detalledev.IdDevolucion = 1
ORDER BY producto.IdProducto

SELECT * FROM Empresa.Empleado WHERE IdEmpleado = 3
	