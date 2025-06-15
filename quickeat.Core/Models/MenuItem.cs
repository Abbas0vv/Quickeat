using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quickeat.Core.Interfaces;

namespace quickeat.Core.Models;

public class MenuItem : IEntity
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public bool IsAvailable { get; set; } = true;
    public int CategoryId { get; set; }

    public MenuCategory Category { get; set; }
    public List<OrderItem> OrderItems { get; set; }
}
