using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using quickeat.Core.Enums;
using quickeat.Core.Interfaces;

namespace quickeat.Core.Models;

public class PartnerApplication : IEntity
{
    public string Id { get; set; }

    [Required(ErrorMessage = "Restaurant name is required")]
    [StringLength(100, ErrorMessage = "Restaurant name cannot exceed 100 characters")]
    [Display(Name = "Restaurant Name")]
    public string RestaurantName { get; set; }

    [Required(ErrorMessage = "Contact person name is required")]
    [StringLength(100, ErrorMessage = "Contact name cannot exceed 100 characters")]
    [Display(Name = "Contact Person")]
    public string ContactName { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email address format")]
    [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Phone number is required")]
    [Phone(ErrorMessage = "Invalid phone number format")]
    [StringLength(20, ErrorMessage = "Phone number cannot exceed 20 characters")]
    [Display(Name = "Phone Number")]
    public string Phone { get; set; }

    [Required(ErrorMessage = "Address is required")]
    [StringLength(200, ErrorMessage = "Address cannot exceed 200 characters")]
    [DataType(DataType.MultilineText)]
    public string Address { get; set; }

    [DataType(DataType.DateTime)]
    [Display(Name = "Application Date")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
    public DateTime ApplicationDate { get; set; } = DateTime.UtcNow;

    [Display(Name = "Processing Status")]
    public PartnerApplicationStatus Status { get; set; } = PartnerApplicationStatus.Pending;


    // Additional recommended properties
    [StringLength(500, ErrorMessage = "Additional notes cannot exceed 500 characters")]
    [Display(Name = "Additional Information")]
    public string AdditionalNotes { get; set; }

    [Url(ErrorMessage = "Invalid website URL format")]
    [Display(Name = "Website URL")]
    public string WebsiteUrl { get; set; }

    [Range(1, 100, ErrorMessage = "Number of locations must be between 1 and 100")]
    [Display(Name = "Existing Locations")]
    public int? ExistingLocationsCount { get; set; }
}