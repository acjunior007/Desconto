using System;
using System.Collections.Generic;
using System.Text;

namespace HolisticusAPI2.Desconto.Domain.Interfaces.Services
{
    public interface IDescontoService
    {
        bool VerificarDesconto (int codigoPessoa);
    }
}
