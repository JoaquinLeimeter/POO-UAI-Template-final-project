-- Agregar ABM Gestionar Usuarios

INSERT INTO FormularioPermiso (Formulario_Id, Permiso_Id) 
values (
	--Aqui seleccionas el formulario por nombre (me pareció mas facil por nombre del sistema)
	(SELECT Id FROM Formularios WHERE NombreSistema='formGestionarUsuarios'),
	--Aqui seleccionas el Permiso por nombre
	(SELECT Id FROM Permisos WHERE Nombre='Eliminar')
);

INSERT INTO PerfilFormulario (Perfil_Id, Formulario_Id)
values (
	(SELECT Id FROM Perfiles WHERE Nombre = 'Super Admin'),
	(SELECT Id FROM Formularios WHERE NombreSistema = 'formUsuario')
);

--insert into Usuarios values ('Mauro Falcone', 'maurofalcone.95@gmail.com', '37454893', 'Password@@01', 2)
--insert into Usuarios values ('Joaquin Leimeter', 'leimeter.95@gmail.com', '40454893', 'Password@@0123', 3)
--insert into Usuarios values ('Juan Perini', 'joe.95@gmail.com', '20454893', 'Password@@01lala', 1)