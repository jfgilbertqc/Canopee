namespace Canopee.Common.DataTransferObjects
{
    public class TreeEnums
    {
        public enum PlantExposition
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
    }
}
