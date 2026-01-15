using System.ComponentModel.DataAnnotations;

using static InventoryManagementSystem.Common.EntityValidationConstants.Category;

using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Data.Models;

[Comment("Resources category entity model.")]
public class Category
{
    [Key]
    [Required]
    [Comment("Category's primary key")]
    public required Guid Id { get; set; }
    
    [Key]
    [Required]
    [MaxLength(NameMaxLengthValue)]
    [Comment("The name of the category type.")]
    public required string Name { get; set; }
}