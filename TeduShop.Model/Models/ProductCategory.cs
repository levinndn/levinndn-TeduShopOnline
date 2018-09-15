﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abtract;

namespace TeduShop.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName ="varchar")]
        public string Alias { set; get; }

        [MaxLength(500)]
        public string Decription { set; get; }

        public int? ParenID { set; get; }

        public int? DisplayOrder { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        public virtual IEnumerable<Product> Products { set; get; }
    }
}