using System;
using System.Collections.Generic;
using System.Text;
using HolisticusAPI2.Desconto.Application.Interfaces;
using HolisticusAPI2.Desconto.Application.Messages.Requests;
using AzimuteLib.HTTPBase;

namespace HolisticusAPI2.Desconto.Application.Validator
{
    public class DescontoValidator : IDescontoValidator
    {
        public ErrorResponse Validar(IncluirDescontoRequest request)
        {
            var response = new ErrorResponse();

            //var validator = new DescontoFluentValidator();
            //var result = validator.Validate(request);

            //if (result.IsValid)
            //{
            //    return null;
            //}

            //foreach (var error in result.Errors)
            //{
            //    var mensagem = new MessageData(error.ErrorMessage, Guid.NewGuid().ToString());
            //    response.AdicionarMensagem(mensagem);
            //}

            //response.SetarStatus(false);

            return response;
        }
    }
}
