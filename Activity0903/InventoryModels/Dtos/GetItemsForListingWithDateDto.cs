using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels.Dtos
{
    public class GetItemsForListingWithDateDto : GetItemsForListingDto
    {
        public DateTime CreatedDate { get; set; }
    }
}
