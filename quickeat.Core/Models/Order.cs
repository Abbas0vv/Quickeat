using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quickeat.Core.Interfaces;

namespace quickeat.Core.Models;

public class Order : IEntity
{
    public string Id { get; set; }
    public string UserId { get; set; }
    public QuickeatUser User { get; set; }
    public int RestaurantId { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    public decimal TotalAmount { get; set; }
    public string Status { get; set; } // "Pending", "Processing", "Completed", "Cancelled"
    public string DeliveryAddress { get; set; }
    public Restaurant Restaurant { get; set; }
    public List<OrderItem> OrderItems { get; set; }
}
