using LogSearch.ParserHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogSearch.Models;
using LogSearch.ConfigHelper;

namespace LogSearch.Services
{
    public class LogSearchService : ILogSearchService
    {
        private SearchParameters _searchParameters;
        private IConfiguration _configuration;

        public LogSearchService(SearchParameters parameters)
        {
            _searchParameters = parameters;
            _configuration = new AppSettings();
        }

        public IList<LogEntry> GetResult(SearchParameters parameters)
        {
            var parser = new Parser(_configuration, _searchParameters);
            return parser.GetResult();                        
        }
    }
}
