using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goplecs.GTracker.DAL.Models
{
    public class Grocery
    {
        public long GroceryId { get; set; }
        public string StoreName { get; set; }
        public string Users { get; set; }
        public double PersonalPrice { get; set; }
        [NotMapped]
        public bool HasPersonalPrice
        {
            get
            {
                return !string.IsNullOrEmpty(PersonalPrice.ToString());
            }
        }
        public virtual ICollection<GroceryItem> GroceryItems { get; set; }

    }
}
