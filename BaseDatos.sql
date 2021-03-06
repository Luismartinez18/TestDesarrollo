USE [Net_Core]
GO
/****** Object:  StoredProcedure [dbo].[sp_Delete_Empleado]    Script Date: 26/7/2020 01:42:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Delete_Empleado]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Delete_Empleado]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Empleado__IdPosi__0519C6AF]') AND parent_object_id = OBJECT_ID(N'[dbo].[Empleado]'))
ALTER TABLE [dbo].[Empleado] DROP CONSTRAINT [FK__Empleado__IdPosi__0519C6AF]
GO
/****** Object:  Table [dbo].[Posicion]    Script Date: 26/7/2020 01:42:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Posicion]') AND type in (N'U'))
DROP TABLE [dbo].[Posicion]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 26/7/2020 01:42:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Empleado]') AND type in (N'U'))
DROP TABLE [dbo].[Empleado]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 26/7/2020 01:42:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Empleado]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Empleado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](40) NULL,
	[Apellido] [varchar](40) NULL,
	[Cedula] [varchar](15) NULL,
	[FechaNacimiento] [datetime] NULL,
	[IdPosicion] [int] NULL,
	[Telefono] [varchar](15) NULL,
	[direccion] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Posicion]    Script Date: 26/7/2020 01:42:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Posicion]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Posicion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descrpcion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([id], [Nombre], [Apellido], [Cedula], [FechaNacimiento], [IdPosicion], [Telefono], [direccion]) VALUES (1, N'Jasmin', N'Georgin luis', N'2233660055', CAST(N'2020-07-02 00:00:00.000' AS DateTime), 1, N'809-231-0166', N'Santo Domingo')
INSERT [dbo].[Empleado] ([id], [Nombre], [Apellido], [Cedula], [FechaNacimiento], [IdPosicion], [Telefono], [direccion]) VALUES (3, N'Luis', N'Martinez', N'2233660055', CAST(N'2020-07-02 00:00:00.000' AS DateTime), 1, N'809-231-0166', N'Santo Domingo Este')
INSERT [dbo].[Empleado] ([id], [Nombre], [Apellido], [Cedula], [FechaNacimiento], [IdPosicion], [Telefono], [direccion]) VALUES (4, N'Rosa', N'Silvestre', N'21544984651', CAST(N'2020-07-10 00:00:00.000' AS DateTime), 4, N'809-231-0155', NULL)
SET IDENTITY_INSERT [dbo].[Empleado] OFF
SET IDENTITY_INSERT [dbo].[Posicion] ON 

INSERT [dbo].[Posicion] ([id], [Descrpcion]) VALUES (1, N'Dosarrollador')
INSERT [dbo].[Posicion] ([id], [Descrpcion]) VALUES (3, N'Contador')
INSERT [dbo].[Posicion] ([id], [Descrpcion]) VALUES (4, N'Secretaria')
SET IDENTITY_INSERT [dbo].[Posicion] OFF
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Empleado__IdPosi__0519C6AF]') AND parent_object_id = OBJECT_ID(N'[dbo].[Empleado]'))
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD FOREIGN KEY([IdPosicion])
REFERENCES [dbo].[Posicion] ([id])
GO
/****** Object:  StoredProcedure [dbo].[sp_Delete_Empleado]    Script Date: 26/7/2020 01:42:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Delete_Empleado]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_Delete_Empleado] AS' 
END
GO

ALTER procedure [dbo].[sp_Delete_Empleado]
(
@id int
)
as
begin
 declare @IdPosicion int 
  select @IdPosicion = IdPosicion from Empleado where id = @id
  if @IdPosicion is null set @IdPosicion = 0

  delete from Empleado where id = @id
  delete from Posicion where id = @IdPosicion
end 
GO
