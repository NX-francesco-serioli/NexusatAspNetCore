﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nexusat.AspNetCore.Models;
using Nexusat.AspNetCore.Mvc;

namespace Nexusat.AspNetCore.IntegrationTestsFakeService.Controllers
{
    [Produces("application/json")]
    [Route("ApiResponse")]
    public class ApiResponseController : ApiController
    {
        [HttpGet("200")]
        public IApiResponse Get200() => OkResponse();
    }
}