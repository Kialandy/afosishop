using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AfosiShop.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        public virtual IEnumerable<Menu> Menus { get; set; }
    }
}