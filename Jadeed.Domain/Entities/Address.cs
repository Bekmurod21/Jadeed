using Jadeed.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jadeed.Domain.Entities;

public class Address:Auditable
{
    public string Country { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string Street { get; set; }
    public string Home { get; set; }
    public string ZipCode { get; set; }
}
