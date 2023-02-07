/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     29/12/2022 14:59:23                          */
/*==============================================================*/

CREATE DATABASE DBEcuamare
GO
USE DBEcuamare
GO


CREATE LOGIN Precitrol WITH PASSWORD='Sistemas123'
GO
CREATE USER Precitrol FOR LOGIN Precitrol
GO
GRANT ALTER To Precitrol
GO
GRANT CONTROL To Precitrol
GO
if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PERMISO') and o.name = 'FK_PERMISO_RELATIONS_USUARIO')
alter table PERMISO
   drop constraint FK_PERMISO_RELATIONS_USUARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PESO') and o.name = 'FK_PESO_RELATIONS_USUARIO')
alter table PESO
   drop constraint FK_PESO_RELATIONS_USUARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PESO') and o.name = 'FK_PESO_RELATIONS_TICKET')
alter table PESO
   drop constraint FK_PESO_RELATIONS_TICKET
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TICKET') and o.name = 'FK_TICKET_RELATIONS_PROVEEDO')
alter table TICKET
   drop constraint FK_TICKET_RELATIONS_PROVEEDO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TICKET') and o.name = 'FK_TICKET_RELATIONS_MATERIAL')
alter table TICKET
   drop constraint FK_TICKET_RELATIONS_MATERIAL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CONFIGURACION')
            and   type = 'U')
   drop table CONFIGURACION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MATERIAL')
            and   type = 'U')
   drop table MATERIAL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PERMISO')
            and   name  = 'RELATIONSHIP_6_FK'
            and   indid > 0
            and   indid < 255)
   drop index PERMISO.RELATIONSHIP_6_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PERMISO')
            and   type = 'U')
   drop table PERMISO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PESO')
            and   name  = 'RELATIONSHIP_5_FK'
            and   indid > 0
            and   indid < 255)
   drop index PESO.RELATIONSHIP_5_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PESO')
            and   name  = 'RELATIONSHIP_3_FK'
            and   indid > 0
            and   indid < 255)
   drop index PESO.RELATIONSHIP_3_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PESO')
            and   type = 'U')
   drop table PESO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PROVEEDOR')
            and   type = 'U')
   drop table PROVEEDOR
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TICKET')
            and   name  = 'RELATIONSHIP_2_FK'
            and   indid > 0
            and   indid < 255)
   drop index TICKET.RELATIONSHIP_2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TICKET')
            and   name  = 'RELATIONSHIP_1_FK'
            and   indid > 0
            and   indid < 255)
   drop index TICKET.RELATIONSHIP_1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TICKET')
            and   type = 'U')
   drop table TICKET
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USUARIO')
            and   type = 'U')
   drop table USUARIO
go

/*==============================================================*/
/* Table: CONFIGURACION                                             */
/*==============================================================*/
create table CONFIGURACION (
   CON_ID				int                  not null,
   CON_COMCAMIONERA     varchar(20)          null,
   CON_SERIALCAMIONERA  varchar(20)          null,
   CON_COMPISO          varchar(20)          null,
   CON_SERIALPISO       varchar(20)          null,
   constraint PK_CONFIGURACION primary key nonclustered (CON_ID),
)
go

/*==============================================================*/
/* Table: MATERIAL                                              */
/*==============================================================*/
create table MATERIAL (
   MAT_ID               int                  not null IDENTITY(1,1),
   MAT_NOMBRE           varchar(150)         not null,
   constraint PK_MATERIAL primary key nonclustered (MAT_ID),
   constraint UQ_MATERIALUNICO UNIQUE(MAT_NOMBRE)
)
go

/*==============================================================*/
/* Table: PERMISO                                             */
/*==============================================================*/
create table PERMISO (
   USU_ID               int                  not null,
   PER_ID               int                  not null IDENTITY(1,1),
   PER_ANULARTICKET     bit                  null,
   PER_USUARIOS         bit                  null,
   PER_CONFIGURACION    bit                  null,
   constraint PK_PERMISO primary key nonclustered (PER_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_6_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_6_FK on PERMISO (
USU_ID ASC
)
go

/*==============================================================*/
/* Table: PESO                                                  */
/*==============================================================*/
create table PESO (
   PES_ID               int                  not null IDENTITY(1,1),
   USU_ID               int                  null,
   TICK_ID              int                  null,
   PES_FECHA            datetime             null,
   PES_PESO             float(2)             null,
   PES_PORCENTAJE       int                  null,
   PES_TIPO             int                  null,
   constraint PK_PESO primary key nonclustered (PES_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_3_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_3_FK on PESO (
USU_ID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_5_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_5_FK on PESO (
TICK_ID ASC
)
go

/*==============================================================*/
/* Table: PROVEEDOR                                             */
/*==============================================================*/
create table PROVEEDOR (
   PROV_ID              varchar(50)          not null,
   PROV_RUC             varchar(50)          null,
   PROV_NOMBRE          varchar(150)         null,
   PROV_DIRECCION       varchar(300)         null,
   PROV_TELEFONO        varchar(50)          null,
   constraint PK_PROVEEDOR primary key nonclustered (PROV_ID),
   constraint UQ_PROVEEDORUNICO UNIQUE(PROV_NOMBRE)
)
go

/*==============================================================*/
/* Table: TICKET                                                */
/*==============================================================*/
create table TICKET (
   TICK_ID              int                  not null IDENTITY(1,1),
   PROV_ID              varchar(50)          null,
   MAT_ID               int                  null,
   TICK_NUMERO          varchar(30)          not null,
   TICK_NOMBRECONDUCTOR varchar(100)         null,
   TICK_PLACAVEHICULO   varchar(50)          null,
   TICK_GUIA            varchar(50)          null,
   TICK_FORMAENTREGA    varchar(50)          null,
   TICK_ESTADO          varchar(10)          null,
   constraint PK_TICKET primary key nonclustered (TICK_ID),
   constraint UQ_TICKETUNICO UNIQUE(TICK_NUMERO)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_1_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_1_FK on TICKET (
PROV_ID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_2_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_2_FK on TICKET (
MAT_ID ASC
)
go

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO (
   USU_ID               int                  not null IDENTITY(1,1),
   USU_USUARIO          varchar(50)          not null,
   USU_NOMBRES          varchar(50)          null,
   USU_CONTRASENA       varchar(200)         null,
   USU_ROL              varchar(20)          null,
   constraint PK_USUARIO primary key nonclustered (USU_ID),
   constraint UQ_USUARIOUNICO UNIQUE(USU_USUARIO)
)
go

alter table PERMISO
   add constraint FK_PERMISO_RELATIONS_USUARIO foreign key (USU_ID)
      references USUARIO (USU_ID)
go

alter table PESO
   add constraint FK_PESO_RELATIONS_USUARIO foreign key (USU_ID)
      references USUARIO (USU_ID)
go

alter table PESO
   add constraint FK_PESO_RELATIONS_TICKET foreign key (TICK_ID)
      references TICKET (TICK_ID)
go

alter table TICKET
   add constraint FK_TICKET_RELATIONS_PROVEEDO foreign key (PROV_ID)
      references PROVEEDOR (PROV_ID)
go

alter table TICKET
   add constraint FK_TICKET_RELATIONS_MATERIAL foreign key (MAT_ID)
      references MATERIAL (MAT_ID)
go

INSERT [dbo].[USUARIO] ([USU_USUARIO], [USU_NOMBRES], [USU_CONTRASENA], [USU_ROL]) VALUES (N'ADMIN', N'Precitrol', N'UHJlY2l0cm9sMjAyMy4=', N'Administrador')
SET IDENTITY_INSERT [dbo].[USUARIO] OFF
GO

INSERT [dbo].[CONFIGURACION] ([CON_ID], [CON_COMCAMIONERA], [CON_SERIALCAMIONERA], [CON_COMPISO], [CON_SERIALPISO]) VALUES (1, N'', N'', N'', N'')
GO

INSERT [dbo].[PERMISO] ([USU_ID], [PER_ANULARTICKET], [PER_USUARIOS], [PER_CONFIGURACION]) VALUES (1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[PERMISO] OFF
GO

CREATE VIEW [dbo].[V_TicketImprimir]
AS
SELECT     T.TICK_ID AS ID, T.TICK_NUMERO AS TICKET, T.TICK_ESTADO AS ESTADO, T.PROV_ID AS [ CODIGO PROVEEDOR], PROV_1.PROV_RUC AS [RUC PROVEEDOR], PROV_1.PROV_NOMBRE AS [NOMBRE PROVEEDOR], T.TICK_NOMBRECONDUCTOR AS CONDUCTOR, 
                  T.TICK_PLACAVEHICULO AS VEHICULO, T.TICK_GUIA AS [N# GUIA], P1.PES_FECHA AS [FECHA ENTRADA], P2.PES_FECHA AS [FECHA SALIDA], T.TICK_FORMAENTREGA AS [FORMA DE ENTREGA], M_1.MAT_NOMBRE AS MATERIAL, P1.PES_PESO AS [PESO ENTRADA], 
                  P2.PES_PESO AS [PESO SALIDA], P1.PES_PESO - P2.PES_PESO AS [PESO BRUTO], P3.PES_PORCENTAJE AS [%MUESTRA], P3.PES_PESO AS [PESO IMPUREZAS], P3.PES_PESO * 100 / P3.PES_PORCENTAJE AS [PESO NO CONFORME], (P1.PES_PESO - P2.PES_PESO) 
                  - P3.PES_PESO * 100 / P3.PES_PORCENTAJE AS [PESO NETO]
FROM        dbo.TICKET AS T LEFT OUTER JOIN
                      (SELECT     P.PES_ID, P.USU_ID, P.TICK_ID, P.PES_FECHA, P.PES_PESO, P.PES_PORCENTAJE, P.PES_TIPO, U.USU_USUARIO
                       FROM        dbo.PESO AS P INNER JOIN
                                         dbo.USUARIO AS U ON P.USU_ID = U.USU_ID AND P.PES_TIPO = 1) AS P1 ON T.TICK_ID = P1.TICK_ID LEFT OUTER JOIN
                      (SELECT     P.PES_ID, P.USU_ID, P.TICK_ID, P.PES_FECHA, P.PES_PESO, P.PES_PORCENTAJE, P.PES_TIPO, U.USU_USUARIO
                       FROM        dbo.PESO AS P INNER JOIN
                                         dbo.USUARIO AS U ON P.USU_ID = U.USU_ID AND P.PES_TIPO = 3) AS P3 ON T.TICK_ID = P3.TICK_ID LEFT OUTER JOIN
                      (SELECT     P.PES_ID, P.USU_ID, P.TICK_ID, P.PES_FECHA, P.PES_PESO, P.PES_PORCENTAJE, P.PES_TIPO, U.USU_USUARIO
                       FROM        dbo.PESO AS P INNER JOIN
                                         dbo.USUARIO AS U ON P.USU_ID = U.USU_ID AND P.PES_TIPO = 2) AS P2 ON T.TICK_ID = P2.TICK_ID LEFT OUTER JOIN
                      (SELECT     MAT_ID, MAT_NOMBRE
                       FROM        dbo.MATERIAL AS M) AS M_1 ON M_1.MAT_ID = T.MAT_ID LEFT OUTER JOIN
                      (SELECT     PROV_ID, PROV_RUC, PROV_NOMBRE, PROV_DIRECCION, PROV_TELEFONO
                       FROM        dbo.PROVEEDOR AS prov) AS PROV_1 ON PROV_1.PROV_ID = T.PROV_ID
GO

CREATE VIEW [dbo].[V_TicketCompleto]
AS
SELECT     T.TICK_ID AS ID, T.TICK_NUMERO AS TICKET, T.TICK_ESTADO AS ESTADO, T.PROV_ID AS PROVEEDOR, T.TICK_NOMBRECONDUCTOR AS CONDUCTOR, T.TICK_PLACAVEHICULO AS VEHICULO, T.TICK_GUIA AS [N# GUIA], T.TICK_FORMAENTREGA AS [FORMA DE ENTREGA], 
                  M_1.MAT_NOMBRE AS MATERIAL, P3.PES_PORCENTAJE AS [%MUESTRA], P1.PES_FECHA AS [FECHA ENTRADA], P1.USU_USUARIO AS [USUARIO ENTRADA], P1.PES_PESO AS [PESO ENTRADA], 
				  P2.PES_FECHA AS [FECHA SALIDA], P2.USU_USUARIO AS [USUARIO SALIDA], P2.PES_PESO AS [PESO SALIDA],
				  P3.PES_FECHA AS [FECHA IMPUREZAS], P3.USU_USUARIO AS [USUARIO IMPUREZAS],P3.PES_PESO AS [PESO IMPUREZAS],
                  P1.PES_PESO - P2.PES_PESO AS [PESO BRUTO], P3.PES_PESO * 100 / P3.PES_PORCENTAJE AS [PESO NO CONFORME], 
                  (P1.PES_PESO - P2.PES_PESO) - P3.PES_PESO * 100 / P3.PES_PORCENTAJE AS [PESO NETO]
FROM        dbo.TICKET AS T LEFT OUTER JOIN
                      (SELECT     P.PES_ID, P.USU_ID, P.TICK_ID, P.PES_FECHA, P.PES_PESO, P.PES_PORCENTAJE, P.PES_TIPO, U.USU_USUARIO
                       FROM        dbo.PESO AS P INNER JOIN
                                         dbo.USUARIO AS U ON P.USU_ID = U.USU_ID AND P.PES_TIPO = 1) AS P1 ON T.TICK_ID = P1.TICK_ID LEFT OUTER JOIN
                      (SELECT     P.PES_ID, P.USU_ID, P.TICK_ID, P.PES_FECHA, P.PES_PESO, P.PES_PORCENTAJE, P.PES_TIPO, U.USU_USUARIO
                       FROM        dbo.PESO AS P INNER JOIN
                                         dbo.USUARIO AS U ON P.USU_ID = U.USU_ID AND P.PES_TIPO = 3) AS P3 ON T.TICK_ID = P3.TICK_ID LEFT OUTER JOIN
                      (SELECT     P.PES_ID, P.USU_ID, P.TICK_ID, P.PES_FECHA, P.PES_PESO, P.PES_PORCENTAJE, P.PES_TIPO, U.USU_USUARIO
                       FROM        dbo.PESO AS P INNER JOIN
                                         dbo.USUARIO AS U ON P.USU_ID = U.USU_ID AND P.PES_TIPO = 2) AS P2 ON T.TICK_ID = P2.TICK_ID LEFT OUTER JOIN
                      (SELECT     MAT_ID, MAT_NOMBRE
                       FROM        dbo.MATERIAL AS M) AS M_1 ON M_1.MAT_ID = T.MAT_ID
GO

