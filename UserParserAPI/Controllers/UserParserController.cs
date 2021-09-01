using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UserParserAPI.Interfaces;
using UserParserAPI.Models;
using UserParserAPI.Services;

namespace UserParserAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserParserController : ControllerBase
    {
        private readonly UserService uService = new UserService();

        [Route("ParserUsers")]
        [HttpGet]
        public ActionResult<List<User>> getNew(string jsonFile)
        {
            return uService.returnUsers(jsonFile);
        }
    }
}
