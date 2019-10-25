using HolisticusAPI2.Desconto.Domain.Interfaces.Repositories;
using HolisticusAPI2.Desconto.Infra.SQLServer.Contexts;
using System;

namespace HolisticusAPI2.Paciente.Infra.File
{
    public class FileManagerRepository : IFileManagerRepository
    {
        private readonly string _url;
        private readonly IEventLogger _log;
        private readonly SGIPDbContext _dbContext;

        public FileManagerRepository(
            IEventLogger log, 
            SGIPDbContext dbContext,
            Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            _url = configuration["AzimuteLibFile-Address"];

            _log = log;
            _dbContext = dbContext;
        }
    }
}
