using LogSearch.Models;
using LogSearch.ParserHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogSearch.Services
{
    public interface ILogSearchService
    {
        IList<LogEntry> GetResult(SearchParameters parameters);
    }
}
