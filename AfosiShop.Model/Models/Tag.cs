using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AfosiShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Type { get; set; }

        public virtual IEnumerable<ProductTag> ProductTags { get; set; }
    }
}