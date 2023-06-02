using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Entity;

public class OrderDetail : BaseEntity
{
    public Guid OrderId { get; set; }
    public Order Order { get; set; }

    public Guid StockId { get; set; }
    public Stock Stock { get; set; }

    public int Unit { get; set; }
    public decimal LineTotal { get; set; }
}
