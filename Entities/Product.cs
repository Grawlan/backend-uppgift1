using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace backend_uppgift1.Entities
{
    [Table("products")]
    [Index(nameof(ProductName), Name = "UQ__products__DD5A978A6601E7E7", IsUnique = true)]
    public partial class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string ProductName { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        public string ProductImgUrl { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
    }
}
