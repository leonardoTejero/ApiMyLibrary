using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyLibrary.Domain.Dto
{
    public class BookDto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "El genero es requerido")]
        [MaxLength(100)]
        public string Gender { get; set; }


        public int IdEditorial { get; set; }
        public int IdState { get; set; }
        public int IdUser { get; set; }
        public string Editorial { get; set; }
        public string Estado { get; set; }
        public int? IdUserLibrarian { get; set; }

    }
}
