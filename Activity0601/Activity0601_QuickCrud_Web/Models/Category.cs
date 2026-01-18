using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity0601_QuickCrud_Web.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        public virtual List<Item> Items { get; set; } = new List<Item>();
    }
}
