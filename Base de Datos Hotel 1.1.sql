Create database Hotel
Use Hotel;


--CREAR TABLAS--

--Tabla Rol--
create table Roles(
idRol int primary key identity (1,1),
nombreRol varchar(15) not null);

--Tabla Cliente--
create table Cliente(
idCliente int primary key identity (1,1),
nombreCliente varchar(100) not null,
apellidoCliente varchar(100) not null,
emailClient varchar(100) not null unique,
telefono varchar(9) not null unique,
estadoCliente varchar(20) not null);

--Tabla Usuario--
create table Usuario(
idUsuario int primary key identity (1,1),
nombreUser varchar(100) not null,
apellidoUser varchar(100) not null,
emailUser varchar(100) unique not null,
passwordUser varchar(100) not null,
EstadoUser varchar(100)not null,
id_Rol int not null,
foreign key (id_Rol) references Roles(idRol));

--Tabla EstadoRoom--
create table EstadoRoom(
idEstado int primary key identity (1,1),
nombre varchar(15) not null);

--Tabla Habitaciones--
create table Habitaciones(
idRoom int primary key identity (1,1),
numero varchar(3) not null,
tipo varchar(6) not null,
id_estado int,
precio decimal(10,2) not null,
foreign key (id_estado) references EstadoRoom(idEstado));

--Tabla Servicios--
create table Servicios(
idServicio int primary key identity (1,1),
tipoServicio varchar(30),
descripcion TEXT not null,
precio decimal(10,2) not null);

--Tabla EstadoReserva--
create table EstadoReserva(
idEstadoR int primary key identity (1,1),
tipoEstado varchar(20) not null);

--Tabla Reservas--
create table Reservas(
idReservas int primary key identity (1,1),
id_Cliente int,
id_Room int,
inicioReserva date not null,
finReserva date not null,
fechaCheckIn datetime not null,
fechaCheckOut datetime not null,
id_EstadoR int,
foreign key (id_EstadoR) references EstadoReserva(idEstadoR));

--Tabla ReservaHabitaciones--
create table ReservaHabitaciones (
   idRH int primary key identity(1,1),
   cantidadHabitaciones int not null default 1,
   idReserva int not null,
   idHabitacion int not null,
   foreign key (idReserva) references Reservas(idReservas),
   foreign key (idHabitacion) references Habitaciones(idRoom));

--Tabla ReservaClientes--
   create table ReservaClientes (
   idRC int primary key identity(1,1),
   idReserva int not null,
   idCliente int not null,
   foreign key (idReserva) references Reservas(idReservas),
   foreign key (idCliente) references Cliente(idCliente)
);

--Tabla intermedia Reservas/Servicio--
create table ReservaServicios(
idRS int primary key identity (1,1),
cantidadServicios int not null default(1),
id_Reserva int,
id_Servicios int,
foreign key (id_Reserva) references Reservas(idReservas),
foreign key (id_Servicios) references Servicios(idServicio));

------------------------------------------------------------------------
--Inserts--
------------------------------------------------------------------------

insert into Roles values ('Administrador'),('Recepcionista'),('Gerente');

insert into Cliente values('Carlos Alejandro','Lopez Rodriguez','totogamebyte@gmail.com','123456789','Activo');

insert into Usuario values('Alexander Isaias','Hernandez Aviles','isaias123@gmail.com','1234','Activo',1);

insert into EstadoRoom values ('Disponible'),('Ocupada'),('Mantenimiento');

insert into Habitaciones values ('1A','Normal',1,'120.00'),('2A','Normal',1,'120.00'),
('3A','Normal',1,'120.00'),('4A','Normal',1,'120.00'),('5A','Normal',1,'120.00');

insert into Servicios values ('Restaurante (Normal)','Acceso al restaurante y al bar del Hotel donde se podra degustar la mayoría de platillos que varian según la temporada.',15.00),
('Restaurante (VIP)','Acceso al restaurante y al bar del Hotel donde se podra degustar todos los platillos del Hotel sin restricciones.',45.00),

('Spa (Normal)','Acceso al Spa del Hotel en un horario fijo.',20.00),
('Spa (VIP)','Acceso al Spa VIP del Hotel, donde no cuenta con límite de tiempo.',70.00),

('Piscina (Normal)','Acceso a la piscina pública del Hotel.',10.00),
('Piscina (VIP)','Acceso a la piscina privada VIP del Hotel.',60.00),

('Habitación "Romantica"','Ambientación romantica para la habitación, con luces suaves y música romantica, la habitación es insonorisada por completo.',40.00),

('Lavandería','Acceso a la lavandería del Hotel.',10.00),

('Sala de Juegos (Normal)','Acceso a las zonas de Arcade y recreativas del Hotel, con un número de intentos límitados por día.',10.00),
('Sala de Juegos (VIP)','Acceso a las zonas de Arcade y recreativas del Hotel, con un número de intentos ilimitados por día.',25.00);

insert into EstadoReserva values ('Pendiente'),('Confirmada'),('Cancelada'),('Realizada');

insert into Reservas values(1,1,'20-09-2025','24-09-2025','21-09-2025','24-09-2025',2);

insert into ReservaHabitaciones (idReserva, idHabitacion, cantidadHabitaciones)
values (1, 2, 2);
insert into ReservaHabitaciones (idReserva, idHabitacion, cantidadHabitaciones)
values (1, 3, 1);

insert into ReservaClientes (idReserva, idCliente)
values (1, 1);

insert into ReservaServicios(cantidadServicios,id_Reserva,id_Servicios) values(1,1,1);

--VIEW--

---Creamos un view con el id del cliente,nombre,numero de habitacion,costo de la habitacion,costo total de los servicios y la suma total del costo de habitacion
---mas el del servicio

create view Ventas as
select
    r.idReservas as ID,
    c.nombreCliente as Cliente,
    h.numero as Numero_de_Habitacion,
    sum(h.precio * rh.cantidadHabitaciones) as Costo_Habitaciones,
    sum(s.precio * rs.cantidadServicios) as Costo_Servicios,
    (sum(h.precio * rh.cantidadHabitaciones) + 
     sum(s.precio * rs.cantidadServicios)) as Costo_Total
from Reservas r
inner join ReservaClientes rc on r.idReservas = rc.idReserva
inner join Cliente c on rc.idCliente = c.idCliente
inner join ReservaHabitaciones rh on r.idReservas = rh.idReserva
inner join Habitaciones h on rh.idHabitacion = h.idRoom
left join ReservaServicios rs on r.idReservas = rs.id_Reserva
left join Servicios s on rs.id_Servicios = s.idServicio
group by r.idReservas, c.nombreCliente, h.numero;


--Creamos un view con el estado de la habitacion,su numero,tipo de habitacion y el precio(en general toda la informacion de una habitacion)------------
Create view Habitacion as
select
Habitaciones.idRoom as ID,
EstadoRoom.nombre as Estado_de_la_Habitacion,
Habitaciones.numero as Numero_Habitacion,
Habitaciones.tipo as Tipo_de_Habitacion,
Habitaciones.precio as Precio_de_la_Habitacion
from Habitaciones
inner Join
EstadoRoom on Habitaciones.idRoom =EstadoRoom.idEstado
group by Habitaciones.idRoom,Habitaciones.numero,Habitaciones.tipo,Habitaciones.precio,EstadoRoom.nombre;

--Creamos este view para ver que cliente tiene que reserva---
create view ClientesReservas as
select
c.idCliente,
c.nombreCliente + ' ' + c.apellidoCliente as Cliente,
r.idReservas,
r.inicioReserva,
r.finReserva,
er.tipoEstado as EstadoReserva
from ReservaClientes rc
inner join Cliente c on rc.idCliente = c.idCliente
inner join Reservas r on rc.idReserva = r.idReservas
inner join EstadoReserva er on r.id_EstadoR = er.idEstadoR;

--Creamos este view para ver que servicio pidio cada reserva--------
create view ServiciosReservas as
select
r.idReservas,
s.tipoServicio,
rs.cantidadServicios,
s.precio,
(rs.cantidadServicios * s.precio) as Total_Servicio
from Reservas r
inner join ReservaServicios rs on r.idReservas = rs.id_Reserva
inner join Servicios s on rs.id_Servicios = s.idServicio;

--Creamos un view para ver el historial de uso de X habitacion y su estado--

create view HistorialHabitaciones as
select
h.idRoom,
h.numero as NumeroHabitacion,
h.tipo as TipoHabitacion,
r.idReservas,
r.inicioReserva,
r.finReserva,
er.tipoEstado as EstadoReserva,
c.nombreCliente + ' ' + c.apellidoCliente as Cliente
from ReservaHabitaciones rh
inner join Habitaciones h on rh.idHabitacion = h.idRoom
inner join Reservas r on rh.idReserva = r.idReservas
inner join EstadoReserva er on r.id_EstadoR = er.idEstadoR
inner join ReservaClientes rc on r.idReservas = rc.idReserva
inner join Cliente c on rc.idCliente = c.idCliente;

--Creamos un view para organizar los usuarios--
create view UsuariosRoles as
select
u.idUsuario,
u.nombreUser + ' ' + u.apellidoUser as Usuario,
u.emailUser,
u.passwordUser,
u.EstadoUser,
r.nombreRol as Rol
from Usuario u
inner join Roles r on u.id_Rol = r.idRol;

--Cremoa un view para ver los datos de un servicio--
create view InfoServicios as
select
s.idServicio,
s.tipoServicio,
s.descripcion,
s.precio
from Servicios s;


---DROP--------------------------------------------------------------------------
drop table Roles
drop table Cliente
drop table Usuario
drop table ReservaServicios
drop table Reservas
drop table EstadoReserva
drop table Servicios
drop table Habitaciones
drop table ReservaHabitaciones
drop table ReservaClientes
drop table EstadoRoom
drop view Habitacion
drop view Ventas
drop view ClientesReservas
drop view ServiciosReservas
drop view HistorialHabitaciones
drop view UsuariosRoles
drop view InfoServicios

--SELECT-------------------------------------------------------------------------
Select*from Ventas
Select*from Habitacion
Select*from ClientesReservas
Select*from ServiciosReservas
select*from HistorialHabitaciones
select*from UsuariosRoles
select*from InfoServicios
