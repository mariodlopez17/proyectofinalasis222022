USE `colchoneria`;
alter table tbl_usuarios add pregunta varchar(50) not null;
alter table tbl_usuarios add respuesta varchar(50) not null;

ALTER TABLE tbl_bitacoraDeEventos MODIFY column accion_bitacora VARCHAR(50);