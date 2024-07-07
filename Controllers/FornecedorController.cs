using Microsoft.AspNetCore.Mvc;
using Plamove.Business.Services.AvisoService;
using Plamove.Business.Services.FornecedorService;
using Plamove.Business.ViewModels;

namespace FornecedorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FornecedorController : MainController
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedorController(IAvisoService avisoService,
            IFornecedorService fornecedorService) : base(avisoService)
        {
            _fornecedorService = fornecedorService;
        }

        [HttpGet]
        public async Task<ActionResult<List<FornecedorVM>>> Listar()
        {
            try
            {
                return RetornoAPI(await _fornecedorService.Listar());
            }
            catch (Exception ex)
            {
                return RetornoErroAPI(ex);
            }
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<FornecedorVM>> ObterPorId(Guid Id)
        {
            try
            {
                return RetornoAPI(await _fornecedorService.Obter(Id));
            }
            catch (Exception ex)
            {
                return RetornoErroAPI(ex, Id);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Guid?>> Inserir(FornecedorVM fornecedor)
        {
            try
            {
                return RetornoAPI(await _fornecedorService.Inserir(fornecedor));
            }
            catch (Exception ex)
            {
                return RetornoErroAPI(ex, fornecedor);
            }
        }

        [HttpPut]
        public async Task<ActionResult<FornecedorVM>> Alterar(FornecedorVM fornecedor)
        {
            try
            {
                return RetornoAPI(await _fornecedorService.Alterar(fornecedor));
            }
            catch (Exception ex)
            {
                return RetornoErroAPI(ex, fornecedor);
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Remover(Guid Id)
        {
            try
            {
                await _fornecedorService.Remover(Id);
                return RetornoAPI();
            }
            catch (Exception ex)
            {
                return RetornoErroAPI(ex, Id);
            }
        }
    }
}
