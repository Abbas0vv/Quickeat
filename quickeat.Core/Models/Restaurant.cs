using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quickeat.Core.Interfaces;

namespace quickeat.Core.Models;

public class Restaurant : IEntity
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string LogoUrl { get; set; }
    public bool IsActive { get; set; } = true;
    public string OwnerId { get; set; } // Links to Identity User
    public QuickeatUser Owner { get; set; }

    public List<MenuCategory> MenuCategories { get; set; }
    public List<Order> Orders { get; set; }
}
