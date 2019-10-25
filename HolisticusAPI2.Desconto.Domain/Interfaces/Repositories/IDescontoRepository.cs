using System;
using System.Collections.Generic;
using System.Text;

namespace HolisticusAPI2.Desconto.Domain.Interfaces.Repositories
{
    public interface IDescontoRepository
    {
        bool VerificarDesconto(int codigoPessoa);
    }
}
