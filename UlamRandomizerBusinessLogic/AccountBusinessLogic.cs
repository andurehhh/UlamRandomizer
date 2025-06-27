using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlamCommon;
using UlamRandomizerDataLogic;

namespace UlamRandomizerBusinessLogic
{
    public class AccountBusinessLogic
    {

        //public AccountBusinessLogic()
        //{
        //    ConfirmLogin();
        //}
        int currentID;
        static DBAccountDataLogic AccountLogic = new DBAccountDataLogic();
        public bool ConfirmLogin(string Username, string Password)
        {
            string username = AccountLogic.FindLogin(Username)[0];

            if (username != null)
            {
                string password = AccountLogic.FindLogin(Username)[1];
                if (password.Equals(Password))
                {
                    currentID = Convert.ToInt16(AccountLogic.FindLogin(Username)[2]);
                    return true;
                }
                return false;
            }
            return false;
        }
        public Account IdentifyAccountUser(string username)
        {
            //return AccountLogic.CurrentUser;
            
            return AccountLogic.IdentifyUser(Convert.ToInt32(AccountLogic.FindLogin(username)[2]));


        }
        public void AddAccount(string username, string password, string email, string firstName, string lastName, string gender, DateOnly birthday)
        {
            Account newAcc = new Account(username, password, email, firstName, lastName, gender, birthday);
            AccountLogic.AddAccount(newAcc);
        }
        public bool DoesAccountExists(string email)
        {
            return AccountLogic.DoesEmailExist(email);
        }
        public void AddCustomUlamToFavorite(int accountID, int UlamID)
        {
            AccountLogic.AddCustomUlamToFavorite(accountID, UlamID);
        }
        public void AddAPIUlamToFavorite(int accountID, int UlamID)
        {
            AccountLogic.AddAPIToFavorite(accountID, UlamID);
        }
        public async Task<List<Ulam>> GetFavoriteAll(Account account)
        {
            List<Ulam>Favs = AccountLogic.GetFavoriteList(account.Id);
            Favs.AddRange(await ExtractAPIList(account.Id));
            return Favs;
        }
        public async Task<List<Ulam>> ExtractAPIList(int accountID)
        {
            List<Ulam> apiUlams = new List<Ulam>();
            List<int> apilist = AccountLogic.GetAPIList(accountID);
            foreach (var item in apilist)
            {
                apiUlams.Add(await SpoonacularBL.GetUlamInfo(SpoonacularBL.sharedClient,item));
            }
            return apiUlams;
        }
        public bool DoesFavoriteExist(int accountID, int ulamID)
        {
            return AccountLogic.DoesFavoriteExist(accountID, ulamID);
        }
        public void RemoveFavorite(int accountID, int ulamID)
        {
            AccountLogic.RemoveFavorite(accountID, ulamID);
        }
    }

}
