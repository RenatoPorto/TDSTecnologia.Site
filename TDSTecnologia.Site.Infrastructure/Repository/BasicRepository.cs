using System;
using System.Collections.Generic;
using System.Text;

namespace TDSTecnologia.Site.Infrastructure
{
    public class BasicRepository
    {
        protected readonly AppContexto _context;

        public BasicRepository(AppContexto context)
        {
            _context = context;
        }
    }
}
