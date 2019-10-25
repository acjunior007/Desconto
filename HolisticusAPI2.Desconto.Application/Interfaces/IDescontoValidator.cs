using AzimuteLib.HTTPBase;
using HolisticusAPI2.Desconto.Application.Messages.Requests;
using System;
using System.Collections.Generic;
using System.Text;


namespace HolisticusAPI2.Desconto.Application.Interfaces
{
    public interface IDescontoValidator
    {
        ErrorResponse Validar(IncluirDescontoRequest request);
    }
}
