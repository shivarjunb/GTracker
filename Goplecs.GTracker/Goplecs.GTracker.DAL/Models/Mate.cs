using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goplecs.GTracker.DAL.Models
{
    class Mate
    {
        public int Id { get; set; }
        public long UserId { get; set; }
        public long FriendId { get; set; }
    }
}
