using Infraestructure.Core.Repository.Interface;
using Infraestructure.Entity.Model;
using Infraestructure.Entity.Model.Library;
using Infraestructure.Entity.Model.Master;
using Infraestructure.Entity.Model.Vet;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Core.UnitOfWork.Interface
{
    public interface IUnitOfWork
    {
        IRepository<UserEntity> UserRepository { get; }

        IRepository<RolEntity> RolRepository { get; }

        IRepository<RolUserEntity> RolUserRepository { get; }

        IRepository<StateEntity> StateRepository { get; }

        IRepository<TypeStateEntity> TypeStateRepository { get; }

        IRepository<PermissionEntity> PermissionRepository { get; }

        IRepository<TypePermissionEntity> TypePermissionRepository { get; }

        IRepository<RolPermissionEntity> RolesPermissionRepository { get; }

        IRepository<EditorialEntity> EditorialRepository { get; }

        IRepository<UserEditorialEntity> UserEditorialRepository { get; }

        IRepository<BookEntity> BookRepository { get; }



        new void Dispose();

        Task<int> Save();
    }
}
