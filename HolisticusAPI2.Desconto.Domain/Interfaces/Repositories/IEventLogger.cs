using System;
using System.Collections.Generic;
using System.Text;

namespace HolisticusAPI2.Desconto.Domain.Interfaces.Repositories
{
    public interface IEventLogger
    {
        Guid Debug(Exception exception);

        Guid Debug(string message);

        Guid Error(Exception exception);

        Guid Error(string message);

        Guid Fatal(Exception exception);

        Guid Fatal(string message);

        Guid Information(Exception exception);

        Guid Information(string message);

        Guid Warning(Exception exception);

        Guid Warning(string message);
    }
}
