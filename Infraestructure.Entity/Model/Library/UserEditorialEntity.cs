using Infraestructure.Entity.Model.Vet;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infraestructure.Entity.Model.Library
{
    [Table("UserEditorial", Schema = "Library")]
    public class UserEditorialEntity
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("EditorialEntity")]
        public int IdEditorial { get; set; }

        public EditorialEntity EditorialEntity { get; set; }

        [ForeignKey("UserEntity")]
        public int IdUser { get; set; }

        public UserEntity UserEntity { get; set; }
    }
}
