USE [HospOnline]
GO

INSERT INTO [dbo].[Ingreso]
           ([estado]
           ,[enfermedad]
           ,[unidadID]
           ,[salaID]
           ,[camaID]
           ,[descripcion]
           ,[pacienteID]
           ,[fecha_ingreso]
           ,[hora_ingreso])
     VALUES
           ('Ingresado'
           ,'Dolor Lumbar'
           ,1
           ,1
           ,1
           ,'Dolor Lumbar'
           ,1
           ,getdate()
           ,'15:30')
GO


