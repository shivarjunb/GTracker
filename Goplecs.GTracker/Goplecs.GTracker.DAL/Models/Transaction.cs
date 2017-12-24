using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goplecs.GTracker.DAL
{
    public class Transaction
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public int GroceryId { get; set; }
        public long GroceryOwnerId { get; set; }
        public long PayeeId { get; set; }
    }
}

