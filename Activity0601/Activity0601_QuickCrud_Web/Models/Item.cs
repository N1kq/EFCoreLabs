using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity0601_QuickCrud_Web.Models
{
    public class Item
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
