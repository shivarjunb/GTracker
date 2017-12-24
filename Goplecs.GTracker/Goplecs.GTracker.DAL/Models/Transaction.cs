using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goplecs.GTracker.DAL.Models
{
    public class Transaction
    {
        public long Id { get; set; }
        public double Amount { get; set; }
        public long GroceryId { get; set; }
        public long OwnerId { get; set; }
        public long PayeeId { get; set; }

    }
}
