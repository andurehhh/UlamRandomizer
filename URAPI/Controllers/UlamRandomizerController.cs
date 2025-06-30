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
        [HttpGet("Search Ulam")]
        public Ulam SearchUlamList(string NameofUlam)
        {
            Ulam ulamFound= BusinessLogic.SearchUlamList(NameofUlam);
            return ulamFound;
        }
        [HttpGet("Is In List")]
        public bool IsInList(Ulam UlamToFind)
        {
            return BusinessLogic.IsInList(UlamToFind);
        }
        
        
        [HttpPatch("Edit Ulam")]
        public void EditUlam(Ulam newUlam)
        {
            BusinessLogic.EditUlam(newUlam);
        }

        [HttpPost("Create an Ulam")]
        public Ulam CreateUlamObj(string name,string MainIngredient1, string MainIngredient2, string Description)
        {
            return BusinessLogic.CreateUlamObj(name,MainIngredient1,MainIngredient2,Description);
        }
        [HttpDelete("Remove an Ulam")]
        public void RemoveUlam (string UlamNameToRemove)
        {
            Ulam toRemove = BusinessLogic.SearchUlamList(UlamNameToRemove);
            BusinessLogic.RemoveUlam(toRemove);
        }
        [HttpGet("Randomize Ulam")]
        public Ulam RandomizeUlam()
        {
            return BusinessLogic.GetRandomUlam(BusinessLogic.GetUlams());
        }

        [HttpGet("Get Ulam By ID")]
        public Ulam GetUlamByID(int id)
        {

            return BusinessLogic.GetUlambyID(id);
        }
        //UPDATE
    }
}
