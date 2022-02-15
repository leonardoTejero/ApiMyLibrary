using Common.Utils.Enums;
using Infraestructure.Core.UnitOfWork.Interface;
using Infraestructure.Entity.Model.Vet;
using MyLibrary.Domain.Dto;
using MyLibrary.Domain.Dto.Book;
using MyLibrary.Domain.Services.Interface;
using MyVet.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Domain.Services
{
    public class BookServices : IBookServices
    {
        #region Attributes
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region Builder
        public BookServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Methods

        public List<ConsultBookDto> GetAllMyBooks(int idUser)
        {
            var book = _unitOfWork.BookRepository.FindAll(x => x.EditorialEntity.UserEditorialEntity.IdUser == idUser,
                                                             p => p.EditorialEntity,
                                                             p => p.StateEntity);


            List<ConsultBookDto> listBooks = book.Select(x => new ConsultBookDto
            {
                Id = x.Id,
                Name = x.Name,
                Gender = x.Gender,
                IdEditorial = x.IdEditorial,
                Editorial = x.EditorialEntity.Name,
                IdState = x.IdState,
                IdUserLibrarian = x.IdUserLibrarian,
                Estado = x.StateEntity.State,
             
            }).ToList();

            return listBooks;
        }

        public async Task<bool> InsertBookAsync(InsertBookDto book)
        {

            BookEntity books = new BookEntity()
            {
                Name = book.Name,
                Gender = book.Gender,
                IdEditorial = book.IdEditorial,
                IdState = (int)Enums.State.LibroEnviado,
            };
            _unitOfWork.BookRepository.Insert(books);

            return await _unitOfWork.Save() > 0;
        }

        public async Task<ResponseDto> DeleteBookAsync(int idBook)
        {
            ResponseDto response = new ResponseDto();

            _unitOfWork.BookRepository.Delete(idBook);

            response.IsSuccess = await _unitOfWork.Save() > 0;

            if (response.IsSuccess)
                response.Message = "Se elminnó correctamente el libro";
            else
                response.Message = "Hubo un error al eliminar el libro, por favor vuelva a intentalo";

            return response;
        }

        public async Task<bool> UpdateBookAsync(BookDto book)
        {
            bool result = false;

            BookEntity books = _unitOfWork.BookRepository.FirstOrDefault(x => x.Id == book.Id);
            if (books != null)
            {

                books.Name = book.Name;
                books.Gender = book.Gender;
                books.IdEditorial = book.IdEditorial;
                books.IdState = book.IdState;

                _unitOfWork.BookRepository.Update(books);
                result = await _unitOfWork.Save() > 0;
            }

            return result;
        }

        #endregion
    }
}
