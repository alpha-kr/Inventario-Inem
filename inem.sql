-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 19-05-2016 a las 16:31:44
-- Versión del servidor: 5.6.17
-- Versión de PHP: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `inem`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `activos`
--

CREATE TABLE IF NOT EXISTS `activos` (
  `id_activo` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(200) NOT NULL,
  `Categoria` varchar(200) NOT NULL,
  `tipo` varchar(200) NOT NULL,
  `valor_comercial` varchar(200) NOT NULL,
  `proveedor` varchar(200) NOT NULL,
  PRIMARY KEY (`id_activo`),
  KEY `proveedor` (`proveedor`),
  KEY `Categoria` (`Categoria`),
  KEY `tipo` (`tipo`),
  KEY `Nombre` (`Nombre`),
  KEY `Nombre_2` (`Nombre`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=13 ;

--
-- Volcado de datos para la tabla `activos`
--

INSERT INTO `activos` (`id_activo`, `Nombre`, `Categoria`, `tipo`, `valor_comercial`, `proveedor`) VALUES
(8, 'COMPUTADOR DE MESA X9000', 'SISTEMAS, PROGRAMAS Y SOFTWARE', 'Devolutivo', '$1.200.000,00', 'PAPELERIA EL CID'),
(9, 'MICROSOFT WINDOWS OFICCE 2015', 'SISTEMAS, PROGRAMAS Y SOFTWARE', 'Devolutivo', '$400.000,00', 'PAPELERIA EL CID'),
(10, 'IMPRESORA HP ', 'EQUIPO OFICINA CONTABLE Y ACC', 'Devolutivo', '$500.000,00', 'PAPELERIA EL CID'),
(11, 'Escobas tu puta madre', 'UTENCILIOS DE USO DOMESTICO O PERSONAL', 'Consumo', '$ 10.000,00', 'PAPELERIA EL CID'),
(12, 'LAMPARAS TU MAMA ES MIA ', 'COMBUSTIBLE', 'Consumo', '$ 12.000,00', 'PAPELERIA EL CID');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cateogria`
--

CREATE TABLE IF NOT EXISTS `cateogria` (
  `id_categoria` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre_categoria` varchar(200) NOT NULL,
  PRIMARY KEY (`id_categoria`),
  UNIQUE KEY `Nombre_categoria` (`Nombre_categoria`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=28 ;

--
-- Volcado de datos para la tabla `cateogria`
--

INSERT INTO `cateogria` (`id_categoria`, `Nombre_categoria`) VALUES
(14, 'COMBUSTIBLE'),
(16, 'DISCOTECAS Y MUSITECAS'),
(15, 'DOTACION'),
(19, 'EQUIPO CONSTRUCCION'),
(18, 'EQUIPO DE COMUNICACIONES'),
(20, 'EQUIPO DEPARTAMENTO GIMNASIA Y SUS ACCESORIOS'),
(12, 'EQUIPO OFICINA CONTABLE Y ACC'),
(17, 'EQUIPO Y MAQUINA PARA COCINA'),
(21, 'EQUIPO Y MAQUINA PARA TRANS Y ACC'),
(6, 'INSECTICIDAS,FUNGICIDAS Y HERRAMIENTAS'),
(22, 'INSTRUMENTOS MUSICALES Y SUS ACCESORIOS'),
(13, 'LABORATORIO'),
(23, 'LIBROS DE BIBLIOTECA'),
(25, 'MATERIAL RODANTE,MAQ Y EQUIPOS'),
(27, 'MATERIALES Y EQUIPOS PARA REDES'),
(7, 'MATERIAS PRIMAS PARA CONSTRUCCION'),
(24, 'MOBILIARIO Y ENSERES'),
(10, 'REPUESTOS PARA MAQ Y EQUIPOS'),
(26, 'SISTEMAS, PROGRAMAS Y SOFTWARE'),
(11, 'UTENCILIOS DE USO DOMESTICO O PERSONAL'),
(8, 'UTILIES DE ESCRIBIR,OFICINA,DIBUJO Y PAPELERIA'),
(9, 'VIVIERES, RANCHOS Y LICORES');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ciudades`
--

CREATE TABLE IF NOT EXISTS `ciudades` (
  `Nombre` varchar(200) NOT NULL,
  `id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=10 ;

--
-- Volcado de datos para la tabla `ciudades`
--

INSERT INTO `ciudades` (`Nombre`, `id`) VALUES
('Barranquilla', 1),
('Soledad', 2),
('Malambo', 3),
('Bogota', 4),
('Santa Marta', 5),
('Cartagena', 6),
('cali', 7),
('Bucaramanga', 8),
('Medellin', 9);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `d-activos`
--

CREATE TABLE IF NOT EXISTS `d-activos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `activos` varchar(200) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `departamento` varchar(200) NOT NULL,
  `descripcion` varchar(200) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `activo` (`activos`,`departamento`,`descripcion`),
  KEY `departamento` (`departamento`),
  KEY `descripcion` (`descripcion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `datos-inem`
--

CREATE TABLE IF NOT EXISTS `datos-inem` (
  `nombre` varchar(200) NOT NULL,
  `direccion` varchar(200) NOT NULL,
  `telefono` int(200) NOT NULL,
  `nit` varchar(200) NOT NULL,
  `resolucion` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `datos-inem`
--

INSERT INTO `datos-inem` (`nombre`, `direccion`, `telefono`, `nit`, `resolucion`) VALUES
('INEM MIGLE ANTONIO CARO', 'CALLE 30 AUTOPISTA AEROPUERTO', 3344877, '0', '10968 AGOSTO 10/84'),
('INEM MIGUEL ANTONIO CARO', 'CALLE 30 AUTOPISTA AEROPUERTO', 3344877, '890103217-3', '10968 AGOSTO 10/84');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `departamentos`
--

CREATE TABLE IF NOT EXISTS `departamentos` (
  `id_departamento` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre_departamento` varchar(200) NOT NULL,
  `Jefe_departamento` varchar(200) NOT NULL,
  PRIMARY KEY (`id_departamento`),
  UNIQUE KEY `Nombre_departamento` (`Nombre_departamento`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=67 ;

--
-- Volcado de datos para la tabla `departamentos`
--

INSERT INTO `departamentos` (`id_departamento`, `Nombre_departamento`, `Jefe_departamento`) VALUES
(6, 'PRACTICANTES SENA ', 'PENDIENTE POR REGISTRAR'),
(7, 'METALMECANICA', 'PENDIENTE POR REGISTRAR'),
(8, 'SALON 111 DE INDUMADERA', 'PENDIENTE POR REGISTRAR'),
(9, 'SALON 116 DE DIBUJO 2', 'PENDIENTE POR REGISTRAR'),
(10, 'CIAL SALA DE PROFESORES 2-PISO', 'PENDIENTE POR REGISTRAR'),
(11, 'CONSEJERIA', 'PENDIENTE POR REGISTRAR'),
(12, 'CIENCIAS-SALA PROFESORES', 'PENDIENTE POR REGISTRAR'),
(13, 'CLUB DEPORTIVO INEM', 'PENDIENTE POR REGISTRAR'),
(14, 'ELECTRICISTA', 'PENDIENTE POR REGISTRAR'),
(15, 'EBANISTA', 'PENDIENTE POR REGISTRAR'),
(16, 'CUARTO DE LOS CELADORES', 'PENDIENTE POR REGISTRAR'),
(18, 'BIBLIOTECA OFICINA', 'PENDIENTE POR REGISTRAR'),
(19, 'CAFETERIA', 'PENDIENTE POR REGISTRAR'),
(21, 'SALON DE INFORMATICA 114', 'PENDIENTE POR REGISTRAR'),
(22, 'SALONES MAT-REL-IDIO-CIAL-IND', 'PENDIENTE POR REGISTRAR'),
(23, 'SALAS DE NUEVAS TECNOLOGIAS BEN', 'PENDIENTE POR REGISTRAR'),
(24, 'SALON 06-123 ELECTRICIDAD', 'PENDIENTE POR REGISTRAR'),
(25, 'COMERCIO EXTERIOR', 'PENDIENTE POR REGISTRAR'),
(26, 'AULA POLIVALENTE MULTIMEDIA', 'PENDIENTE POR REGISTRAR'),
(27, 'ELECTRICIDAD 06-108', 'PENDIENTE POR REGISTRAR'),
(28, 'REGISTRO Y CONTROL', 'PENDIENTE POR REGISTRAR'),
(29, 'LABORATORIO DE FISICA ', 'PENDIENTE POR REGISTRAR'),
(30, 'SALA DE PROF INDUSTRIAL', 'PENDIENTE POR REGISTRAR'),
(31, 'ALMACEN OFICINA', 'PENDIENTE POR REGISTRAR'),
(32, 'MARY PSICOLOGIA', 'PENDIENTE POR REGISTRAR'),
(33, 'OFICINA CIENCIAS', 'PENDIENTE POR REGISTRAR'),
(34, 'LABORATORIO DE QUIMICA', 'PENDIENTE POR REGISTRAR'),
(35, 'DEPOSITO DE BIOLOGIA ', 'PENDIENTE POR REGISTRAR'),
(36, 'SALA DE PROFESORES PRIMARIA', 'PENDIENTE POR REGISTRAR'),
(37, 'SALON DE DANZA', 'PENDIENTE POR REGISTRAR'),
(38, 'SALON 203 MAQUINAS ELECTRONICA', 'PENDIENTE POR REGISTRAR'),
(39, 'RECTORIA', 'EDWIN LOZANO GONZALES'),
(40, 'SALONES CIENCIA', 'PENDIENTE POR REGISTRAR'),
(41, 'BIBLIOTECA PRIMARIA', 'PENDIENTE POR REGISTRAR'),
(42, 'ED FISICA PRIMARIA ', 'PENDIENTE POR REGISTRAR'),
(43, 'ESCUELA DE LIDERAZGO', 'PENDIENTE POR REGISTRAR'),
(44, 'CAPILLA', 'PENDIENTE POR REGISTRAR'),
(45, 'EDUCACION ARTISTICA-OFICINA', 'PENDIENTE POR REGISTRAR'),
(46, 'MANTENIMIENTO', 'PENDIENTE POR REGISTRAR'),
(47, 'EDUCACION FISICA', 'PENDIENTE POR REGISTRAR'),
(48, 'PROMOCION SOCIAL', 'PENDIENTE POR REGISTRAR'),
(49, 'SALON VALLENATO', 'PENDIENTE POR REGISTRAR'),
(50, 'COMEDOR', 'PENDIENTE POR REGISTRAR'),
(51, 'CONSEJERIA FANNY Y DELSY ', 'PENDIENTE POR REGISTRAR'),
(52, 'TALLER DE INFORMATICA ', 'JUAN INGLESIAS'),
(54, 'IDIOMAS ', 'PENDIENTE POR REGISTRAR'),
(55, 'SOCIALES', 'PENDIENTE POR REGISTRAR'),
(56, 'SALONES ARTES', 'PENDIENTE POR REGISTRAR'),
(57, 'TALLER DIBUJO 106-117', 'PENDIENTE POR REGISTRAR'),
(58, 'SALON DE MUSICA ', 'PENDIENTE POR REGISTRAR'),
(59, 'SALON ORQUESTA', 'PENDIENTE POR REGISTRAR'),
(60, 'COORDINACION 6°-7°-8°', 'PENDIENTE POR REGISTRAR'),
(61, 'ELECTRONICA 06-122', 'PENDIENTE POR REGISTRAR'),
(62, 'DEPOSITO DE ARETE 1 Y 2 ', 'PENDIENTE POR REGISTRAR'),
(63, 'TRABAJO SOCIAL ', 'PENDIENTE POR REGISTRAR'),
(64, 'PAGADURIA', 'PENDIENTE POR REGISTRAR'),
(65, 'MATEMATICA', 'PENDIENTE POR REGISTRAR'),
(66, 'ESPAÑOL', 'PENDIENTE POR REGISTRAR');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `dt`
--

CREATE TABLE IF NOT EXISTS `dt` (
  `activo` varchar(200) NOT NULL,
  `Descripcionactivo` varchar(200) NOT NULL,
  `precio` varchar(200) NOT NULL,
  `idt` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `descuento` varchar(5) NOT NULL,
  `preciototal` varchar(200) NOT NULL,
  `id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`),
  KEY `id-t` (`idt`),
  KEY `activo` (`activo`),
  KEY `Descripcion-activo` (`Descripcionactivo`),
  KEY `activo_2` (`activo`),
  KEY `activo_3` (`activo`),
  KEY `Descripcion-activo_2` (`Descripcionactivo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `procesos`
--

CREATE TABLE IF NOT EXISTS `procesos` (
  `Nombre_responsable` varchar(200) NOT NULL,
  `clave` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `procesos`
--

INSERT INTO `procesos` (`Nombre_responsable`, `clave`) VALUES
('Andy Arias', '321');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedores`
--

CREATE TABLE IF NOT EXISTS `proveedores` (
  `id_proveedores` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(200) NOT NULL,
  `Vendedor` varchar(200) NOT NULL,
  `Nit` varchar(50) NOT NULL,
  `Direccion` varchar(200) NOT NULL,
  `Telefono` varchar(11) NOT NULL,
  `celular` varchar(20) NOT NULL,
  `Ciudad` varchar(200) NOT NULL,
  PRIMARY KEY (`id_proveedores`),
  UNIQUE KEY `Nombre` (`Nombre`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Volcado de datos para la tabla `proveedores`
--

INSERT INTO `proveedores` (`id_proveedores`, `Nombre`, `Vendedor`, `Nit`, `Direccion`, `Telefono`, `celular`, `Ciudad`) VALUES
(6, 'PAPELERIA EL CID', 'Distribuidor del local', '8000494386', 'CARRERA 52 N° 72-72 ', '358-5745', '0', 'Barranquilla');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo-activo`
--

CREATE TABLE IF NOT EXISTS `tipo-activo` (
  `tipo` varchar(200) NOT NULL,
  PRIMARY KEY (`tipo`),
  KEY `tipo` (`tipo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipo-activo`
--

INSERT INTO `tipo-activo` (`tipo`) VALUES
('Consumo'),
('Devolutivo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo-transaccion`
--

CREATE TABLE IF NOT EXISTS `tipo-transaccion` (
  `Nombre` varchar(200) NOT NULL,
  PRIMARY KEY (`Nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipo-transaccion`
--

INSERT INTO `tipo-transaccion` (`Nombre`) VALUES
('Egreso de Consumo'),
('Egreso por Donacion'),
('Ingreso de Consumo'),
('Ingreso Devolutivo'),
('Ingreso por  Donacion'),
('Orden de Compra');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `transacciones`
--

CREATE TABLE IF NOT EXISTS `transacciones` (
  `idtransaccion` int(11) NOT NULL,
  `fecha` varchar(200) NOT NULL,
  `tipo` varchar(200) NOT NULL,
  `responsable` varchar(200) NOT NULL,
  `total` varchar(500) NOT NULL,
  `Departamento` varchar(200) NOT NULL,
  `Proveerdor` varchar(200) NOT NULL,
  PRIMARY KEY (`idtransaccion`),
  KEY `tipo` (`tipo`),
  KEY `Departamento` (`Departamento`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `activos`
--
ALTER TABLE `activos`
  ADD CONSTRAINT `activos_ibfk_1` FOREIGN KEY (`Categoria`) REFERENCES `cateogria` (`Nombre_categoria`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `activos_ibfk_2` FOREIGN KEY (`proveedor`) REFERENCES `proveedores` (`Nombre`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `activos_ibfk_3` FOREIGN KEY (`tipo`) REFERENCES `tipo-activo` (`tipo`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `d-activos`
--
ALTER TABLE `d-activos`
  ADD CONSTRAINT `d-activos_ibfk_1` FOREIGN KEY (`descripcion`) REFERENCES `dt` (`Descripcionactivo`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `rela1` FOREIGN KEY (`departamento`) REFERENCES `departamentos` (`Nombre_departamento`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `rela2` FOREIGN KEY (`activos`) REFERENCES `dt` (`activo`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `dt`
--
ALTER TABLE `dt`
  ADD CONSTRAINT `dt_ibfk_1` FOREIGN KEY (`idt`) REFERENCES `transacciones` (`idtransaccion`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `transacciones`
--
ALTER TABLE `transacciones`
  ADD CONSTRAINT `depart-tra` FOREIGN KEY (`Departamento`) REFERENCES `departamentos` (`Nombre_departamento`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `transacciones_ibfk_1` FOREIGN KEY (`tipo`) REFERENCES `tipo-transaccion` (`Nombre`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
