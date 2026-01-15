using System.ComponentModel.DataAnnotations;

using static InventoryManagementSystem.Common.EntityValidationConstants.Establishment;

using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Data.Models;

[Comment("Establishment entity.")]
public class Establishment
{
    [Key]
    [Required]
    [Comment("Entity primary key.")]
    public required int Id { get; set; }
    
    [Required]
    [MaxLength(NameMaxLengthValue)]
    [Comment("Establishment's name")]
    public required string Name { get; set; }
    
    [Comment("Establishment's location")]
    public Location? Location { get; set; }
}