using Jadeed.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jadeed.Domain.Entities;

public class Event:Auditable
{
    public string Title { get; set; }
    public DateTime Time { get; set; }
    public string Description { get; set; }
    public long[] UserIds { get; set; }
}
