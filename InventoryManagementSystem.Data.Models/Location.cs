using System.ComponentModel.DataAnnotations;

using static InventoryManagementSystem.Common.EntityValidationConstants.Location;

using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Data.Models;

/* Since the data stored in this type is optional, not relevant to the business logic
and is always queried together with its owner's data, in the current version of the application,
there is no need for a separate table and spatial data.*/
[Owned]
[Comment("Establishment's location")]
public class Location
{
    [MaxLength(CountryMaxLengthValue)]
    [Comment("Establishment's location country name.")]
    public string? Country { get; set; }
    
    [MaxLength(CityMaxLengthValue)]
    [Comment("Establishment's location city name.")]
    public string? City { get; set; }
    
    [MaxLength(AddressMaxLengthValue)]
    [Comment("Establishment's location address.")]
    public string? Address { get; set; }
}