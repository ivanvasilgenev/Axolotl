using System;
using System.ComponentModel.DataAnnotations;

namespace Axolotl.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }
    }
}
