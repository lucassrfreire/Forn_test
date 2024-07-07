using Plamove.Business.ViewModels;

namespace FornecedorAPI.Models
{
    public class Fornecedor : BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public void ConvertToViewModel(FornecedorVM fornecedorVM)
        {
            Nome = fornecedorVM.Nome;
            Email = fornecedorVM.Email;
            Ativo = fornecedorVM.Ativo;
        }
    }
}
