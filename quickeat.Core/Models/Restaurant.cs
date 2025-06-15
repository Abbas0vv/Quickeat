using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using quickeat.Core.Enums;
using quickeat.Core.Interfaces;

namespace quickeat.Core.Models;

public class Restaurant : IEntity
{
    public string Id { get; set; }
    public RestaurantType Type { get; set; }

    [Required(ErrorMessage = "Restaurant name is required")]
    [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
    [Display(Name = "Restaurant Name")]
    public string Name { get; set; }

    [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
    [DataType(DataType.MultilineText)]
    public string Description { get; set; }

    [Required(ErrorMessage = "Address is required")]
    [StringLength(200, ErrorMessage = "Address cannot exceed 200 characters")]
    public string Address { get; set; }

    [Required(ErrorMessage = "Phone number is required")]
    [Phone(ErrorMessage = "Invalid phone number format")]
    [StringLength(20, ErrorMessage = "Phone number cannot exceed 20 characters")]
    public string Phone { get; set; }

    [Url(ErrorMessage = "Invalid URL format")]
    [Display(Name = "Logo Image URL")]
    public string LogoUrl { get; set; }

    [Display(Name = "Active Status")]
    public bool IsActive { get; set; } = true;

    [Required(ErrorMessage = "Owner is required")]
    [Display(Name = "Owner ID")]
    public string OwnerId { get; set; }

    [ForeignKey("OwnerId")]
    [Display(Name = "Owner")]
    public QuickeatUser Owner { get; set; }

    // Navigation properties
    [InverseProperty("Restaurant")]
    public List<MenuCategory> MenuCategories { get; set; } = new List<MenuCategory>();

    [InverseProperty("Restaurant")]
    public List<Order> Orders { get; set; } = new List<Order>();

    [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5")]
    [Column(TypeName = "decimal(3,2)")]  // Stores as 3 digits with 2 decimal places
    public decimal? Rating { get; set; }  // Nullable for new/unrated restaurants

    [Required]
    [DataType(DataType.Time)]
    [Display(Name = "Opening Time")]
    public TimeSpan OpeningTime { get; set; } = new TimeSpan(9, 0, 0); // Default: 9 AM

    [Required]
    [DataType(DataType.Time)]
    [Display(Name = "Closing Time")]
    public TimeSpan ClosingTime { get; set; } = new TimeSpan(21, 0, 0); // Default: 9 PM
}