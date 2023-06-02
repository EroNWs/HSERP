using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Entity;

public enum HsUserAuthType : byte
{
    None = 0,
    Customer = 1,
    Stock = 2,
    Order = 3,
    Report = 99
}
