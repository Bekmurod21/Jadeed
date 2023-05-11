using Jadeed.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jadeed.Domain.Entities;

public class Grade:Auditable
{
    public int Level { get; set; }
    public string LevelKey { get; set; }
    public long TeacherId { get; set; }
    public long[] StudentIds { get; set; }
    public long[] SubjectId { get; set; }
}
