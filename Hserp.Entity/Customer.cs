using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Entity;

public class Customer : BaseEntity
{
    [MinLength(3)]
    public string Code { get; set; }
    [MinLength(3)]
    public string Name { get; set; } 
    public string TaxOffice { get; set; }
    [MinLength(10)]
    public string TaxNumber { get; set; }
   
    public string Phone { get; set; }
   
    public string Address { get; set; }
    
    public string City { get; set; }
   
    public string Country { get; set; }

    public ICollection<Order> Orders { get; set; }

}
