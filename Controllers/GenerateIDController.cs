using System.Net.Mime;
using genID.GenerateID;
using Microsoft.AspNetCore.Mvc;

namespace genID.Controllers
{
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    public class GenerateIDController : ControllerBase
    {
        [HttpGet("generate/id")]
        public ActionResult GenerateID()
        {
            var token = Guid.NewGuid().ToString();

            var response = new GenerateIDResponse
            {
                TokenId = token             
            };

            return Ok(response);
        }
                
    }
}