using System.Linq;
using ABMTestWebService.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ABMTestWebService.Controllers
{
    [Route("api")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// Receive XML file and validate the data based on previous especification
        /// TODO: Create result code for when file is not compatible
        /// </summary>
        /// <param name="document"></param>
        /// <returns>Result code</returns>
        [Route("ParsePayload")]
        [HttpPost]
        public int ParsePayload([FromBody]Document document)
        {
            if(document != null)
            {
                // Invalid command specified
                if(document.DeclarationList.FirstOrDefault()?.Declaration?.Command != "DEFAULT")
                {
                    return -1;
                }
                // Invalid Site specified
                else if(document.DeclarationList.FirstOrDefault()?.Declaration?.DeclarationHeader?.SiteID != "DUB")
                {
                    return -2;
                }
            }

            return 0;
        }
    }
}
