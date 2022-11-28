using Canopee.Common.Utilities;

using System.ComponentModel.DataAnnotations;

using static Canopee.Common.DataTransferObjects.TreeEnums;

namespace Canopee.Common.DataTransferObjects
{
    public class UpdateTreeDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? NameFr { get; set; }
        [Required]
        public string? NameEn { get; set; }
        [Required]
        public string? NameLa { get; set; }
        [Required]
        [HardinessZoneValidationAttribute]
        public HardinessZone HardinessZone { get; set; }
        public Exposition Exposition { get; set; } = Exposition.All;
        public GrowthSpeed Growth { get; set; } = GrowthSpeed.Average;
        public DiseaseRisk Disease { get; set; } = DiseaseRisk.Average;
        public InsectsRisk Insects { get; set; } = InsectsRisk.Average;
        public RootDepth Roots { get; set; } = RootDepth.Superficial;
        public float MaxHeight { get; set; }
        public float MaxWidth { get; set; }
    }
}
