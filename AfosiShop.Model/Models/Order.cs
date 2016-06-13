using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfosiShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerName { get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerAddress { get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerEmail { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string CustomerMobile { get; set; }

        [Required]
        [MaxLength(50)]
        public string CustomerMessage { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        [MaxLength(50)]
        public string PaymentMethod { get; set; }

        public string PaymentStatus { get; set; }

        [Required]
        public bool Status { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
