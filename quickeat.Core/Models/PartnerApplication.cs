using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quickeat.Core.Interfaces;

namespace quickeat.Core.Models;

public class PartnerApplication : IEntity
{
    public string Id { get; set; }
    public string RestaurantName { get; set; }
    public string ContactName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public DateTime ApplicationDate { get; set; } = DateTime.UtcNow;
    public string Status { get; set; } = "Pending"; // "Pending", "Approved", "Rejected"
}
