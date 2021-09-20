using DtAPI.Models;
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

        [HttpGet("getAllIlan")]
        public IActionResult GetAllIlan()
        {
            var allIlan = _apiService.GetAllIlan();
            return Ok(allIlan);
        }

        [HttpGet("getIlan/{id}")]
        public IActionResult GetlanById(int id)
        {
            var ilan = _apiService.GetIlanById(id);
            return Ok(ilan);
        }

        [HttpPost("addIlan")]
        public IActionResult AddIlan([FromBody]DtApi dtApi)
        {
            _apiService.AddIlan(dtApi);
            return Ok();
        }

        [HttpPut("updateIlan/{id}")]
        public IActionResult UpdateIlan(int id, [FromBody]DtApi dtApi)
        {
            var updatedIlan =_apiService.UpdateIlanById(id,dtApi);
            return Ok(updatedIlan);
        }

        [HttpDelete("deleteIlan/{id}")]
        public IActionResult DeleteIlan(int id)
        {
            _apiService.DeleteIlanById(id);
            return Ok();
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] Users users)
        {
            var _login = _apiService.Login(users);
            return Ok(_login);
        }

    }
}
