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
        }

        private string _remoteDirPath = @"C:\temp\logs";
        private string _localDirPath = @"C:\temp\local\logs";
        private string _errorCode = "7812B31Cztmr";

        public IList<LogEntry> GetResult(SearchParameters parameters)
        {
            if (Directory.Exists(_remoteDirPath))
            {
                foreach (var filePath in Directory.EnumerateFiles(_remoteDirPath))
                {
                    FileInfo fi = new FileInfo(filePath);
                    var logFile = _localDirPath + @"\" + fi.Name;
                    fi.CopyTo(logFile);

                    TextReader logReader = new StreamReader(new FileStream(logFile, FileMode.Open));
                    string line;
                    bool found = false;
                    IList<string> resultLines = new List<string>();
                    while ((line = logReader.ReadLine()) != null && !found)
                    {
                        found = line.Contains(_errorCode);
                        /*if (found)
                        {
                            isLineCopyMode = true;
                            resultLines.Add(line);
                        }*/
                    }
                }
            }

            var a = new List<LogEntry>();
            a.Add(new LogEntry() { Message = "message" });
            return a;
        }
    }
}
