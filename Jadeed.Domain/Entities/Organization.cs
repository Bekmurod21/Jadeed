using Jadeed.Domain.Commons;
using Jadeed.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jadeed.Domain.Entities;

public class Organization:Auditable
{
    public string Title { get; set; }
    public long AddressId { get; set; }
    public string Description { get; set; }
    public OrganizationType Type { get; set; }
    //public File Document { get; set; }
}
