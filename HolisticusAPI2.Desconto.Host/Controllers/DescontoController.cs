using AzimuteLib.HTTPBase;
using AzimuteLib.Log;
using HolisticusAPI2.Desconto.Application;
using HolisticusAPI2.Desconto.Host.Routers;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HolisticusAPI2.Desconto.Host.Controllers
{
    /// <summary>
    /// Endpoints de interação com os descontos
    /// </summary>
    [Produces("application/json")]
    public class DescontoController : Controller
    {
        private readonly IDescontoAppService _service;
        private readonly IAzimuteLogger _log;

        public DescontoController(IDescontoAppService service, IAzimuteLogger log)
        {
            _service = service;
            _log = log;
        }

        /// <summary>
        /// Verificar se existe desconto para o paciente informado
        /// </summary>
        /// <param name="id">id do paciente</param>
        /// <returns>Retorna um valor boleano(true/false) informando se tem o desconto</returns>
        [HttpGet]
        [Route(RouteConst.VerificarDesconto)]
        [ProducesResponseType(200)]
        [ProducesResponseType(400, Type = typeof(ErrorResponse))]
        public IActionResult VerificarDesconto(int codigoPessoa)
        {
            BaseResponse response;

            try
            {
                response = _service.VerificarDesconto(codigoPessoa);
            }
            catch (System.ApplicationException exception)
            {
                return this.GetErrorResponse(exception, _log);
            }
            catch (Exception exception)
            {
                string msg = exception.StackTrace.ToString();
                return this.GetErrorResponse ($"Não foi possível acessar o serviço de domínio para verificar o desconto", _log);
            }

            return this.GetResponse(response);
        }
    }
}