using AzimuteLib.HTTPBase;
using System;

namespace HolisticusAPI2.Desconto.Application
{
    public interface IDescontoAppService
    {
        BaseResponse VerificarDesconto(int codigoPessoa);
    }
}
