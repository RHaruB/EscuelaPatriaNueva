
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Insert_Usuario
	@cedula varchar(13),
	@nombre varchar(200),
	@apellido varchar(200),
	@telefono varchar(15),
	@direccion varchar(200),
	@fecha_nacimiento datetime,
	@usuario varchar(25),
	@contrasena varchar(10)
AS
BEGIN
	
	begin try
	Begin transaction 
	insert into Persona 
	(
		Cedula,
		Nombre,
		Apellido,
		Telefono, 
		Direccion,
		FechaNacimiento
	)
	values 
	(
		@cedula,
		@nombre,
		@apellido,
		@telefono,
		@direccion,
		@fecha_nacimiento
	)

	declare  @id_persona int ;
	select @id_persona = Id from Persona where Cedula = @cedula

	insert into Usuario
	(
		NombreUsuario,
		Contrasena,
		IdPersona
	)
	values 
	(
		@usuario,
		@contrasena,
		@id_persona
	)
	commit transaction
	end try
	
	begin catch
	rollback transaction 
	return 1
	end catch
   
END
GO
