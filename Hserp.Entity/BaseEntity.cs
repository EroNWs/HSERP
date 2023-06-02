using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Entity;

public abstract class BaseEntity
{
    [Key]
    public Guid Id { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime? UpdateDate { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime? CreateDate { get; set; }
}
