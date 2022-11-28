using System.ComponentModel;

namespace Canopee.Common.Utilities
{
    public class HardinessUtil
    {

        public static bool ValidateHardinessZone(string hardiness)
        {
            _ = int.TryParse(hardiness[..^1], out int zone);
            var subZone = hardiness[^1];
            return zone > 0 && zone < 13 && (subZone == 'a' || subZone == 'b');
        }

        public static string GetEnumDescription(Enum enumValue)
        {
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

            if (fieldInfo == null) throw new Exception("Enum value not found");

            var descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : enumValue.ToString();
        }

    }
}
