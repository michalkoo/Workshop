using LogSearch.ConfigHelper;
using LogSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace LogSearch.ParserHelper
{
    public class Parser : IParser
    {
        private readonly IConfiguration _configuration;
        private List<LogEntry> _parsedContent;

        public Parser(IConfiguration configuration)
        {
            _configuration = configuration;
            _parsedContent = new List<LogEntry>();
        }

        private string _remoteDirPath;
        private string _localDirPath = @"C:\temp\logs";

        public IList<LogEntry> GetResult(SearchParameters parameters)
        {
            int counter = 0;

            foreach (var item in _configuration.GetConfiguration().ServerPath)
            {
                _remoteDirPath = string.Concat(@"\\", item.Key, @"\", item.Value.Replace(":", "$"));

                if (Directory.Exists(_remoteDirPath))
                {
                    foreach (var filePath in Directory.EnumerateFiles(_remoteDirPath))
                    {
                        DirectoryInfo di = Directory.CreateDirectory(_localDirPath + @"\" + item.Key);
                        FileInfo fi = new FileInfo(filePath);
                        var logFile = di.FullName + @"\" + fi.Name;
                        fi.CopyTo(logFile);

                        TextReader logReader = new StreamReader(new FileStream(logFile, FileMode.Open));
                        string line;
                        //bool found = false;
                        IList<string> resultLines = new List<string>();
                        while ((line = logReader.ReadLine()) != null && counter < 10)
                        {
                            if (line.Contains(parameters.SearchPhrase))
                            {
                                LogEntry le = new LogEntry() { Message = line };
                                _parsedContent.Add(le);
                                ++counter;
                            }
                        }
                    }
                }
            }

            return _parsedContent;
        }
    }
}
