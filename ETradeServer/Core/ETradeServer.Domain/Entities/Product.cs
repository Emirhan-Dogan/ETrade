using ETradeServer.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeServer.Domain.Entities
{
    public class Product : IEntities
    { 
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int StockAmount { get; set; }
        public long UnitPrice { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
