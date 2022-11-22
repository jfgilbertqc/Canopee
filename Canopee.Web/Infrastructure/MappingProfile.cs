using AutoMapper;

using Canopee.Common.DataTransferObjects;
using Canopee.Domain.Entities;

using static Canopee.Common.Utilities.HardinessConverter

namespace Canopee.Web.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Tree, TreeDto>().ForMember(t => t.HardinessZone, opt => opt.MapFrom(x => x != null ? GetHardinessFromNumber(x.HardinessZone) : "N/A"));
            CreateMap<AddTreeDto, Tree>().ForMember(x => x.Id, opt => opt.Ignore()).ForMember(x => x.HardinessZone, opt => opt.MapFrom(src => GetHardinessFromString(src.HardinessZone)));
        }


    }
}
