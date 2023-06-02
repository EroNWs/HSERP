using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Entity;

public class HsUser : BaseEntity
{
    [MinLength(3)]
    public string Username { get; set; } = string.Empty;
    [MinLength(1)]
    public string Password { get; set; } = string.Empty;
    [MinLength(9)]
    public string? Email { get; set; }

    public List<HsUserAuth> UserAuths { get; set; }

}
