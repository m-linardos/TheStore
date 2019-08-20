using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheStore2.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        [Required]
        public String PartNbr { get; set; }

        [MaxLength(30)]
        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

          [MaxLength(30)]
    [Required]
    public String Unit { get; set; }

        [MaxLength(8)]
        public string PhotoPath { get; set; }

    [Required]
    public int VendorId{ get; set; }

}
}
