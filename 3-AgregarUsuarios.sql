use TP_MODULO_POO

--insert into Usuarios values ('Mauro Falcone', 'maurofalcone.95@gmail.com', '37454893', 'Password@@01', 2)
--insert into Usuarios values ('Joaquin Leimeter', 'leimeter.95@gmail.com', '40454893', 'Password@@0123', 3)
--insert into Usuarios values ('Juan Perini', 'joe.95@gmail.com', '20454893', 'Password@@01lala', 1)

insert into Usuarios (Nombre, Email, Dni, Contraseña, Perfil_Id)
values (
('Super Admin User'),
('SAD@admins.com'),
('123456'),
('123456'),
(SELECT Id from Perfiles WHERE Perfiles.Nombre='Super Admin')
)