using Infraestructure.Entity.Model.Library;
using Infraestructure.Entity.Model.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infraestructure.Entity.Model.Vet
{
    [Table("Book", Schema = "Library")]
    public class BookEntity
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Gender { get; set; }

        [ForeignKey("EditorialEntity")]
        public int IdEditorial { get; set; }
        public EditorialEntity EditorialEntity { get; set; }

        [ForeignKey("UserLibrarianEntity")]
        public int? IdUserLibrarian { get; set; }


        [ForeignKey("StateEntity")]
        public int IdState { get; set; }
        public StateEntity StateEntity { get; set; }

        public UserEntity UserLibrariantEntity { get; set; }
    }
}
