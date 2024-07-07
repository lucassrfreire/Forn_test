using FornecedorAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Plamove.Business.Services.AvisoService;

namespace FornecedorAPI.Business.Helpers
{
    public class ValidacaoCustomizada
    {
        private static readonly IAvisoService _avisoService;
        private static readonly MainController _mainController;

        public static IActionResult RespostaCustomizada(ActionContext context)
        {
            var mensagens = context.ModelState
                .Where(x => x.Value.Errors.Count > 0)
                .Select(
                    kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray()
                );

            return new BadRequestObjectResult(new
            {
                sucesso = false,
                erros = mensagens
            });
        }
    }
}
