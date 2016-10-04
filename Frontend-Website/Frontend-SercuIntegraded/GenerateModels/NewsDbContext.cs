using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Frontend_SercuIntegraded.GenerateModels;
using System.Configuration;

namespace Frontend_SercuIntegraded.GenerateModels
{
    public sealed class NewsDbContext : FrontendDbContext
    {
        public NewsDbContext(string connectionString)
            : base(connectionString)
        {
        }
    }
}
