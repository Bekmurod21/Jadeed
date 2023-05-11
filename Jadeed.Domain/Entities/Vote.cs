using Jadeed.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jadeed.Domain.Entities;

public class Vote:Auditable
{
    public long[] UserIds { get; set; }
    public long UserId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}
