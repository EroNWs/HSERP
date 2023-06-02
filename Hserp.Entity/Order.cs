﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Entity;

public class Order : BaseEntity
{
    public string Identification { get; set; }
    public DateTime OrderDate { get; set; }

    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; }

    public ICollection<OrderDetail> OrderDetails { get; set; }




}
