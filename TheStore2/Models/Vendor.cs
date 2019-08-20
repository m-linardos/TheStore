using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheStore2.Models
{
    public class Vendor
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        [Required]
        public String Code { get; set; }
        [MaxLength(30)]
        [Required]
        public string Name { get; set; }
        [MaxLength(30)]
        [Required]
        public string Address { get; set; }
        [MaxLength(30)]
        [Required]
        public String City { get; set; }
        [MaxLength(2)]
        [Required]
        public string State { get; set; }
        [MaxLength(5)]
        [Required]
        public string Zip { get; set; }
        [MaxLength(12)]
        public string Phone { get; set; }
        [MaxLength(255)]
        public string Email { get; set; }
    }
}
