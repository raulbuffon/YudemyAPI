using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YudemyAPI.Context;

namespace YudemyAPI.Repositories
{
    public class SectionRepository
    {
        private readonly YudemyContext _context;

        public SectionRepository(YudemyContext yudemyContext)
        {
            this._context = yudemyContext;
        }
    }
}
