using HolisticusAPI2.Desconto.Domain.Interfaces.Repositories;
using HolisticusAPI2.Desconto.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace HolisticusAPI2.Desconto.Domain.Services
{
    public class DescontoService : IDescontoService
    {
        private readonly IDescontoRepository _repository;

        public IConfigManagerRepository _configRepository { get; }
        public IEventLogger _log { get; }

        public DescontoService(
            IDescontoRepository repository,
            IConfigManagerRepository configRepository, 
            IEventLogger log)
        {
            _repository = repository;
            _configRepository = configRepository;
            _log = log;
        }

        public bool VerificarDesconto(int codigoPessoa)
        {
            return _repository.VerificarDesconto(codigoPessoa); ;
        }

    }
}
