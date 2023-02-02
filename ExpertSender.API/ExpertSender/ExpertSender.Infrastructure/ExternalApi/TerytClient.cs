using ExpertSender.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExpertSender.Infrastructure.ExternalApi
{
    public class TerytClient : ITerytClient
    {
        public Task<string> GetAdress(string searchFilter, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
