using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quickeat.Core.Models;

public class CartItem
{
    public int MenuItemId { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
}
