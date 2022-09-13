using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo2CodeFirst.Entity
{
    [Table("Books")]
    internal class Book
    {
        [Key]
        public string BookId { get; set; }

        [Required]
        [StringLength (30)]
        [Column(TypeName ="varchar")]
        public string BookName { get; set; }

        
        public int? Price { get; set; }  
        public string Author { get; set; }  
    }
}
