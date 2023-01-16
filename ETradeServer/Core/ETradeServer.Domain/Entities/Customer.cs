using ETradeServer.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeServer.Domain.Entities
{
    public class Customer : IEntities
    {
        public Guid Id { get; set; }
        public ICollection<Order> Orders { get; set; }
        public string Name { get; set; }

    }
}
