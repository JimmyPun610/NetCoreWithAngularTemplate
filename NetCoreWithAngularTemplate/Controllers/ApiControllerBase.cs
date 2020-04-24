using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWithAngularTemplate.Controllers
{
    [ApiController]
    public class ApiControllerBase : ControllerBase
    {
        public IConfiguration Configuration; 
        public ApiControllerBase(IConfiguration configuration)
        {
            Configuration = configuration;
        }
    }
}
