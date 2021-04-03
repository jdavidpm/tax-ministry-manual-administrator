create DATABASE Hacienda

use Hacienda

go
create table Consulta
(
ID int primary key identity(1,1),
Area varchar(25) not null,
Oficina int not null,
Tipo_Manual varchar(25) not null,
Fecha_adicion date,
Estado varchar(25) not null
)

-----------------------------------------------------------------------------------
go
create procedure spConsulta
(
@Area varchar(25),
@TipoManual varchar(25),
@Estado varchar(15),
@Eleccion varchar,
@Fecha date
)
as
begin

begin transaction

      if(@Eleccion = 1)
      begin
            select * from Consulta where Area = @Area and Tipo_Manual = @TipoManual and Estado = @Estado
            if @@ERROR>0
            goto error
      end
	 else if(@Eleccion = 2)
      begin
            select * from Consulta where Fecha_adicion = @Fecha
            if @@ERROR>0
            goto error
      end
    
           commit transaction
      return
error:     
rollback transaction
end
go

-----------------------------------------------------------------------------------
go
create procedure spInsertar
(
@Area varchar(25),
@Oficina int,
@TipoManual varchar(25),
@Estado varchar(15),
@Fecha date,
@Comprobacion int output
)
as
begin

begin transaction

      
      begin
            insert into Consulta(Area, Oficina, Tipo_Manual, Estado, Fecha_adicion) values (@Area, @Oficina, @TipoManual, @Estado, @Fecha)
            if @@ERROR>0
            goto error
      end
    
           commit transaction
      set @Comprobacion=1
      return
error:     
rollback transaction
set @Comprobacion=0
end
go

-----------------------------------------------------------------------------------
go
create procedure spManual
(
@Oficina int,
@Tipo varchar(25),
@Comprobacion int output
)
as
begin

begin transaction

      
      begin
            update Consulta
			set Estado = 'Inactivo'
			where @Oficina = Oficina and @Tipo = Tipo_Manual
            if @@ERROR>0
            goto error
      end
    
           commit transaction
		   set @Comprobacion=1
      return
error:     
rollback transaction
set @Comprobacion=0
end
go

EXEC spInsertar 'Oficina Principal', 100, 'Manual de Organizacion', 'Activo', '08-10-2012', 1
EXEC spInsertar 'Oficina Principal', 100, 'Manual de Procedimientos', 'Activo', '09-10-2012', 1
EXEC spInsertar 'Unidad Responsable', 110, 'Manual de Organizacion', 'Activo', '10-10-2012', 1
EXEC spInsertar 'Unidad Responsable', 110, 'Manual de Procedimientos', 'Activo', '07-11-2012', 1
EXEC spInsertar 'Unidad Responsable', 111, 'Manual de Organizacion', 'Activo', '10-10-2012', 1
EXEC spInsertar 'Unidad Responsable', 111, 'Manual de Procedimientos', 'Activo', '06-12-2012', 1
EXEC spInsertar 'Unidad Responsable', 112, 'Manual de Organizacion', 'Activo', '07-12-2012', 1
EXEC spInsertar 'Unidad Responsable', 112, 'Manual de Procedimientos', 'Activo', '10-12-2012', 1

EXEC spInsertar 'Oficina Principal', 200, 'Manual de Organizacion', 'Activo', '16-12-2012', 1
EXEC spInsertar 'Oficina Principal', 200, 'Manual de Procedimientos', 'Activo', '18-12-2012', 1
EXEC spInsertar 'Unidad Responsable', 210, 'Manual de Organizacion', 'Activo', '05-01-2013', 1
EXEC spInsertar 'Unidad Responsable', 210, 'Manual de Procedimientos', 'Activo', '06-01-2013', 1
EXEC spInsertar 'Unidad Responsable', 211, 'Manual de Organizacion', 'Activo', '08-01-2013', 1
EXEC spInsertar 'Unidad Responsable', 211, 'Manual de Procedimientos', 'Activo', '10-01-2013', 1
EXEC spInsertar 'Unidad Responsable', 212, 'Manual de Organizacion', 'Activo', '19-01-2013', 1
EXEC spInsertar 'Unidad Responsable', 212, 'Manual de Procedimientos', 'Activo', '20-01-2013', 1

EXEC spInsertar 'Oficina Principal', 300, 'Manual de Organizacion', 'Activo', '15-02-2013', 1
EXEC spInsertar 'Oficina Principal', 300, 'Manual de Procedimientos', 'Activo', '20-02-2013', 1
EXEC spInsertar 'Unidad Responsable', 310, 'Manual de Organizacion', 'Activo', '05-03-2013', 1
EXEC spInsertar 'Unidad Responsable', 310, 'Manual de Procedimientos', 'Activo', '10-03-2013', 1
EXEC spInsertar 'Unidad Responsable', 311, 'Manual de Organizacion', 'Activo', '25-03-2013', 1
EXEC spInsertar 'Unidad Responsable', 311, 'Manual de Procedimientos', 'Activo', '31-03-2013', 1
EXEC spInsertar 'Unidad Responsable', 312, 'Manual de Organizacion', 'Activo', '10-04-2013', 1
EXEC spInsertar 'Unidad Responsable', 312, 'Manual de Procedimientos', 'Activo', '30-04-2013', 1

EXEC spInsertar 'Oficina Principal', 400, 'Manual de Organizacion', 'Activo', '03-05-2013', 1
EXEC spInsertar 'Oficina Principal', 400, 'Manual de Procedimientos', 'Activo', '21-05-2013', 1
EXEC spInsertar 'Unidad Responsable', 410, 'Manual de Organizacion', 'Activo', '07-06-2013', 1
EXEC spInsertar 'Unidad Responsable', 410, 'Manual de Procedimientos', 'Activo', '29-06-2013', 1
EXEC spInsertar 'Unidad Responsable', 411, 'Manual de Organizacion', 'Activo', '12-07-2013', 1
EXEC spInsertar 'Unidad Responsable', 411, 'Manual de Procedimientos', 'Activo', '28-07-2013', 1
EXEC spInsertar 'Unidad Responsable', 412, 'Manual de Organizacion', 'Activo', '14-08-2013', 1
EXEC spInsertar 'Unidad Responsable', 412, 'Manual de Procedimientos', 'Activo', '26-08-2013', 1

