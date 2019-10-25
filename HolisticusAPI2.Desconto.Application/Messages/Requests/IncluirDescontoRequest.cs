using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using HolisticusAPI2.Desconto.Domain.Interfaces.Repositories;

namespace HolisticusAPI2.Desconto.Application.Messages.Requests
{
    [DataContract]
    public class IncluirDescontoRequest
    {
        private readonly IEventLogger _log;

        public IncluirDescontoRequest(IEventLogger log)
        {
            _log = log;
        }
    }
}
