using DtAPI.Services;
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

        public DtApiService _apiService;

        public DtApiController(DtApiService apiService)
        {
            _apiService = apiService;
        }

        /*
        [HttpGet]
        public DtApi Get()
        {
            return new DtApi
            {
                
            };
        }
        */

        [HttpPost("add-ilan")]
        public IActionResult AddIlan([FromBody]DtApi dtApi)
        {
            _apiService.AddIlan(dtApi);
            return Ok();
        }

    }
}
