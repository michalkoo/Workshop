using LogSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogSearch.ParserHelper
{
    public interface IParser
    {
        IList<LogEntry> GetResult(SearchParameters parameters);
    }
}
