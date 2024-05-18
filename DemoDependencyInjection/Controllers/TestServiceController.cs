using DemoDependencyInjection.Models;
using DemoDependencyInjection.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoDependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestServiceController(FinalService finalService) : ControllerBase
    {
        [Route("Name")]
        [HttpGet]
        public ActionResult GetCompleteName(ActionMode mode, string name)
        {
            var result = finalService.ExecutionEngineException(mode, name);

            return Ok(result);
        }
    }
}
