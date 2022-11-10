namespace Canopee.Domain.Entities
{
    public class Tree
    {
        public int Id { get; set; }
        public string? NameFr { get; set; }
        public string? NameEn { get; set; }
        public string? NameLa { get; set; }
        public float HardinessZone { get; set; }
        public PlantExposition Exposition { get; set; }
        public GrowthSpeed Growth { get; set; }
        public DiseaseRisk Disease { get; set; }
        public InsectsRisk Insects { get; set; }
        public RootDepth Roots { get; set; }
        public float MaxHeight { get; set; }
        public float MaxWidth { get; set; }
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
