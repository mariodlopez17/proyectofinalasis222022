create database bd_logistica;
use bd_logistica;

create table tbl_productos(
pk_codigo_producto int not null primary key auto_increment,
codigo_referencia int not null,
descripcion varchar(100),
linea_inventario varchar(100), -- fk
tipo varchar(50),
marca varchar(100), -- fk
existencia int,
costo_compra int
-- precio
);

create table tbl_lote(
pk_codigo_lote int not null primary key auto_increment, -- uno a varios --
fk_codigo_producto int not null,
cantidad int not null,
foreign key (fk_codigo_producto) references tbl_productos (pk_codigo_producto)
);


create table tbl_transporte(
pk_codigo_transporte int not null primary key auto_increment,
marca varchar(100),
tipo varchar(100),
peso int not null,
estado bool
);

create table tbl_ruta(
pk_codigo_ruta int not null primary key auto_increment,
zona varchar(100),
ciudad varchar(100),
tipo varchar(100)
);

create table tbl_conductor(
pk_conductor int not null primary key auto_increment,
nombre varchar(100),
estado bool
);

create table tbl_envio(
pk_envio int not null primary key auto_increment,
fk_transporte int not null,
fk_ruta int not null,
fk_conductor int not null,
tiempo_estimado int,
fecha_salida datetime,
fk_lote int not null,
destino varchar(100),
foreign key (fk_transporte) references tbl_transporte (pk_codigo_transporte),
foreign key (fk_ruta) references tbl_ruta (pk_codigo_ruta),
foreign key (fk_conductor) references tbl_conductor (pk_conductor),
foreign key (fk_lote) references tbl_lote (pk_codigo_lote)
);

-- agregar multi bodegas, multi moneda, multi empresa, entradas, movimientos(salidas, entradas), lineas, marcas
