using LogSearch.ParserHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogSearch.Services
{
    public class LogSearchService
    {
        private SearchParameters _searchParameters;

        public LogSearchService(SearchParameters parameters)
        {
            _searchParameters = parameters;
        }
    }
}
