using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace quickeat.Core.Models;

public class QuickeatUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string ProfilePictureUrl { get; set; }
    // Navigation properties
    public List<Order> Orders { get; set; }
    public List<Restaurant> OwnedRestaurants { get; set; }
    public List<Blog> AuthoredBlogs { get; set; }
}
