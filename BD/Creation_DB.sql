
use DBAPPTIENDA;

go

create table Rol(
idRol int primary key identity,
descripcion varchar(50),
fechaRegistro datetime default getdate()
)

go

create table Permiso(
idPermiso int primary key identity,
idRol int references Rol(idRol),
vista varchar(50),
fechaRegistro datetime default getdate()
)

go

create table Proveedor(
idProveedor int primary key identity,
documento varchar(50),
razonSocial varchar(50),
correo varchar(50),
telefono varchar(50),
estado bit,
fechaRegistro datetime default getdate()
)

go

create table Cliente(
idCliente int primary key identity,
documento varchar(50),
nombre varchar(50),
correo varchar(50),
telefono varchar(50),
estado bit,
fechaRegistro datetime default getdate()
)

go

create table Usuario(
idUsuario int primary key identity,
documento varchar(50),
apodo varchar(50),
nombre varchar(50),
correo varchar(50),
contraseña varchar(50),
idRol int references Rol(idRol),
estado bit,
fechaRegistro datetime default getdate()
)

go

create table Categoria(
idCategoria int primary key identity,
descripcion varchar(100),
estado bit,
fechaRegistro datetime default getdate()
)

go

create table Producto(
idProducto int primary key identity,
idCategoria int references Categoria(idCategoria),
codigo varchar(50),
nombre varchar(50),
descripcion varchar(50),
stock int not null default 0,
precioCompra decimal(10,2) default 0,
precioVenta decimal(10,2) default 0,
estado bit,
fechaRegistro datetime default getdate()
)

go

create table Compra(
idCompra int primary key identity,
idUsuario int references Usuario(idUsuario),
IdProveedor int references Proveedor(idProveedor),
tipoDocumento varchar(50),
numeroDocumento varchar(50),
montoTotal decimal(10,2),
fechaRegistro datetime default getdate()
)


go


create table Detalle_Compra(
idDetalleCompra int primary key identity,
idCompra int references Compra(idCompra),
idProducto int references Producto(idProducto),
precioCompra decimal(10,2) default 0,
precioVenta decimal(10,2) default 0,
cantidad int,
montoTotal decimal(10,2),
fechaRegistro datetime default getdate()
)

go

create table Venta(
idVenta int primary key identity,
idUsuario int references Usuario(idUsuario),
tipoDocumento varchar(50),
numeroDocumento varchar(50),
documentoCliente varchar(50),
nombreCliente varchar(100),
montoPago decimal(10,2),
montoCambio decimal(10,2),
montoTotal decimal(10,2),
fechaRegistro datetime default getdate()
)


go


create table Detalle_Venta(
idDetalleVenta int primary key identity,
idVenta int references Venta(idVenta),
idProducto int references Producto(idProducto),
precioVenta decimal(10,2),
cantidad int,
subTotal decimal(10,2),
fechaRegistro datetime default getdate()
)

go

create table Negocio(
idNegocio int primary key,
nombre varchar(60),
rfc varchar(60),
direccion varchar(60),
logo varbinary(max) NULL
)

go

/* PROCEDIMIENTOS ALMACENADOS */

go



create PROC sp_registrarUsuario(
@documento varchar(50),
@apodo varchar(50),
@nombre varchar(50),
@correo varchar(50),
@clave varchar(50),
@idRol int,
@estado bit,
@IdResultado int output,
@mensaje varchar(500) output

)
as 
begin 

	set @IdResultado = 0
	
	set @mensaje = ''


	if not exists(select * from Usuario where documento = @documento)

		begin 
			insert into Usuario(documento, apodo, nombre, correo, contraseña, idRol, estado)
			values (@documento,@apodo, @nombre, @correo,@clave, @idRol, @estado)

			set @IdResultado = SCOPE_IDENTITY()
		end
	else
		set @mensaje = 'No se puede repetir el no. de documento, es una clave unica.'

end

go

create PROC sp_EditarUsuario(
@idUsuario int,
@documento varchar(50),
@apodo varchar(50),
@nombre varchar(50),
@correo varchar(50),
@clave varchar(50),
@idRol int,
@estado bit,
@Respuesta bit output,
@mensaje varchar(500) output

)
as 
begin 

	set @Respuesta = 0
	
	set @mensaje = ''


	if not exists(select * from Usuario where documento = @documento and idUsuario != @idUsuario)

		begin 
			update  Usuario set
			documento = @documento,
			apodo = @apodo,
			nombre = @nombre,
			correo = @correo,
			contraseña = @clave, 
			idRol = @idRol,
			estado = @estado

			where idUsuario = @idUsuario

			set @Respuesta = 1
		end
	else
		set @mensaje = 'No se puede repetir el no. de documento, es una clave unica.'

end

go

create PROC sp_EliminarUsuario(
@idUsuario int, 
@idRespuesta bit output,
@mensaje varchar(500) output

)as 
begin

	set @idRespuesta = 0;
	set @mensaje ='';
	declare @bandera bit = 1;

	if exists (select * from Compra c inner join Usuario u on u.idUsuario = c.idUsuario where u.idUsuario = @idUsuario)
		begin
			set @bandera = 0;
			set @idRespuesta = 0;
			set @mensaje =@mensaje + 'No se puede eliminar, el Usuario esta vinculado a una compra\n';

		end

	if exists (select * from Venta v inner join Usuario u on u.idUsuario = v.idUsuario where u.idUsuario = @idUsuario)
		begin
			set @bandera = 0;
			set @idRespuesta = 0;
			set @mensaje =@mensaje + 'No se puede eliminar, el Usuario esta vinculado a una venta\n';

		end

	if(@bandera = 1)
		begin
			delete from Usuario where idUsuario = @idUsuario;
			set @idRespuesta = 1;


		end

end

go

/* ---------- PROCEDIMIENTOS PARA CATEGORIA -----------------*/
go

create PROC sp_RegistrarCategoria(
@descripcion varchar(50),
@estado bit,
@resultado bit output,
@mensaje varchar(500) output

)as

begin

	set @resultado = 0

	if not exists (select * from categoria where descripcion = @descripcion)
	begin
		insert into Categoria(descripcion, estado) values (@descripcion, @estado)
		set @resultado = scope_identity()

	end
	else
		set @mensaje = 'No se puede repetir la descripcion de una categoria'

end


go

Create procedure sp_EditarCategoria(
@idcategoria int,
@descripcion varchar(50),
@estado bit,
@resultado bit output,
@mensaje varchar(500) output
)as 
begin

	set @resultado = 1
	if not exists(select * from Categoria where descripcion = @descripcion and idCategoria != @idcategoria)
		begin
			update categoria set descripcion = @descripcion, estado = @estado where idCategoria = @idcategoria
		end
	else
		begin
			set @resultado = 0
			set @mensaje = 'No se puede repetir la descripcion de la categoria'
		end
end

go

create procedure sp_EliminarCategoria(
@idcategoria int,
@resultado bit output,
@mensaje varchar(500) output

)as

begin

	set @resultado = 1
	if not exists(select * from Categoria c inner join Producto p on p.idCategoria = c.idCategoria where c.idCategoria = @idcategoria)
		begin
			delete top(1) from Categoria  where idCategoria = @idcategoria
		end
	else
		begin
			set @resultado = 0
			set @mensaje = 'La categoria esta vinculada a un producto, no se puede eliminar '
		end

end

go

/* ---------- PROCEDIMIENTOS PARA PRODUCTO -----------------*/
go

create PROC sp_RegistrarProducto(
@codigo varchar(50),
@nombre varchar(50),
@descripcion varchar(100),
@idCategoria int,
@stock int,
@precioVenta decimal(10,2),
@estado bit,
@resultado bit output,
@mensaje varchar(500) output

)as

begin

	set @resultado = 0
	if not exists(select * from Producto where codigo = @codigo)
	begin
		insert into Producto(codigo, nombre, descripcion, idCategoria, stock, precioVenta, estado) values (@codigo,@nombre, @descripcion, @idCategoria,@stock, @precioVenta, @estado)
		set @resultado = SCOPE_IDENTITY()
	end
	else
		set @mensaje = 'Ya existe un producto con el mismo codigo'


end

GO

create procedure sp_EditarProducto(
@idProducto int,
@codigo varchar(50),
@nombre varchar(50),
@descripcion varchar(100),
@idCategoria int,
@stock int,
@precioVenta decimal(10,2),
@estado bit,
@resultado bit output,
@mensaje varchar(500) output

)as

begin

	set @resultado = 1
	if not exists(select * from Producto where codigo = @codigo and idProducto != @idProducto)
	begin
		update Producto set  codigo = @codigo, nombre = @nombre, descripcion = @descripcion, idCategoria = @idCategoria,stock = @stock, precioVenta = @precioVenta, estado = @estado where idProducto = @idProducto
	end
	else
	begin
		set @resultado = 0
		set @mensaje = 'Ya existe un producto con el mismo codigo'
	end

end

go


create PROC sp_EliminarProducto(
@idProducto int,
@resultado bit output,
@mensaje varchar(500) output

)as

begin

	set @resultado = 0
	set @mensaje = ''
	declare @pasoReglas bit = 1

	if exists(select * from Detalle_Compra dc inner join Producto p on p.idProducto = dc.idProducto where p.idProducto = @idProducto)
	begin
		set @resultado = 0
		set @pasoReglas = 0
		set @mensaje = @mensaje + 'No se puede eliminar el producto, esta relacioado con una compra\n'
	end

	if exists(select * from Detalle_Venta dv inner join Producto p on p.idProducto = dv.idProducto where p.idProducto = @idProducto)
	begin
		set @resultado = 0
		set @pasoReglas = 0
		set @mensaje = @mensaje + 'No se puede eliminar el producto, esta relacioado con una venta\n'
	end

	if(@pasoReglas = 1)
	begin
		delete from Producto where idProducto = @idProducto
		set @resultado = 1
	end


end

go

/* ---------- PROCEDIMIENTOS PARA CLIENTE -----------------*/
go

create PROC sp_RegistrarCliente(
@documento varchar(50),
@nombre varchar(50),
@correo varchar(50),
@telefono varchar(50),
@estado bit,
@resultado bit output,
@mensaje varchar(500) output

)as

begin

	set @resultado = 0
	declare @idPersona int

	if not exists (select * from Cliente where documento = @documento )
	begin
		insert into Cliente(documento, nombre, correo, telefono, estado) values (@documento, @nombre, @correo, @telefono, @estado)
		set @resultado = scope_identity()

	end
	else
		set @mensaje = 'No se puede repetir el número de documento'

end

go

create PROC sp_EditarCliente(
@idCliente int,
@documento varchar(50),
@nombre varchar(50),
@correo varchar(50),
@telefono varchar(50),
@estado bit,
@resultado bit output,
@mensaje varchar(500) output

)as

begin

	set @resultado = 1
	declare @idPersona int

	if not exists (select * from Cliente where documento = @documento and idCliente != @idCliente )
	begin
		update Cliente set documento = @documento, nombre = @nombre, correo = @correo, telefono = @telefono, estado = @estado 
		where idCliente = @idCliente

	end
	else
	begin
		set @resultado = 0
		set @mensaje = 'No se puede repetir el número de documento'
	end

end

GO

/* ---------- PROCEDIMIENTOS PARA PROVEEDOR -----------------*/
go

create PROC sp_RegistrarProveedor(
@documento varchar(50),
@razonSocial varchar(50),
@correo varchar(50),
@telefono varchar(50),
@estado bit,
@resultado bit output,
@mensaje varchar(500) output

)as

begin

	set @resultado = 0
	declare @idPersona int

	if not exists (select * from Cliente where documento = @documento )
	begin
		insert into Proveedor(documento, razonSocial, correo, telefono, estado) values (@documento, @razonSocial, @correo, @telefono, @estado)
		set @resultado = scope_identity()

	end
	else
		set @mensaje = 'No se puede repetir el número de documento'

end

GO

create PROC sp_EditarProveedor(
@idProveedor int,
@documento varchar(50),
@razonSocial varchar(50),
@correo varchar(50),
@telefono varchar(50),
@estado bit,
@resultado bit output,
@mensaje varchar(500) output

)as

begin

	set @resultado = 1
	declare @idPersona int

	if not exists (select * from Proveedor where documento = @documento and idProveedor != @idProveedor )
	begin
		update Proveedor set documento = @documento, razonSocial = @razonSocial, correo = @correo, telefono = @telefono, estado = @estado 
		where idProveedor = @idProveedor

	end
	else
	begin
		set @resultado = 0
		set @mensaje = 'No se puede repetir el número de documento'
	end

end

go

create procedure sp_EliminarProveedor(
@idProveedor int,
@resultado bit output,
@mensaje varchar(500) output

)as

begin

	set @resultado = 1
	declare @idPersona int

	if not exists (select * from Proveedor p inner join Compra c on c.idProveedor = p.idProveedor where p.idProveedor = @idProveedor )
		begin
		delete top(1) from Proveedor where idProveedor = @idProveedor;

		end
	else
		begin
			set @resultado = 0
			set @mensaje = 'No se puede eliminar el proveedor, esta vinculado a una compra.'
		end

end

go

/* PROCESOS PARA REGISTRAR UNA COMPRA */
go

CREATE TYPE [dbo].[EDetalle_Compra] AS TABLE(
	[idProducto] int NULL,
	[precioCompra] decimal(10,2) NULL,
	[precioVenta] decimal(10,2) NULL,
	[cantidad] int NULL,
	[montoTotal] decimal(10,2) NULL
)

go

CREATE PROCEDURE sp_RegistrarCompra(
@idUsuario int,
@idProveedor int,
@tipoDocumento varchar(500),
@numeroDocumento varchar(500),
@montoTotal decimal(18,2),
@detalleCompra [EDetalle_Compra] READONLY,
@resultado bit output,
@mensaje varchar(500) output
)
as
begin
	
	begin try

		declare @idcompra int = 0
		set @Resultado = 1
		set @Mensaje = ''

		begin transaction registro

		insert into Compra(idUsuario,idProveedor,tipoDocumento,numeroDocumento,montoTotal)
		values(@idUsuario,@idProveedor,@tipoDocumento,@numeroDocumento,@montoTotal)

		set @idcompra = SCOPE_IDENTITY()

		insert into Detalle_Compra(idCompra,idProducto,precioCompra,precioVenta,cantidad,montoTotal)
		select @idcompra,idProducto,precioCompra,precioVenta,cantidad,montoTotal from @detalleCompra


		update p set p.stock = p.stock + dc.cantidad, 
		p.precioCompra = dc.precioCompra,
		p.precioVenta = dc.precioVenta
		from Producto p
		inner join @detalleCompra dc on dc.idProducto= p.idProducto

		commit transaction registro


	end try
	begin catch
		set @resultado = 0
		set @mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch

end


GO

/* PROCESOS PARA REGISTRAR UNA VENTA */
go

CREATE TYPE [dbo].[EDetalle_Venta] AS TABLE(
	[idProducto] int NULL,
	[precioVenta] decimal(18,2) NULL,
	[cantidad] int NULL,
	[subTotal] decimal(18,2) NULL
)


GO


create procedure sp_RegistrarVenta(
@idUsuario int,
@tipoDocumento varchar(500),
@numeroDocumento varchar(500),
@documentoCliente varchar(500),
@nombreCliente varchar(500),
@montoPago decimal(18,2),
@montoCambio decimal(18,2),
@montoTotal decimal(18,2),
@detalleVenta [EDetalle_Venta] readonly,
@resultado bit output,
@mensaje varchar(500) output
)as 
begin

	begin try
		declare @idVenta int = 0
		set @resultado = 1
		set @mensaje = ''

		begin transaction registro
			insert into Venta(idUsuario, tipoDocumento, numeroDocumento, documentoCliente, nombreCliente, montoPago, montoCambio, montoTotal)
			values(@idUsuario, @tipoDocumento, @numeroDocumento, @documentoCliente, @nombreCliente ,@montoPago, @montoCambio,  @montoTotal)

			set @idVenta = SCOPE_IDENTITY()

			insert into Detalle_Venta(idVenta, idProducto, precioVenta, cantidad, subTotal)
			select @idVenta, idProducto, precioVenta, cantidad, subTotal from @detalleVenta

			update Producto set stock = stock-cantidad from @detalleVenta dv where Producto.idProducto = dv.idProducto;

		commit transaction registro

	end try
	begin catch
		set @resultado = 0
		set @mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch


end

go


create PROC sp_ReporteCompra(
@fechaInicio varchar(50),
@fechaFinal varchar(50)
)as
begin

	set dateformat ymd;
		select CONVERT(char(10), c.fechaRegistro, 103)[fechaRegistro], c.tipoDocumento, c.numeroDocumento, c.montoTotal,
		u.nombre[nombreUsuario], pv.documento[documentoProveedor], pv.razonSocial, p.codigo[codProducto], p.nombre[nombreProducto],
		cat.descripcion[categoria], dc.precioCompra, dc.precioVenta,  dc.cantidad, dc.montoTotal[subTotal]

		from Compra c
		inner join Usuario u on u.idUsuario = c.idUsuario
		inner join Proveedor pv on pv.idProveedor = c.idProveedor
		inner join Detalle_Compra dc on dc.idCompra = c.idCompra
		inner join Producto p on p.idProducto = dc.idProducto
		inner join Categoria cat on cat.idCategoria = p.idCategoria
		where CONVERT(date, c.fechaRegistro) between @fechaInicio  and @fechaFinal

end

go

 CREATE PROC sp_ReporteVenta(
@fechaInicio varchar(50),
@fechaFinal varchar(50)
)as
begin

	set dateformat ymd;
		select CONVERT(char(10), v.fechaRegistro, 103)[fechaRegistro], v.tipoDocumento, v.numeroDocumento, v.montoTotal,
		u.nombre[nombreUsuario], v.documentoCliente, v.nombreCliente,p.codigo[codigoProducto],  p.nombre[nombreProducto],
		cat.descripcion[categoria],  dv.precioVenta,  dv.cantidad, dv.subTotal

		from Venta v
		inner join Usuario u on u.idUsuario = v.idUsuario
		inner join Detalle_Venta dv on dv.idVenta = v.idVenta
		inner join Producto p on p.idProducto = dv.idProducto
		inner join Categoria cat on cat.idCategoria = p.idCategoria
		where CONVERT(date, v.fechaRegistro) between @fechaInicio  and @fechaFinal

end

go

/* INSERCIONES A LAS TABLAS */


go

insert into Rol(descripcion) values
('ADMINISTRADOR'),
('EMPLEADO')

GO

INSERT INTO Permiso(idRol, vista)values
(1,'menuUsuario'),
(1,'menuVentas'),
(1,'menuInventario'),
(1,'menuProveedores'),
(1,'menuProductos'),
(1,'menuClientes'),
(1,'menuCompras'),
(1,'menuReportes'),
(1,'menuAcercaDe')

go

INSERT INTO Permiso(idRol, vista)values
(2,'menuVentas'),
(2,'menuInventario'),
(2,'menuProveedores'),
(2,'menuClientes'),
(2,'menuCompras'),
(2,'menuReportes'),
(2,'menuAcercaDe')

go

insert into Negocio(idNegocio, nombre, rfc, direccion, logo)values
(1,'apptienda','apptienda','Arroyo Colorado, Acambaro, Gto.',null)

go

insert into Cliente(documento, nombre, correo, telefono, estado)values
('00000000','desconocido','desconocido@desc.com','00000000000',1)

go

insert into Proveedor(documento, razonSocial, correo, telefono, estado)values
('00000000','desconocido','desconocido@desc.com','00000000000',1)

go

insert into Usuario(documento, apodo, nombre, correo, contraseña, idRol, estado)values
('12345678','admin','ADMINISTRADOR','admin@admin.com','admin',1,1)

go

insert into Categoria(descripcion, estado)values
('Comida',1),
('Bebidas',1)

go

insert into Producto(idCategoria,codigo, nombre, descripcion, stock, precioCompra, precioVenta, estado)values
(1,'12345678','nuevo','ninguna',0, 0.0, 0.0,1)

go
