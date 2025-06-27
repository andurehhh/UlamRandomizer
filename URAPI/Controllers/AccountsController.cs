using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UlamCommon;
using UlamRandomizerBusinessLogic;

namespace URAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        AccountBusinessLogic ABL = new AccountBusinessLogic();
        [HttpGet("Confirm Login")]
        public bool ConfirmLogin(string Username,string Password)
        {
            return ABL.ConfirmLogin(Username, Password);
        }
        [HttpPost("Add Account")]
        public bool AddAccount(Account account)
        {
            return AddAccount(account);
        }
    }
}
