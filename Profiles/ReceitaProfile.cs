using AutoMapper;
using NutriPlanApi.Data.Dtos.Receita;
using NutriPlanApi.Models;

namespace NutriPlanApi.Profiles
{
    public class ReceitaProfile : Profile
    {
        public ReceitaProfile()
        {
            CreateMap<CreateReceitaDto, Receita>();
        }

    }
}
