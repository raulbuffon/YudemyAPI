using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YudemyAPI.Services;

namespace YudemyAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SectionController : ControllerBase
    {
        private readonly ILogger<SectionController> _logger;
        private readonly SectionService sectionService;

        public SectionController(ILogger<SectionController> logger, SectionService sectionService)
        {
            _logger = logger;
            this.sectionService = sectionService;
        }
    }
}
