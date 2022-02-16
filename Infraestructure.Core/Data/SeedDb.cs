using Common.Utils.Enums;
using Infraestructure.Entity.Model;
using Infraestructure.Entity.Model.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infraestructure.Core.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        #region Builder
        public SeedDb(DataContext context)
        {
            _context = context;
        }
        #endregion


        public async Task ExecSeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckTypeStateAsync();
            await CheckStateAsync();
            await CheckTypePermissionAsync();
            await CheckPermissionAsync();
            await CheckRolAsync();
            await CheckRolPermissonAsync();
            await CheckUserAsync();
            await CheckRolUserAsync();

        }

        private async Task CheckTypeStateAsync()
        {
            if (!_context.TypeStateEntity.Any())
            {
                _context.TypeStateEntity.AddRange(new List<TypeStateEntity>
                {
                    new TypeStateEntity
                    {
                        IdTypeState=(int)Enums.TypeState.EstadoUsuario,
                        TypeState="Estado de Usuarios"
                    },
                    new TypeStateEntity
                    {
                        IdTypeState=(int)Enums.TypeState.EstadoLibro,
                        TypeState="Estado del libro"
                    },
                });

                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckStateAsync()
        {
            if (!_context.StateEntity.Any())
            {
                _context.StateEntity.AddRange(new List<StateEntity>
                {
                    new StateEntity
                    {
                        IdTypeState=(int)Enums.TypeState.EstadoUsuario,
                        IdState=(int)Enums.State.UsuarioActivo,
                        State="Activo"
                    },
                    new StateEntity
                    {
                        IdTypeState=(int)Enums.TypeState.EstadoUsuario,
                        IdState=(int)Enums.State.UsuarioInactivo,
                        State="Inactivo"
                    },
                    new StateEntity
                    {
                        IdTypeState=(int)Enums.TypeState.EstadoUsuario,
                        IdState=(int)Enums.State.UsuarioSuspendido,
                        State="Suspendido"
                    },
                    new StateEntity
                    {
                        IdTypeState=(int)Enums.TypeState.EstadoLibro,
                        IdState=(int)Enums.State.LibroEnviado,
                        State="Libro Enviado"
                    },
                    new StateEntity
                    {
                        IdTypeState=(int)Enums.TypeState.EstadoLibro,
                        IdState=(int)Enums.State.LibroAprobado,
                        State="Libro Aprobado"
                    },
                    new StateEntity
                    {
                        IdTypeState=(int)Enums.TypeState.EstadoLibro,
                        IdState=(int)Enums.State.LibroCancelado,
                        State="Libro Cancelado"
                    },
                });

                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckTypePermissionAsync()
        {
            if (!_context.TypePermissionEntity.Any())
            {
                _context.TypePermissionEntity.AddRange(new List<TypePermissionEntity>
                {
                    new TypePermissionEntity
                    {
                        IdTypePermission=(int)Enums.TypePermission.Usuarios,
                        TypePermission="Usuarios"
                    },
                    new TypePermissionEntity
                    {
                        IdTypePermission=(int)Enums.TypePermission.Roles,
                        TypePermission="Roles"
                    },
                    new TypePermissionEntity
                    {
                        IdTypePermission=(int)Enums.TypePermission.Permisos,
                        TypePermission="Permisos"
                    },
                    new TypePermissionEntity
                    {
                        IdTypePermission=(int)Enums.TypePermission.Estados,
                        TypePermission="Estados"
                    },
                    new TypePermissionEntity
                    {
                        IdTypePermission=(int)Enums.TypePermission.Editorial,
                        TypePermission="Editorial"
                    },
                    new TypePermissionEntity
                    {
                        IdTypePermission=(int)Enums.TypePermission.Biblioteca,
                        TypePermission="Biblioteca"
                    },
                });

                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckPermissionAsync()
        {
            if (!_context.PermissionEntity.Any())
            {
                _context.PermissionEntity.AddRange(new List<PermissionEntity>
                {
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.CrearUsuarios,
                        IdTypePermission=(int)Enums.TypePermission.Usuarios,
                        Permission="Crear Usuarios",
                        Description="Crear usuarios en el sistema"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ActualizarUsuarios,
                        IdTypePermission=(int)Enums.TypePermission.Usuarios,
                        Permission="Actualizar Usuarios",
                        Description="Actualizar datos de un usuario en el sistema"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.EliminarUsuarios,
                        IdTypePermission=(int)Enums.TypePermission.Usuarios,
                        Permission="Eliminar Usuarios",
                        Description="Eliminar un usuairo del sistema"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ConsultarUsuarios,
                        IdTypePermission=(int)Enums.TypePermission.Usuarios,
                        Permission="Consultar Usuarios",
                        Description="Consulta todos los usuarios"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ActualizarRoles,
                        IdTypePermission=(int)Enums.TypePermission.Roles,
                        Permission="Actualizar Roles",
                        Description="Actualizar datos de un Roles en el sistema"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ConsultarRoles,
                        IdTypePermission=(int)Enums.TypePermission.Roles,
                        Permission="Consultar Roles",
                        Description="Consultar Roles del sistema"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ActualizarPermisos,
                        IdTypePermission=(int)Enums.TypePermission.Permisos,
                        Permission="Actualizar Permisos",
                        Description="Actualizar datos de un Permiso en el sistema"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ConsultarPermisos,
                        IdTypePermission=(int)Enums.TypePermission.Permisos,
                        Permission="Consultar Permisos",
                        Description="Consultar Permisos del sistema"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.DenegarPermisos,
                        IdTypePermission=(int)Enums.TypePermission.Permisos,
                        Permission="Denegar Permisos Rol",
                        Description="Denegar permisos a un rol del sistema"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ConsultarEstados,
                        IdTypePermission=(int)Enums.TypePermission.Estados,
                        Permission="Consultar Estado",
                        Description="Consultar los estados del sistema"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ActualizarEstado,
                        IdTypePermission=(int)Enums.TypePermission.Estados,
                        Permission="Actualizar Estados",
                        Description="Actualizar los estados del sistema"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.CrearEditorial,
                        IdTypePermission=(int)Enums.TypePermission.Editorial,
                        Permission="Crear Editorial",
                        Description="Crear la información del Editorial"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ActualizarEditorial,
                        IdTypePermission=(int)Enums.TypePermission.Editorial,
                        Permission="Actualizar Editorial",
                        Description="Actualizar la información del Editorial"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.EliminarEditorial,
                        IdTypePermission=(int)Enums.TypePermission.Editorial,
                        Permission="Eliminar Editorial",
                        Description="Eliminar la información del Editorial"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ConsultarEditorial,
                        IdTypePermission=(int)Enums.TypePermission.Editorial,
                        Permission="Consultar Editorial",
                        Description="Consultar la información del Editorial"
                    },//bien
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.CrearLibro,
                        IdTypePermission=(int)Enums.TypePermission.Biblioteca,
                        Permission="Crear Libro",
                        Description="Crear la información del libro"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ConsultarLibros,
                        IdTypePermission=(int)Enums.TypePermission.Biblioteca,
                        Permission="Consultar Libro",
                        Description="Consultar la información del Libro"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ActualizarLibros,
                        IdTypePermission=(int)Enums.TypePermission.Biblioteca,
                        Permission="Cancelar Libro",
                        Description="Cancelar el Libro"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.CancelarLibros,
                        IdTypePermission=(int)Enums.TypePermission.Editorial,
                        Permission="Actualizar Libro",
                        Description="Actualizar el Libro"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.CancelarLibroBibliotecario,
                        IdTypePermission=(int)Enums.TypePermission.Biblioteca,
                        Permission="Cancelar Libro por un Bibliotecario",
                        Description="Cancelar Libro del Bibliotecario"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ActualizarLibroBibliotecario,
                        IdTypePermission=(int)Enums.TypePermission.Biblioteca,
                        Permission="Actualizar Libro por un Bibliotecario",
                        Description="Actualizar Libro del Bibliotecario"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ConsultarLibrosBibliotecario,
                        IdTypePermission=(int)Enums.TypePermission.Biblioteca,
                        Permission="Consultar Libro por un Bibliotecario",
                        Description="Consultar Libro del Bibliotecario"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.EliminarLibro,
                        IdTypePermission=(int)Enums.TypePermission.Biblioteca,
                        Permission="Eliminar Libro",
                        Description="Eliminar el Libro"
                    },
                });

                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckRolAsync()
        {
            if (!_context.RolEntity.Any())
            {
                _context.RolEntity.AddRange(new List<RolEntity>
                {
                    new RolEntity
                    {
                        IdRol=(int)Enums.RolUser.Administrador,
                        Rol="Administrador"
                    },
                    new RolEntity
                    {
                        IdRol=(int)Enums.RolUser.Bibliotecario,
                        Rol="Bibliotecario"
                    },
                     new RolEntity
                    {
                        IdRol=(int)Enums.RolUser.Estandar,
                        Rol="Estandar"
                    }
                });

                await _context.SaveChangesAsync();
            }
        }

        //Asigna todos los permisos al administrador
        private async Task CheckRolPermissonAsync()
        {
            if (!_context.RolPermissionEntity.Where(x => x.IdRol == (int)Enums.RolUser.Administrador).Any())
            {
                var rolesPermisosAdmin = _context.PermissionEntity.Select(x => new RolPermissionEntity
                {
                    IdRol = (int)Enums.RolUser.Administrador,
                    IdPermission = x.IdPermission
                }).ToList();

                _context.RolPermissionEntity.AddRange(rolesPermisosAdmin);

            }

            //Permisos usuario Estandar
            if (!_context.RolPermissionEntity.Where(x => x.IdRol == (int)Enums.RolUser.Estandar).Any())
            {
                _context.RolPermissionEntity.AddRange(new List<RolPermissionEntity>
                {
                    new RolPermissionEntity
                    {
                        IdRol = (int)Enums.RolUser.Estandar,
                        IdPermission = (int)Enums.Permission.CrearLibro

                    },
                    new RolPermissionEntity
                    {
                        IdRol = (int)Enums.RolUser.Estandar,
                        IdPermission = (int)Enums.Permission.ConsultarLibros

                    },
                    new RolPermissionEntity
                    {
                        IdRol = (int)Enums.RolUser.Estandar,
                        IdPermission = (int)Enums.Permission.ActualizarLibros

                    },
                    new RolPermissionEntity
                    {
                        IdRol = (int)Enums.RolUser.Estandar,
                        IdPermission = (int)Enums.Permission.EliminarLibro

                    },
                    new RolPermissionEntity
                    {
                        IdRol = (int)Enums.RolUser.Estandar,
                        IdPermission = (int)Enums.Permission.ConsultarEditorial
                    },
                    new RolPermissionEntity
                    {
                        IdRol = (int)Enums.RolUser.Estandar,
                        IdPermission = (int)Enums.Permission.ConsultarEstados

                    },
                });
            }

            await _context.SaveChangesAsync();
        }

        private async Task CheckUserAsync()
        {

            if (!_context.UserEntity.Any())
            {
                _context.UserEntity.AddRange(new List<UserEntity>
                {
                    new UserEntity
                    {
                        Name = "Leonardo",
                        LastName = "Tejero",
                        Email = "admin@gmail.com",
                        Password = "admin"

                    },
                    new UserEntity
                    {
                        Name = "Yunior",
                        LastName = "Castro",
                        Email = "estandar@gmail.com",
                        Password = "estandar"
                    },  
                });

                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckRolUserAsync()
        {

            if (!_context.RolUserEntity.Any())
            {
                var admin = _context.UserEntity.FirstOrDefault(x => x.Email == "admin@gmail.com");
                var estandar = _context.UserEntity.FirstOrDefault(x => x.Email == "estandar@gmail.com");  

                _context.RolUserEntity.AddRange(new List<RolUserEntity>
                {
                    new RolUserEntity
                    {
                        IdRol = (int)Enums.RolUser.Administrador,
                        IdUser = Convert.ToInt32(admin.IdUser),
                    },
                     new RolUserEntity
                    {
                        IdRol = (int)Enums.RolUser.Estandar,
                        IdUser = Convert.ToInt32(estandar.IdUser),
                    },
                });

                await _context.SaveChangesAsync();
            }
        }


    }
}