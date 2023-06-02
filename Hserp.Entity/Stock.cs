using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Entity;

public class Stock : BaseEntity
{
    [MinLength(3)]
    public string Code { get; set; }

    [MinLength(3)]
    public string Name { get; set; }

    public decimal Price { get; set; }

    public ICollection<OrderDetail> OrderDetails { get; set; }

}
