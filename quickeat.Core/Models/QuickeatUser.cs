using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace quickeat.Core.Models;

public class QuickeatUser : IdentityUser
{
    [Required(ErrorMessage = "First name is required")]
    [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Last name is required")]
    [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters")]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Address is required")]
    [StringLength(200, ErrorMessage = "Address cannot be longer than 200 characters")]
    public string Address { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    [Display(Name = "Email")]
    public override string Email { get; set; }

    [Required(ErrorMessage = "Phone number is required")]
    [Phone(ErrorMessage = "Invalid phone number")]
    [Display(Name = "Phone Number")]
    public override string PhoneNumber { get; set; }

    [Url(ErrorMessage = "Please enter a valid URL for the profile picture")]
    [Display(Name = "Profile Picture")]
    public string ProfilePictureUrl { get; set; }

    // Navigation properties
    [InverseProperty("User")]
    public List<Order> Orders { get; set; }

    [InverseProperty("Owner")]
    public List<Restaurant> OwnedRestaurants { get; set; }

    [InverseProperty("Author")]
    public List<Blog> AuthoredBlogs { get; set; }
}
