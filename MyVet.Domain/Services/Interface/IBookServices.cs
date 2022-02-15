using MyLibrary.Domain.Dto;
using MyLibrary.Domain.Dto.Book;
using MyVet.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Domain.Services.Interface
{
    public interface IBookServices
    {
        List<ConsultBookDto> GetAllMyBooks(int idUser);
        Task<bool> InsertBookAsync(InsertBookDto book);
        Task<ResponseDto> DeleteBookAsync(int idBook);
        Task<bool> UpdateBookAsync(BookDto book);
    }
}
