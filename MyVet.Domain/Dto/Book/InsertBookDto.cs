using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyLibrary.Domain.Dto.Book
{
    public class InsertBookDto
    {
        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "El genero es requerido")]
        [MaxLength(100)]
        public string Gender { get; set; }

        public int IdEditorial { get; set; }
    }
}
