using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using HolisticusAPI2.Desconto.Application.Messages.Requests;

namespace HolisticusAPI2.Desconto.Application.Validator
{
    public class DescontoFluentValidator : AbstractValidator<IncluirDescontoRequest>
    {
        public DescontoFluentValidator()
        {
            //RuleFor(v => v..CategoriaArquivo)
            //    .NotEmpty().WithMessage("A categoria do arquivo é obrigatória!");

            //RuleFor(v => v.Arquivo).SetValidator(new ArquivoFluentValidator());
        }
    }
}
