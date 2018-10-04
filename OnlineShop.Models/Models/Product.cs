using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        public Category Category { get; set; }

        [Required]
        [MaxLength(length: 15, ErrorMessage = "Max length of name")]
        public string Name { get; set; }

        [Range(0.01, double.MaxValue)]
        public double Price { get; set; }
    }
}