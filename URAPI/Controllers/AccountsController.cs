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

        private readonly AccountBusinessLogic ABL;

        public AccountsController(AccountBusinessLogic accountBusinessLogic)
        {
            ABL = accountBusinessLogic;
        }

        [HttpGet("Confirm Login")]
        public bool ConfirmLogin(string Username,string Password)
        {
            return ABL.ConfirmLogin(Username, Password);
        }
        [HttpPost("Add Account")]
        public bool AddAccount(Account account)
        {
            ABL.AddAccount(account.Username, account.Password, account.Email, account.FirstName, account.LastName, account.Gender,account.Birthday);
            return true;
        }
        [HttpGet("Check If Account Exists")]
        public bool DoesAccountExists(string Username)
        {
            return ABL.DoesAccountExists(Username);
        }
        [HttpPost("Add Custom Ulam To Favorites")]
        public void AddCustomUlamToFavorites(int accountID, int UlamID, string UlamName)
        {
            ABL.AddCustomUlamToFavorite(accountID,UlamID,UlamName);
        }
        [HttpGet("Add API Ulam To Favorites")]
        public void AddApiUlamToFavorites(int accountID, int UlamID,string UlamName)
        {
            ABL.AddAPIUlamToFavorite(accountID, UlamID,UlamName);
        }

        [HttpGet("Get Ulam ID")]
        public int GetUlamID(Ulam UlamToFind)
        {
            return ABL.GetUlamID(UlamToFind);
        }

        [HttpDelete("Remove from Favorite")]
        public void RemoveFavorite(int accountID, int UlamID)
        {
            ABL.RemoveFavorite(accountID, UlamID);
        }

        [HttpGet("Check if Ulam Exists in Favorites")]
        public bool DoesFavoriteExist(int accountID, int UlamID)
        {
            return ABL.DoesFavoriteExist(accountID, UlamID);
        }

        [HttpGet("Get Account")]
        public Account GetAccountInfo(string username)
        {
            return ABL.IdentifyAccountUser(username);
        }
    }
}
