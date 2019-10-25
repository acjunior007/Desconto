using System;
using System.Collections.Generic;
using System.Text;

using HolisticusAPI2.Desconto.Domain.Interfaces.Repositories;
using HolisticusAPI2.Desconto.Application.Interfaces;
using AzimuteLib.HTTPBase;
using HolisticusAPI2.Desconto.Domain.Interfaces.Services;
using HolisticusAPI2.Desconto.Application.Messages.Responses;

namespace HolisticusAPI2.Desconto.Application.Services
{
    public class DescontoAppService : IDescontoAppService
    {
        private readonly IDescontoService _servico;
        private readonly IEventLogger _log;
        private readonly IDescontoValidator _descontoValidator;

        public DescontoAppService(IDescontoService servico,
            IDescontoValidator descontoValidator,
            IEventLogger log)
        {
            _servico = servico;
            _log = log;
            _descontoValidator = descontoValidator;
        }

        public BaseResponse VerificarDesconto(int codigoPessoa)
        {
            Boolean isVerificarDesconto;
            isVerificarDesconto = _servico.VerificarDesconto(codigoPessoa);
            var response = new DescontoResponse()
            {
                IsContemDesconto = isVerificarDesconto
            };

            return response;

        }
    }
}
