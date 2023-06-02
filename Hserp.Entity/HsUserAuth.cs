using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Entity;

public class HsUserAuth : BaseEntity
{
    public Guid UserId { get; set; }
    public HsUser User { get; set; }
    public HsUserAuthType AuthType { get; set; }

}
