using System.ComponentModel;

namespace Canopee.Common.DataTransferObjects
{
    public class TreeEnums
    {
        public enum Exposition
        {
            Shade = 1,
            SemiShade = 2,
            Sun = 4,
            All = Shade | SemiShade | Sun
        }
        public enum GrowthSpeed
        {
            VerySLow = 1,
            Slow = 2,
            Average = 4,
            Fast = 8,
            VeryFast = 16
        }
        public enum DiseaseRisk
        {
            Low = 1,
            Average = 2,
            High = 4,
        }
        public enum InsectsRisk
        {
            Low = 1,
            Average = 2,
            High = 4,
        }
        public enum RootDepth
        {
            Superficial = 1,
            Deep = 2
        }

        public enum HardinessZone
        {
            [Description("1a")]
            OneA = 1,
            [Description("1b")]
            OneB = 2,
            [Description("2a")]
            TwoA = 3,
            [Description("2b")]
            TwoB = 3,
            [Description("3a")]
            ThreeA = 4,
            [Description("3b")]
            ThreeB = 4,
            [Description("4a")]
            FourA = 5,
            [Description("4b")]
            FourB = 6,
            [Description("5a")]
            FiveA = 7,
            [Description("5b")]
            FiveB = 8,
            [Description("6a")]
            SixA = 9,
            [Description("6b")]
            SixB = 10,
            [Description("7a")]
            SevenA = 11,
            [Description("7b")]
            SevenB = 12,
            [Description("8a")]
            EightA = 13,
            [Description("8b")]
            EightB = 14,
            [Description("9a")]
            NineA = 15,
            [Description("9b")]
            NineB = 16,
            [Description("10a")]
            TenA = 17,
            [Description("10b")]
            TenB = 18,
            [Description("11")]
            Eleven = 19,
        }
    }
}
