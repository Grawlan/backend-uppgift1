using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend_uppgift1.Models
{

        [Table("products")]
        [Index(nameof(ProductName), Name = "UQ__products__DD5A978A6601E7E7", IsUnique = true)]
        public partial class CreateProductModel
        {
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

