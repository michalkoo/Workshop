using LogSearch.ConfigHelper;
using LogSearch.Models;
using LogSearch.ParserHelper;
using LogSearch.Services;
using LogSearch.ViewModels.LogSearch;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogSearch.Controllers
{

    public class LogSearchController : Controller
    {
        private IParser _parser;
        private Configuration _configuration;
        private readonly ILogger _logger;

        public LogSearchController(IParser parser, IConfiguration configuration, ILoggerFactory loggerFactory)
        {
            _parser = parser;
            _configuration = configuration.GetConfiguration();
            _logger = loggerFactory.CreateLogger<ManageController>();
        }

        public IActionResult Index()
        {
            var viewModel = new LogSearchViewModel(_configuration, _parser.GetResult(new SearchParameters()));
            
            return View(viewModel);
        }
    }
}
