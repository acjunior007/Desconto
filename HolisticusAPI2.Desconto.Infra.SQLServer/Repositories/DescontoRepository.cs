using HolisticusAPI2.Desconto.Domain.Interfaces.Repositories;
using HolisticusAPI2.Desconto.Infra.SQLServer.Contexts;
using HolisticusAPI2.Desconto.Infra.SQLServer.Interfaces;
using HolisticusAPI2.Desconto.Infra.SQLServer.Maps;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HolisticusAPI2.Desconto.Infra.SQLServer.Repositories
{
    public class DescontoRepository : IDescontoRepository
    {
        private readonly IRepositoryBase<DescontoDbMap> _repository;
        private readonly SGIPDbContext _dbContext;

        public DescontoRepository(
            IRepositoryBase<DescontoDbMap> repository,
            SGIPDbContext dbContext
            )
        {
            _repository = repository;
            _dbContext = dbContext;
        }

        public bool VerificarDesconto(int codigoPessoa)
        {
            Boolean isVerificaRetorno;
            isVerificaRetorno = _dbContext.Desconto.Where(i => i.CodigoPessoa == codigoPessoa
                || i.Prccod == codigoPessoa).Any();

            return isVerificaRetorno;
        }
    }
}
