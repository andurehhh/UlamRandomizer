using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlamCommon;
namespace UlamRandomizerDataLogic
{
    public class DBAccountDataLogic
    {
        public static Account CurrentUser;
         
        string connectionstring = "Data Source =NITROV\\SQLEXPRESS; Initial Catalog = DBUlamRandomizer; Integrated Security = True; TrustServerCertificate = True;";
        SqlConnection sqlconnection;
        public DBAccountDataLogic()
        {
            CurrentUser = new Account();
            sqlconnection = new SqlConnection(connectionstring);

        }

        public string[] FindLogin(string Username)
        {
            string[] creds = new string[3];

            var importStatement = "SELECT Username,Password,AccountID FROM tbl_AccountCredentials WHERE Username = @Username";
            SqlCommand ImportCommand = new SqlCommand(importStatement, sqlconnection);
            ImportCommand.Parameters.AddWithValue("@Username", Username);
            sqlconnection.Open();
            SqlDataReader reader = ImportCommand.ExecuteReader();

            if (reader.Read())
            {
                creds[0] = reader["Username"].ToString();
                creds[1] = reader["Password"].ToString();
                creds[2] = reader["AccountID"].ToString();
                sqlconnection.Close();
                return creds;

            }
            sqlconnection.Close();
            return creds;
        }

        //public List<Ulam> GetFavorites()
        //{
        //    return List < Ulam > newList;
        //}

        public Account IdentifyUser(int AccountID)
        {
            var FindUser = "SELECT Username,Password,FirstName,LastName,Gender,Birthday from tbl_AccountCredentials as ac LEFT JOIN tbl_AccountDetails as ad ON ac.AccountID = ad.AccountID WHERE ac.accountID = @accountID";
            SqlCommand FindUserCommand = new SqlCommand(FindUser, sqlconnection);
            FindUserCommand.Parameters.AddWithValue("@accountID", AccountID);
            sqlconnection.Open();
            SqlDataReader read = FindUserCommand.ExecuteReader();

            if (read.Read())
            {
                CurrentUser.FirstName = read["FirstName"].ToString();
                CurrentUser.LastName = read["LastName"].ToString();
                CurrentUser.Gender  = read["Gender"].ToString();
                CurrentUser.Birthday = DateOnly.FromDateTime(Convert.ToDateTime(read["Birthday"].ToString()));
                return CurrentUser;
            }
            return null;
        }

    }
}
