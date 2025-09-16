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
emailClient varchar(100) not null,
telefono varchar(9) not null unique);

--Tabla Usuario--
create table Usuario(
idUsuario int primary key identity (1,1),
nombreUser varchar(100) not null,
apellidoUser varchar(100) not null,
emailUser varchar(100) not null,
passwordUser varchar(100) not null,
id_Rol int
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
id_EstadoR int,
foreign key (id_Cliente) references Cliente(idCliente),
foreign key (id_Room) references Habitaciones(idRoom),
foreign key (id_EstadoR) references EstadoReserva(idEstadoR));

--Tabla intermedia Reservas/Servicio--
create table ReservaServicios(
idRS int primary key identity (1,1),
cantidadServicios int default(1),
id_Reserva int,
id_Servicios int,
foreign key (id_Reserva) references Reservas(idReservas),
foreign key (id_Servicios) references Servicios(idServicio));

------------------------------------------------------------------------
--Inserts--
------------------------------------------------------------------------

insert into Roles values ('Administrador'),('Recepcionista'),('Gerente');

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

--VIEW--

---Creamos un view con el id del cliente,nombre,numero de habitacion,costo de la habitacion,costo total de los servicios y la suma total del costo de habitacion
---mas el del servicio

create view Ventas AS
Select
r.idReservas as ID,
Cliente.nombreCliente as Cliente,
Habitaciones.numero as Número_de_Habitacion,
Habitaciones.precio as Costo_Habitación,
SUM(Servicios.precio * ReservaServicios.cantidadServicios) as 
Costo_Servicios, (Habitaciones.precio + SUM(Servicios.precio * ReservaServicios.cantidadServicios)) as
Costo_Total from
Reservas as R
inner Join
Cliente on R.id_Cliente = Cliente.idCliente
inner Join
Habitaciones on R.id_Room = Habitaciones.idRoom
left Join
ReservaServicios on R.idReservas = ReservaServicios.id_Reserva
left Join
Servicios on ReservaServicios.id_Servicios = Servicios.idServicio
group by r.idReservas,Cliente.nombreCliente,Habitaciones.numero,Habitaciones.precio;

Create view Habitacion as
select
EstadoRoom.nombre as Estado_de_la_Habitacion,
Habitaciones.idRoom as ID,
Habitaciones.numero as Numero_Habitacion,
Habitaciones.tipo as Tipo_de_Habitacion,
Habitaciones.precio as Precio_de_la_Habitacion
from Habitaciones
inner Join
EstadoRoom on Habitaciones.idRoom =EstadoRoom.idEstado
group by Habitaciones.idRoom,Habitaciones.numero,Habitaciones.tipo,Habitaciones.precio,EstadoRoom.nombre;


