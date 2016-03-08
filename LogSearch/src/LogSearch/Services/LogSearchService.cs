using LogSearch.ParserHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogSearch.Models;

namespace LogSearch.Services
{
    public class LogSearchService : ILogSearchService
    {
        private SearchParameters _searchParameters;

        public LogSearchService(SearchParameters parameters)
        {
            _searchParameters = parameters;
        }

        public IList<LogEntry> GetResult(SearchParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
