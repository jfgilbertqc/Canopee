using System.ComponentModel.DataAnnotations;

using static Canopee.Common.DataTransferObjects.TreeEnums;

namespace Canopee.Common.Utilities
{
    public class HardinessZoneValidationAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute
    {
        public string message => "The hardiness zone must be between 1a and 12b";
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            try
            {
                return Enum.IsDefined(typeof(HardinessZone), value) ? ValidationResult.Success : new ValidationResult(message);
            }
            catch
            {
                return new ValidationResult(message);
            }
        }
    }
}
