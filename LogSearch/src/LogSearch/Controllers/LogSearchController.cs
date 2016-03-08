using LogSearch.Services;
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
        private ILogSearchService _logSearchService;
        private readonly ILogger _logger;

        public LogSearchController(ILogSearchService logSearchService, ILoggerFactory loggerFactory)
        {
            _logSearchService = logSearchService;
            _logger = loggerFactory.CreateLogger<ManageController>();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
