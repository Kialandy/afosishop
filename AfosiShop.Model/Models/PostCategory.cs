using AfosiShop.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AfosiShop.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(250)]
        public string Alias { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public int? ParentID { get; set; }

        public int? DisplayOrder { get; set; }

        [MaxLength(500)]
        public string Image { get; set; }

        public bool? HomeFlag { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }
    }
}