using System.ComponentModel.DataAnnotations;

using static InventoryManagementSystem.Common.EntityValidationConstants.Establishment;

using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Data.Models;

[Comment("Establishment entity model.")]
public class Establishment
{
    [Key]
    [Required]
    [Comment("Establishment's primary key.")]
    public required Guid Id { get; set; }
    
    [Required]
    [MaxLength(NameMaxLengthValue)]
    [Comment("Establishment's name")]
    public required string Name { get; set; }
    
    [Comment("Establishment's location")]
    public Location? Location { get; set; }
}