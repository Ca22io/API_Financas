using API_Financas.Dto.Transacao;
using API_Financas.Models;
using AutoMapper;

namespace API_Financas.Mapping
{
    public class TransacaoProfile : Profile
    {
        public TransacaoProfile()
        {
            CreateMap<TransacaoPostDto, TransacaoModel>();

            CreateMap<TransacaoPutDto, TransacaoModel>();

            CreateMap<TransacaoModel, TransacaoGetDto>()
                .ForMember(dest => dest.NomeTipo, opt => opt.MapFrom(src => src.Tipo.Nome))
                .ForMember(dest => dest.NomeCategoria, opt => opt.MapFrom(src => src.Categoria.Nome));; 
        }
    }
}