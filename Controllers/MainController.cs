using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web.Helpers;

namespace API_Core.Controllers
{
   // [Route("api/datas")]
    public class MainController : Controller
    {       
        [HttpGet("api/cities")]
        public IList<empDto> GetCities()
        {

            return new EmployeeSeedingData().employees;
            
        }
    }
}
