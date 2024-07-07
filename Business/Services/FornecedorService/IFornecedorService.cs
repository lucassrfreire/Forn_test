using Plamove.Business.ViewModels;

namespace Plamove.Business.Services.FornecedorService
{
    public interface IFornecedorService
    {
        Task<List<FornecedorVM>> Listar();
        Task<FornecedorVM> Obter(Guid Id);
        Task<Guid?> Inserir(FornecedorVM fornecedorVM);
        Task<FornecedorVM> Alterar(FornecedorVM fornecedorVM);
        Task Remover(Guid Id);
    }
}
