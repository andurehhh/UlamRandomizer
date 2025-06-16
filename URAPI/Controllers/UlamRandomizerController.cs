using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UlamCommon;
using UlamRandomizerBusinessLogic;
using UlamRandomizerDataLogic;

namespace URAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UlamRandomizerController : ControllerBase
    {

        //BusinessLogic BL = new BusinessLogic();
        //GET
        [HttpGet]
        public IEnumerable<Ulam> GetAllUlam()
        {
            List<Ulam> ulams = BusinessLogic.GetUlams();
            return ulams;
        }
        //UPDATE
    }
}
