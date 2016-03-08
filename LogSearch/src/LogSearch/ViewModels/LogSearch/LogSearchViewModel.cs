using LogSearch.ConfigHelper;
using LogSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogSearch.ViewModels.LogSearch
{
    public class LogSearchViewModel
    {
        public LogSearchViewModel(Configuration configuration, IList<LogEntry> logEntries)
        {
            Configuration = configuration;
            LogEntries = logEntries;
        }

        public Configuration Configuration { get; private set; }

        public IList<LogEntry> LogEntries { get; private set; }
    }
}
