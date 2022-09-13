using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Demo2CodeFirst.Entity
{ 
    [Table("Orders")]
    internal class Order
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        [ForeignKey("Book")]
        public string BookId { get; set; }
        public Book Book { get; set; }
    }
}
