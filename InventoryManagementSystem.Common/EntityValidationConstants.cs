namespace InventoryManagementSystem.Common;

/// <summary>
/// This class provides with valid values constraints meant to be used in the process of describing entity models and application DTOs.
/// </summary>
public static class EntityValidationConstants
{
    public static class Establishment
    {
        public const byte NameMaxLengthValue = 100;
    }

    public static class Location
    {
        public const byte CountryMaxLengthValue = 100;
        public const byte CityMaxLengthValue = 100;
        public const byte AddressMaxLengthValue = 200;
    }
}