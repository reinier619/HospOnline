USE [HOSP_IMAGENES]
GO

INSERT INTO [dbo].[Imagen]
           ([fecha_informe]
           ,[descripcion]
           ,[diagnostico]
           ,[ingresoID]
           ,[pacienteID])
     VALUES
           (getdate()
           ,'Resonancia'
           ,'Discopatia Lumbar'
           ,1
           ,1)
GO


