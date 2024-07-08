using AutoMapper;
using FornecedorAPI.Models;
using Plamove.Business.Services.AvisoService;
using Plamove.Business.ViewModels;
using Playmove.Data.Interfaces;

namespace Plamove.Business.Services.FornecedorService
{
    public class FornecedorService : IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IMapper _mapper;
        private readonly IAvisoService _avisoService;

        public FornecedorService(
            IAvisoService avisoService,
            IFornecedorRepository fornecedorRepository,
            IMapper mapper)
        {
            _avisoService = avisoService;
            _fornecedorRepository = fornecedorRepository;
            _mapper = mapper;
        }

        public async Task<List<FornecedorVM>> Listar()
        {
            var fornecedores = await _fornecedorRepository.FindAllAsNoTracking();
            return _mapper.Map<List<FornecedorVM>>(fornecedores);
        }

        public async Task<FornecedorVM> Obter(Guid Id)
        {
            var fornecedor = await _fornecedorRepository.FirstOrDefaultAsNoTracking(x => x.Id.Equals(Id));
            return _mapper.Map<FornecedorVM>(fornecedor);

        }

        public async Task<Guid?> Inserir(FornecedorVM fornecedorVM)
        {
            var fornecedor = await _fornecedorRepository.FindByKey(fornecedorVM.Id);

            if (fornecedor != null)
            {
                _avisoService.Adicionar("Fornecedor já cadastrado!");
                return null;
            }

            fornecedor = _mapper.Map<Fornecedor>(fornecedorVM);
            await _fornecedorRepository.Insert(fornecedor);

            return fornecedor.Id;
        }

        public async Task<FornecedorVM> Alterar(FornecedorVM fornecedorVM)
        {
            var fornecedor = await _fornecedorRepository.FindByKey(fornecedorVM.Id);

            if (fornecedor == null)
            {
                _avisoService.Adicionar("Fornecedor ainda não foi cadastrado!");
                return null;
            }

            fornecedor.ConvertToViewModel(fornecedorVM);

            await _fornecedorRepository.Update(fornecedor);

            return fornecedorVM;
        }

        public async Task Remover(Guid Id)
        {
            await _fornecedorRepository.Delete(Id);
        }

        private void Dispose()
        {
            _fornecedorRepository.Dispose();
        }
    }
}
