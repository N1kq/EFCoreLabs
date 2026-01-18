using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    public class CategoryColor : IIdentityModel
    {
        [Key, ForeignKey("Category")]
        [Required]
        public int Id { get; set; }
        [StringLength(InventoryModelsConstants.MAX_COLORVALUE_LENGTH)]
        public string ColorValue { get; set; }

        public virtual Category Category { get; set; }
    }
}
