using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyfinanceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HCController : ControllerBase
    {
        [HttpGet]
        public String Get()
        {
            return "Status: OK";
        }
    }
}
