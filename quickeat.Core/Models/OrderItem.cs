using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using quickeat.Core.Interfaces;

namespace quickeat.Core.Models;

public class OrderItem : IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "Order Item ID")]
    public string Id { get; set; }

    [Required(ErrorMessage = "Order reference is required")]
    [Display(Name = "Order")]
    public string OrderId { get; set; }

    [Required(ErrorMessage = "Menu item is required")]
    [Display(Name = "Menu Item")]
    public string MenuItemId { get; set; }

    [Required(ErrorMessage = "Quantity is required")]
    [Range(1, 100, ErrorMessage = "Quantity must be between 1 and 100")]
    public int Quantity { get; set; }

    [Required(ErrorMessage = "Price is required")]
    [Column(TypeName = "decimal(18,2)")]
    [Range(0.01, 1000, ErrorMessage = "Price must be between $0.01 and $1,000")]
    [Display(Name = "Unit Price")]
    [DataType(DataType.Currency)]
    public decimal UnitPrice { get; set; }

    // Additional useful properties
    [StringLength(500, ErrorMessage = "Special instructions cannot exceed 500 characters")]
    [Display(Name = "Special Instructions")]
    public string SpecialInstructions { get; set; }

    [Display(Name = "Item Subtotal")]
    [NotMapped] // Calculated property, not stored in DB
    public decimal ItemSubtotal => UnitPrice * Quantity;

    // Navigation properties
    [ForeignKey("OrderId")]
    public Order Order { get; set; }

    [ForeignKey("MenuItemId")]
    [Display(Name = "Menu Item")]
    public MenuItem MenuItem { get; set; }
}