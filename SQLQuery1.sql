USE [Socio]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[SocAlta]
		@Id = N'1',
		@Nombre = N'Rosa',
		@Apellido = N'Hernandez',
		@Direccion = N'Calle #1',
		@Telefono = N'88888888888'

SELECT	@return_value as 'Return Value'

GO
