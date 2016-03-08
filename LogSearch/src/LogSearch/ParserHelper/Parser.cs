using LogSearch.ConfigHelper;
using LogSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogSearch.ParserHelper
{
    public class Parser : IParser
    {
        public Parser()
        {
        }

        private List<LogEntry> _parsedContent;

        public IList<LogEntry> GetResult(SearchParameters parameters)
        {
            var logEntry = new LogEntry
            {
                Message = "Parsed content."
            };

            _parsedContent = new List<LogEntry>();
            _parsedContent.Add(logEntry);
            return _parsedContent;
        }
    }
}
