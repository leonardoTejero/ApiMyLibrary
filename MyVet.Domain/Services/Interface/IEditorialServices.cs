using MyLibrary.Domain.Dto;
using MyLibrary.Domain.Dto.Editorial;
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
        Task<bool> InsertEditorialAsync(InsertEditorialDto editorial, int idUser);
        Task<bool> UpdateEditorialAsync(EditorialDto editorial);
    }
}
