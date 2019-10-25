using HolisticusAPI2.Desconto.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;
using System;

namespace HolisticusAPI2.Paciente.Infra.Config
{
    public class ConfigManagerRepository : IConfigManagerRepository
    {
        private readonly IConfiguration _config;

        public ConfigManagerRepository(IConfiguration configuration)
        {
            _config = configuration;
        }

        public string GetValue(string key)
        {
            return _config[key];
        }
    }
}
