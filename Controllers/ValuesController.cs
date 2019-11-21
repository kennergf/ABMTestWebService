using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using ABMTestWebService.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ABMTestWebService.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("SendDocument")]
        [HttpPost]
        public int ParsePayload([FromBody]Document document)
        {
            if(document != null)
            {
                if(document.Declaration != "DEFAULT")
                {
                    return -1;
                }
                else if(document.SiteID != "DUB")
                {
                    return -2;
                }
            }

            return 0;
        }
    }
}
