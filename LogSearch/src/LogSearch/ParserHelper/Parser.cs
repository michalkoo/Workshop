﻿using LogSearch.ConfigHelper;
using LogSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogSearch.ParserHelper
{
    public class Parser : IParser
    {
        public Parser(IConfiguration configuration, SearchParameters parameters)
        {
        }

        private List<LogEntry> _parsedContent;

        public IList<LogEntry> GetResult()
        {
            throw new NotImplementedException();
        }
    }
}