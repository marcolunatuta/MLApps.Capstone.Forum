using AutoMapper;
using MLApps.Capstone.Forum.Application.Dto;
using MLApps.Capstone.Forum.Transversal.Common;

namespace MLApps.Capstone.Forum.Transversal.Mapping
{
    public class BaseProfile : Profile
    {
        public BaseProfile()
        {
            CreateMap<ResponseApplication, Response>()
                .ReverseMap();

            CreateMap(typeof(ResponseApplication<>), typeof(Response<>))
                .ReverseMap();
        }
    }
}