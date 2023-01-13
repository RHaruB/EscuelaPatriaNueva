create database EscuelaPatriaNueva

use EscuelaPatriaNueva

Create table Persona(
	Id int not null IDENTITY(1,1) primary key,
	Cedula varchar(13) not null,
	Nombre varchar(max),
	Apellido varchar(max),
	Telefono varchar(15),
	Direccion varchar(max),
	FechaNacimiento datetime
)

Create table Usuario(
	IdUsuario int not null IDENTITY(1,1) primary key,
	NombreUsuario varchar(25),
	Contrasena varchar(10),
	IdPersona int  FOREIGN KEY REFERENCES Persona(Id)
)
Create table Docente(
	IdDocente int not null IDENTITY(1,1) primary key,
	IdPersona int  FOREIGN KEY REFERENCES Persona(Id)
)

Create table Curso(
	IdCurso int not null IDENTITY(1,1) primary key,
	IdDocente int  FOREIGN KEY REFERENCES Docente(IdDocente),
	Descripcion varchar not null 
)

Create table Matricula(
	IdMatricula int not null IDENTITY(1,1) primary key,
	Fecha datetime,
	IdRepresentante int  FOREIGN KEY REFERENCES Persona(Id),
	
)

Create table MatriculaCurso(
	IdMatricula int  FOREIGN KEY REFERENCES Matricula(IdMatricula),
	IdCurso int  FOREIGN KEY REFERENCES Curso(IdCurso)
)

Create table Estudiante(
	IdEstudiante int not null IDENTITY(1,1) primary key,
	IdPersona int  FOREIGN KEY REFERENCES Persona(Id),
	IdMatricula int  FOREIGN KEY REFERENCES Matricula(IdMatricula)

)