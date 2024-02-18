

use DBAPPTIENDA;

select * from Usuario;
'2023/06/30'


create procedure sp_VentaUsuario(
@fecha varchar(50),
@idUsuario int
)
as

begin
	begin try

	begin transaction registro

	select SUM(montoTotal)[TotalVenta] from Venta v  where CONVERT(date, v.fechaRegistro) = @fecha and v.idUsuario = @idUsuario

	select nombre from Usuario where idUsuario = @idUsuario
	
	commit transaction registro


	end try
	begin catch
		rollback transaction registro
	end catch

end



exec sp_VentaUsuario @fecha = '2023/06/30', @idUsuario = 1