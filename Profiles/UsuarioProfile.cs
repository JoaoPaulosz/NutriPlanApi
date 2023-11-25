using AutoMapper;
using NutriPlanApi.Data.Dtos;
using NutriPlanApi.Models;

namespace NutriPlanApi.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
        }
    }
}
