using MyLibrary.Domain.Dto;
using MyVet.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Domain.Services.Interface
{
    public interface IBookServices
    {
        List<BookDto> GetAllMyBooks(int idUser);
        Task<bool> InsertBookAsync(BookDto book);
        Task<ResponseDto> DeleteBookAsync(int idBook);
        Task<bool> UpdateBookAsync(BookDto book);
    }
}
