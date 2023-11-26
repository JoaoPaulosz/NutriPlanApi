using AutoMapper;
using NutriPlanApi.Data.Dtos;
using NutriPlanApi.Models;

namespace NutriPlanApi.Profiles
{
    public class AlimentoProfile : Profile
    {
        public AlimentoProfile()
        {
            CreateMap<CreateAlimentoDto, Alimento>();
        }
    }
}
