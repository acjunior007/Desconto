using HolisticusAPI2.Desconto.Infra.SQLServer.Maps;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace HolisticusAPI2.Desconto.Infra.SQLServer.Contexts
{
    public class SGIPDbContext : DbContext
    {
        private readonly ILoggerFactory _loggerFactory;

        public SGIPDbContext(DbContextOptions<SGIPDbContext> options, ILoggerFactory loggerFactory)
            : base(options)
        {
            _loggerFactory = loggerFactory;
        }

        public virtual DbSet<DescontoDbMap> Desconto { get; set; }
    }
}
