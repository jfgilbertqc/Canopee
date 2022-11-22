using System.ComponentModel.DataAnnotations;

namespace Canopee.Common.Utilities
{
    public class HardinessZoneValidationAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute
    {
        public string message => "The hardiness zone must be between 1a and 12b";
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var hardiness = value is null ? string.Empty : value.ToString();

            return hardiness.Length < 2 || hardiness.Length > 3 || !IsValidHardinessZone(hardiness) ? new ValidationResult(message) : ValidationResult.Success;
        }

        private bool IsValidHardinessZone(string hardiness)
        {
            int.TryParse(hardiness[..^1], out int zone);
            var subZone = hardiness[^1];
            return zone > 0 && zone < 13 && (subZone == 'a' || subZone == 'b');
        }
    }
}
