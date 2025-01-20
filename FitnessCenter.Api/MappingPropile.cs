using AutoMapper;
using FitnessCenter.Core.DTO;
using FitnessCenter.Core.Models;
//using FitnessCenter.Service.DTO;

namespace FitnessCenter.Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Secretary, SecretaryPostDTO>().ReverseMap();
        }
    }
}
