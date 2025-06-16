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
        public bool ConfirmLogin(string Username,string Password)
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
        public Account IdentifyAccountUser()
        {
            //return AccountLogic.CurrentUser;

            return AccountLogic.IdentifyUser(currentID);
            

        }
    }
}
