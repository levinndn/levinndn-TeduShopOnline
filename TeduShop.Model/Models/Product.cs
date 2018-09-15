using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using TeduShop.Model.Abtract;

namespace TeduShop.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Alias { set; get; }

        [Required]
        public int CategoryID { set; get; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategorie { set; get; }

        public XElement MoreImage { set; get; }

        public decimal? PromotionPrice { set; get; }

        [MaxLength(500)]
        public string Decription { set; get; }

        public string Content { set; get; }

        public int? Warranty { set; get; }

        public decimal Price { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        public bool? HotFlag { set; get; }

        public int? ViewCount { set; get; }
    }
}