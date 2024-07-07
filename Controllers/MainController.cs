using FornecedorAPI.Business.Helpers;
using Microsoft.AspNetCore.Mvc;
using Plamove.Business.Services.AvisoService;

namespace FornecedorAPI.Controllers
{
    public class MainController : ControllerBase
    {
        private readonly IAvisoService _avisoService;

        public MainController(IAvisoService avisoService)
        {
            _avisoService = avisoService;
        }

        protected ActionResult RetornoAPI(object result = null)
        {
            try
            {
                if (_avisoService.PossuiAvisos())
                {
                    return BadRequest(new
                    {
                        sucesso = false,
                        erros = _avisoService.ObtersAvisos()
                    });
                }

                return Ok(new
                {
                    sucesso = true,
                    dados = result,
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    sucesso = false,
                    erros = new List<string> { ex.ToString() }
                });
            }
        }

        protected ActionResult RetornoErroAPI(Exception ex, object result = null)
        {
            return BadRequest(new
            {
                sucesso = false,
                dados = result,
                erros = new List<string> { _avisoService.ObtersAvisos() + ex.ToString() }
            });
        }
    }
}
