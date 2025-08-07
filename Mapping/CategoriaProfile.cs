using API_Financas.Dto.Categoria;
using API_Financas.Models;
using AutoMapper;

namespace API_Financas.Mapping
{
    public class CategoriaProfile : Profile
    {
        public CategoriaProfile()
        {
            CreateMap<CategoriaDto, CategoriaModel>();

            CreateMap<CategoriaModel, CategoriaDto>(); 
        }
    }
}