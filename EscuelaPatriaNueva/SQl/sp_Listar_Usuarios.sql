
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Listar_Usuarios
	
	
AS
BEGIN
	
	SET NOCOUNT ON;

   select * from Usuario
END
GO
