using AutoMapper;

using Canopee.Common.DataTransferObjects;
using Canopee.Domain.Entities;

using static Canopee.Common.Utilities.HardinessUtil;

namespace Canopee.Web.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Tree, TreeDto>().ForMember(t => t.HardinessZone, opt => opt.MapFrom(x => x != null ? GetEnumDescription(x.HardinessZone) : ""));
            CreateMap<AddTreeDto, Tree>();
            CreateMap<UpdateTreeDto, Tree>();
        }
    }
}
