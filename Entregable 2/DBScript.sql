create database Othello;

use Othello;

create table USUARIO(
	username varchar(60) not null,
	nombres varchar(60) not null,
	apellidos varchar(60) not null,
	contraseña varchar(100) not null,
	fechanac date not null,
	pais varchar(60) not null,
	email varchar(100) not null,

	constraint PK_username primary key (username));

create table PARTIDA(
	idpartida int not null identity(1,1),
	movimientos int not null,

	constraint PK_idPartida primary key (idpartida));

create table TIPOPARTIDA(
	idtipo int not null identity(1,1),
	nombre varchar(25),
	constraint PK_idTipo primary key (idtipo)
	);
	
create table PARTIDASUSUARIOS(
	idpartusers int not null identity(1,1),
	username varchar(60) not null,
	idpartida int not null,

	constraint PK_idPartUsers primary key (idpartusers),
	constraint FK_username foreign key (username) references USUARIO(username),
	constraint FK_idpartida foreign key (idpartida) references PARTIDA(idpartida)
);

create table RESULTADO(
	idresultado int not null identity(1,1),
	nombre varchar(25) not null,

	constraint PK_idResultado primary key (idresultado)
);

create table CANTIDADPARTICIPANTES(
	idcantidad int not null identity(1,1),
	numero int not null,

	constraint PK_idCantidad primary key (idcantidad)
);

create table TORNEOS(
	nombre varchar(150) not null,
	idcantidad int not null,

	constraint PK_Nombre primary key (nombre),
	constraint FK_idCantidad foreign key (idcantidad) references CANTIDADPARTICIPANTES(idcantidad)
);

create table TORNEOSRESULTADOS(
	idtornres int not null identity(1,1),
	rondas int not null,
	usuario varchar(60) not null,
	resultado int not null,
	idtorneo varchar(150) not null,

	constraint PK_idTornRes primary key (idtornres),
	constraint FK_NombreUsuario foreign key (usuario) references USUARIO(username),
	constraint FK_idResultado foreign key (resultado) references RESULTADO(idresultado),
	constraint FK_idTorneo foreign key (idtorneo) references TORNEOS(nombre)

);