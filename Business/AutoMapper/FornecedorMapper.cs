using AutoMapper;
using FornecedorAPI.Models;
using Plamove.Business.ViewModels;

namespace Plamove.Business.AutoMapper
{
    public class FornecedorMapper : Profile
    {
        public FornecedorMapper() { CreateMap<Fornecedor, FornecedorVM>().ReverseMap(); }
    }
}
