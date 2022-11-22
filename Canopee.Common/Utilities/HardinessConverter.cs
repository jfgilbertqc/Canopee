using System.Globalization;

namespace Canopee.Common.Utilities
{
    public class HardinessConverter
    {
        public static string GetHardinessFromNumber(float hardiness)
        {
            var values = hardiness.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture).Split('.');
            return values[1].Equals("0") ? values[0] + 'b' : values[0] + 'a';
        }
        public static float GetHardinessFromString(string hardiness)
        {
            hardiness = !string.IsNullOrWhiteSpace(hardiness) && hardiness.Length == 2 ? hardiness : "1a";
            char[] values = new char[2] { hardiness[0], hardiness[1] };
            var hardinessSubZone = values[1] == 'b' ? 0 : 5;
            return float.Parse($"{values[0]}.{hardinessSubZone}", CultureInfo.InvariantCulture);
        }
    }
}
