using HolisticusAPI2.Desconto.Domain.Interfaces.Repositories;
using System;
using AzimuteLib.Log;

namespace HolisticusAPI2.Desconto.Infra.Log
{
    public class EventLogger : IEventLogger
    {
        private readonly IAzimuteLogger _logger;

        public EventLogger(IAzimuteLogger logger)
        {
            _logger = logger;
        }

        public Guid Debug(Exception exception)
        {
            return _logger.Debug(exception);
        }

        public Guid Debug(string message)
        {
            return _logger.Debug(message);
        }

        public Guid Error(Exception exception)
        {
            return _logger.Error(exception);
        }

        public Guid Error(string message)
        {
            return _logger.Error(message);
        }

        public Guid Fatal(Exception exception)
        {
            return _logger.Fatal(exception);
        }

        public Guid Fatal(string message)
        {
            return _logger.Fatal(message);
        }

        public Guid Information(Exception exception)
        {
            return _logger.Information(exception);
        }

        public Guid Information(string message)
        {
            return _logger.Information(message);
        }

        public Guid Warning(Exception exception)
        {
            return _logger.Warning(exception);
        }

        public Guid Warning(string message)
        {
            return _logger.Warning(message);
        }
    }
}
