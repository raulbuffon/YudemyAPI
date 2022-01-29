using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YudemyAPI.Repositories;

namespace YudemyAPI.Services
{
    public class SectionService
    {
        private readonly ILogger<SectionService> _logger;
        private readonly SectionRepository sectionRepository;

        public SectionService(ILogger<SectionService> logger, SectionRepository sectionRepository)
        {
            _logger = logger;
            this.sectionRepository = sectionRepository;
        }
    }
}
