using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quickeat.Core.Interfaces;

namespace quickeat.Core.Models;

public class MenuCategory : IEntity
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int RestaurantId { get; set; }

    public Restaurant Restaurant { get; set; }
    public List<MenuItem> MenuItems { get; set; }
}
