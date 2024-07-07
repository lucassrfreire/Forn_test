using FornecedorAPI.Models;

namespace Plamove.Business.ViewModels
{
    public class FornecedorVM
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }

    }
}
