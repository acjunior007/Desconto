using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using AzimuteLib.Config;

namespace HolisticusAPI2.Desconto.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration(AddConfiguration)
            .UseStartup<Startup>();

        private static void AddConfiguration(WebHostBuilderContext context, IConfigurationBuilder builder)
        {
            string env = GetEnvironmentVariableFromAllTargets("ASPNETCORE_ENVIRONMENT");

            if (env.ToLower() == "production")
            {
                string configAddress = GetEnvironmentVariableFromAllTargets("Config_Address");

                if (string.IsNullOrWhiteSpace(configAddress))
                {
                    throw new ApplicationException("O endereço do servidor de configurações não foi informado");
                }

                builder.AddAzimuteLibConfigProvider(configAddress);
            }
        }

        private static string GetEnvironmentVariableFromAllTargets(string variable)
        {
            string env = Environment.GetEnvironmentVariable(variable, EnvironmentVariableTarget.Machine);

            if (env != null)
            {
                return env;
            }

            env = Environment.GetEnvironmentVariable(variable, EnvironmentVariableTarget.Process);

            if (env != null)
            {
                return env;
            }

            return Environment.GetEnvironmentVariable(variable, EnvironmentVariableTarget.User);
        }
    }
}
