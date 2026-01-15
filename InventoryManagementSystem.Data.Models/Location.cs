using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Data.Models;

/* Since the data stored in this type is optional, not relevant to the business logic
and is always queried together with its owner's data, in the current version of the application,
there is no need for a separate table.*/
[Owned]
[Comment("Establishment's location")]
public class Location
{
    [Comment("Establishment's location country name.")]
    public string? Country { get; set; }
    
    [Comment("Establishment's location city name.")]
    public string? City { get; set; }
    
    [Comment("Establishment's location address.")]
    public string? Address { get; set; }
}