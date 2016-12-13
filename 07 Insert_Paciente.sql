USE [Hosp_Ingreso]
GO

INSERT INTO [dbo].[Paciente]
           ([rut]
           ,[dv]
           ,[nombre]
           ,[apellido_paterno]
           ,[apellido_materno]
           ,[edad]
           ,[fecha_ingreso]
           ,[hora_ingreso]
           ,[direccion]
           ,[telefono]
           ,[clave])
     VALUES
           ('18773324'
           ,'3'
           ,'Alberto'
           ,'Lorca'
           ,'Segura'
           ,'22'
           ,getdate()
           ,'11:30'
           ,'Chillan'
           ,'912345678'
           ,'123456')
GO


