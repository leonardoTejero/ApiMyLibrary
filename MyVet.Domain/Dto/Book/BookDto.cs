using MyLibrary.Domain.Dto.Book;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyLibrary.Domain.Dto
{
    public class BookDto : InsertBookDto
    {
        [Key]
        public int Id { get; set; }
        public int IdState { get; set; }
        public int? IdUserLibrarian { get; set; }

    }
}
