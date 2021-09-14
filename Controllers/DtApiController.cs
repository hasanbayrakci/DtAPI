using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DtAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DtApiController : ControllerBase
    {

        [HttpGet]
        public DtApi Get()
        {
            return new DtApi
            {
                
            };
        }
    }
}
