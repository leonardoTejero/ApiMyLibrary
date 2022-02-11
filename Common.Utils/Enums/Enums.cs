using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Utils.Enums
{
    public class Enums
    {
        public enum TypeState
        {
            //Usuario
            EstadoUsuario = 1,
            EstadoLibro = 2,
        }

        public enum State
        {
            //Usuario
            UsuarioActivo = 1,
            UsuarioInactivo = 2,
            UsuarioSuspendido = 3,

            //Libro
            LibroEnviado = 4,
            LibroAprobado = 5,
            LibroCancelado = 6,
        }

        public enum TypePermission
        {
            Usuarios = 1,
            Roles = 2,
            Permisos = 3,
            Biblioteca = 4,
            Estados = 5,
            Editorial = 6,
        }

        public enum Permission
        {
            //Usuarios
            CrearUsuarios = 1,
            ActualizarUsuarios = 2,
            EliminarUsuarios = 3,
            ConsultarUsuarios = 4,

            //Roles
            ActualizarRoles = 5,
            ConsultarRoles = 6,

            //Permisos
            ActualizarPermisos = 7,
            ConsultarPermisos = 8,
            DenegarPermisos = 9,

            //Editorial
            CrearEditorial = 10,
            ActualizarEditorial = 11,
            EliminarEditorial = 12,
            ConsultarEditorial = 13,

            //Biblioteca
            CrearLibro=14,
            ConsultarLibros=15,
            CancelarLibros=16,
            ActualizarLibros=17,
            ActualizarLibroBibliotecario=18,
            ConsultarLibrosBibliotecario = 19,
            CancelarLibroBibliotecario=20,
            EliminarLibro=21,

            //Estados
            ConsultarEstados = 22,
            ActualizarEstado = 23,
        }
       
        public enum RolUser
        {
            Administrador = 1,
            Bibliotecario = 2,
            Estandar= 3
        }

    }
}
