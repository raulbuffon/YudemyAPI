using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YudemyAPI.Models;
using YudemyAPI.Models.DTO;
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

        public IEnumerable<Section> GetAll()
        {
            return sectionRepository.GetAll();
        }

        public Section GetById(int id)
        {
            return sectionRepository.GetById(id);
        }

        public Section Create(SectionRequest section)
        {
            Section newSection = new Section(section.Title, section.CourseId);

            return sectionRepository.Create(newSection);
        }
    }
}
