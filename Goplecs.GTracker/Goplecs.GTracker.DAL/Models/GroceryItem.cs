using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goplecs.GTracker.DAL
{
    public class GroceryItem
    {
        public long GroceryItemId { get; set; }
        public string ItemName { get; set; }
        public int ItemTypeId { get; set; }
        public int ItemCategory { get; set; }
        public double ItemPrice { get; set; }
        public string ItemBarcode { get; set; }
        public bool IsPersonal { get; set; }

    }
}

