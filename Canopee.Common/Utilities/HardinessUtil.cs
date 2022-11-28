using System.ComponentModel;
using System.Globalization;

using static Canopee.Common.DataTransferObjects.TreeEnums;

namespace Canopee.Common.Utilities
{
    public class HardinessUtil
    {
        public static HardinessZone GetHardinessFromNumber(float hardiness)
        {
            var values = hardiness.ToString("0.0", CultureInfo.InvariantCulture).Split('.');
            var description = values[1].Equals("0") ? values[0] + 'b' : values[0] + 'a';
            return description.GetValueFromDescription<HardinessZone>();
        }

        public static float GetHardinessFromString(string hardiness)
        {
            if (!ValidateHardinessZone(hardiness)) throw new Exception($"Invalid HardinessZone:{hardiness}");

            char[] values = new char[2] { hardiness[0], hardiness[1] };
            var hardinessSubZone = values[1] == 'b' ? 0 : 5;
            return float.Parse($"{values[0]}.{hardinessSubZone}", CultureInfo.InvariantCulture);
        }

        public static bool ValidateHardinessZone(string hardiness)
        {
            _ = int.TryParse(hardiness[..^1], out int zone);
            var subZone = hardiness[^1];
            return zone > 0 && zone < 13 && (subZone == 'a' || subZone == 'b');
        }

        public static float GetHardinessFromEnum(HardinessZone hardiness) => GetHardinessFromString(GetEnumDescripton(hardiness));

        private static string GetEnumDescripton(Enum enumValue)
        {
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

            if (fieldInfo == null) throw new Exception("Enum value not found");

            var descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : enumValue.ToString();
        }

    }
}
