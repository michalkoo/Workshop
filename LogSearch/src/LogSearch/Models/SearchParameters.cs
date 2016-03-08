using System;
using System.Collections.Generic;

namespace LogSearch.ParserHelper
{
    public class SearchParameters
    {
        public string SearchPhrase { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        public List<string> Servers { get; set; }
    }
}