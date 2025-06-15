using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quickeat.Core.Interfaces;

namespace quickeat.Core.Models;

public class Faq : IEntity
{
    public string Id { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }
    public string Category { get; set; }
}
