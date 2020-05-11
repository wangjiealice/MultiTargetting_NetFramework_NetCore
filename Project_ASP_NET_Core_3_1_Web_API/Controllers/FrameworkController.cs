using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_Standard_NETCore_Framework;

namespace Project_ASP_NET_Core_3_1_Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FrameworkController : ControllerBase
    {
        private readonly ILogger<FrameworkController> _logger;

        public FrameworkController(ILogger<FrameworkController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return base.Ok(MTBKernel.Name());
        }
    }
}
