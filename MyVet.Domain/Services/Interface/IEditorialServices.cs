using MyLibrary.Domain.Dto;
using MyVet.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Domain.Services.Interface
{
    public interface IEditorialServices
    {
        List<EditorialDto> GetAllMyEditorial(int idUser);
        Task<ResponseDto> DeleteEditorialAsync(int idEditorial);
        Task<bool> InsertEditorialAsync(EditorialDto editorial, int idUser);
        Task<bool> UpdateEditorialAsync(EditorialDto editorial);
    }
}
