using static Canopee.Common.DataTransferObjects.TreeEnums;

namespace Canopee.Common.DataTransferObjects
{
    public class TreeDto
    {
        public int Id { get; set; }
        public string? NameFr { get; set; }
        public string? NameEn { get; set; }
        public string? NameLa { get; set; }
        public HardinessZone HardinessZone { get; set; }
        public Exposition Exposition { get; set; }
        public GrowthSpeed Growth { get; set; }
        public DiseaseRisk Disease { get; set; }
        public InsectsRisk Insects { get; set; }
        public RootDepth Roots { get; set; }
        public float MaxHeight { get; set; }
        public float MaxWidth { get; set; }
    }
}
