﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SummerBio.Echo.Controllers
{
    [Route("api/[controller]")]
    public class EchoController : Controller
    {
        [HttpGet]
        public string Get(string echo)
        {
            return echo;
        }
    }
}
