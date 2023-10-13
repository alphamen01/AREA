CREATE TABLE mantenimiento.Cliente (
    id_cliente INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(255) NOT NULL,
    direccion VARCHAR(255) NOT NULL,
    telefono VARCHAR(15) NOT NULL
);

INSERT INTO mantenimiento.Cliente VALUES('EMPRESA A', 'LOS OLIVOS A', '999999999');
INSERT INTO mantenimiento.Cliente VALUES('EMPRESA B', 'LOS OLIVOS B', '888888888');
INSERT INTO mantenimiento.Cliente VALUES('EMPRESA C', 'LOS OLIVOS C', '777777777');

SELECT*FROM mantenimiento.Cliente;

CREATE TABLE mantenimiento.Area (
    id_area INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL,
    id_cliente INT NOT NULL,
	enu_estado_registro CHAR NOT NULL,
	usuario_creacion VARCHAR(255) NULL,
	fecha_creacion DATETIME NULL,
	usuario_modificacion VARCHAR(255) NULL,
	fecha_modificacion DATETIME NULL
    FOREIGN KEY (id_cliente) REFERENCES mantenimiento.Cliente(id_cliente)
);

INSERT INTO mantenimiento.Area VALUES('AREA A', 1, 'A',NULL,NULL,NULL,NULL);
INSERT INTO mantenimiento.Area VALUES('AREA B', 2, 'I',NULL,NULL,NULL,NULL);
INSERT INTO mantenimiento.Area VALUES('AREA C', 3, 'A',NULL,NULL,NULL,NULL);

SELECT*FROM mantenimiento.Area;
