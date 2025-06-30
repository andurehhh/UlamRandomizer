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

        public Account IdentifyUser(int AccountID)
        {
            var FindUser = "SELECT ac.AccountID, Username,Password,FirstName,LastName,Gender,Birthday from tbl_AccountCredentials as ac LEFT JOIN tbl_AccountDetails as ad ON ac.AccountID = ad.AccountID WHERE ac.accountID = @accountID";
            SqlCommand FindUserCommand = new SqlCommand(FindUser, sqlconnection);
            FindUserCommand.Parameters.AddWithValue("@accountID", AccountID);
            sqlconnection.Open();
            SqlDataReader read = FindUserCommand.ExecuteReader();

            if (read.Read())
            {
                CurrentUser.Id = Convert.ToInt32(read["AccountID"]);
                CurrentUser.FirstName = read["FirstName"].ToString();
                CurrentUser.LastName = read["LastName"].ToString();
                CurrentUser.Gender  = read["Gender"].ToString();
                CurrentUser.Birthday = DateOnly.FromDateTime(Convert.ToDateTime(read["Birthday"].ToString()));
                sqlconnection.Close();
                return CurrentUser;

            }
            sqlconnection.Close();
            return null;
        }

       
        public void AddAccount(Account account)
        {
            var insertDetailsStatement = @"
                INSERT INTO tbl_AccountDetails(FirstName, LastName, Gender, Birthday)
                OUTPUT INSERTED.AccountID
                VALUES (@FirstName, @LastName, @Gender, @Birthday)";
            SqlCommand insertDetailsCommand = new SqlCommand(insertDetailsStatement, sqlconnection);
            insertDetailsCommand.Parameters.AddWithValue("@FirstName", account.FirstName);
            insertDetailsCommand.Parameters.AddWithValue("@LastName", account.LastName);
            insertDetailsCommand.Parameters.AddWithValue("@Gender", account.Gender);
            insertDetailsCommand.Parameters.AddWithValue("@Birthday", account.Birthday);

            sqlconnection.Open();
            int newUserID = (int)insertDetailsCommand.ExecuteScalar();
            sqlconnection.Close();

            var insertCredentialStatement = @"
                INSERT INTO tbl_AccountCredentials(accountID, email, username, password)
                VALUES (@accountID, @email, @username, @password)";
            SqlCommand insertCredentialCommand = new SqlCommand(insertCredentialStatement, sqlconnection);
            insertCredentialCommand.Parameters.AddWithValue("@accountID", newUserID);
            insertCredentialCommand.Parameters.AddWithValue("@email", account.Email);
            insertCredentialCommand.Parameters.AddWithValue("@username", account.Username);
            insertCredentialCommand.Parameters.AddWithValue("@password", account.Password);

            sqlconnection.Open();
            insertCredentialCommand.ExecuteNonQuery();
            sqlconnection.Close();
        }
        public bool DoesEmailExist(string Email)
        {
            var SelectStatement = "SELECT email FROM tbl_AccountCredentials WHERE email = @email";
            SqlCommand selectCommand = new SqlCommand(SelectStatement, sqlconnection);
            selectCommand.Parameters.AddWithValue("@email", Email);
            sqlconnection.Open();
            SqlDataReader read = selectCommand.ExecuteReader();

            if (read.Read())
            {
                if (read.HasRows)
                {
                    sqlconnection.Close();
                    return true;
                }

            }
            sqlconnection.Close();
            return false;


        }

        public void AddCustomUlamToFavorite(int accountID, int UlamID,string UlamName)
        {
            var InsertStatement = "INSERT INTO tbl_Favorites (AccountID, UlamID,UlamName,UlamType,DateFavorite) VALUES (@accountID, @UlamID,@UlamName,'Custom', GETDATE())";
            SqlCommand insertCommand = new SqlCommand(InsertStatement, sqlconnection);
            insertCommand.Parameters.AddWithValue("@accountID", accountID);
            insertCommand.Parameters.AddWithValue("@UlamID", UlamID);
            insertCommand.Parameters.AddWithValue("@UlamName", UlamName);
            sqlconnection.Open();
            insertCommand.ExecuteNonQuery();
            sqlconnection.Close();
        }
        public int GetCustomUlamID(Ulam UlamToFind)
        {
            var SelectStatement = "SELECT UlamId FROM tbl_UlamDetails WHERE ulamName = @UlamName";
            SqlCommand SelectCommand = new SqlCommand(SelectStatement, sqlconnection);
            SelectCommand.Parameters.AddWithValue("@UlamName", UlamToFind.UlamName);
            sqlconnection.Open();
            SqlDataReader read = SelectCommand.ExecuteReader();
            while (read.Read()) 
            {
                int UlamID = Convert.ToInt32(read["UlamID"]);
                sqlconnection.Close();
                return UlamID;

            }
            return -1;

        }
        public void AddAPIToFavorite(int accountID, int UlamID,string APIName)
        {
            var InsertStatement = "INSERT INTO tbl_Favorites (AccountID, apiID,UlamName,UlamType,DateFavorite) VALUES (@accountID, @UlamID,@UlamName,'API', GETDATE())";
            SqlCommand insertCommand = new SqlCommand(InsertStatement, sqlconnection);
            insertCommand.Parameters.AddWithValue("@accountID", accountID);
            insertCommand.Parameters.AddWithValue("@UlamID", UlamID);
            insertCommand.Parameters.AddWithValue("@UlamName", APIName);

            sqlconnection.Open();
            insertCommand.ExecuteNonQuery();
            sqlconnection.Close();
        }

        public List<Ulam> GetFavoriteList(int accountID)
        {
            List<Ulam> Favs = new List<Ulam>();

            var SelectStatement = "SELECT Fav.ulamID,Ulam.ulamName,MainIngredient1,MainIngredient2,ulamDescription,ulamPicture, Fav.UlamType FROM tbl_Favorites AS Fav INNER JOIN tbl_UlamDetails AS Ulam ON Fav.ulamID = Ulam.ulamID WHERE accountID = @accountID AND UlamType = 'Custom'";
            SqlCommand SelectCommand = new SqlCommand(SelectStatement, sqlconnection);
            SelectCommand.Parameters.AddWithValue("@accountID", accountID);
            sqlconnection.Open();
            SqlDataReader reader = SelectCommand.ExecuteReader();
            while (reader.Read())
            {
                Favs.Add(new Ulam
                {
                    Id = Convert.ToInt32(reader["ulamID"]),
                    UlamName = reader["UlamName"].ToString(),
                    MainIngredient1 = reader["MainIngredient1"].ToString(),
                    MainIngredient2 = reader["MainIngredient2"].ToString(),
                    ulamDescription = reader["ulamDescription"].ToString(),
                    ImgString = reader["ulamPicture"].ToString(),
                    Type = reader["UlamType"].ToString(),
                }
                );
            }
            sqlconnection.Close();
            return Favs;
        }
        public List<Ulam> GetAPIList(int accountID)
        {
            var selectStatement = "SELECT apiID,UlamName,UlamType FROM tbl_Favorites WHERE AccountID = @AccountID AND UlamType = 'API'";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlconnection);
            selectCommand.Parameters.AddWithValue("@AccountID", accountID);
            sqlconnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();
            List<Ulam> apiList = new List<Ulam>();
            while (reader.Read())
            {
                apiList.Add(new Ulam
                {
                    Id = Convert.ToInt32(reader["apiID"]),
                    UlamName = reader["UlamName"].ToString(),
                    Type = reader["UlamType"].ToString(),
                }
                );
            }
            sqlconnection.Close();
            return apiList;
        }
        public bool DoesFavoriteExist(int accountID, int ulamID)
        {
            var selectStatement = "SELECT apiID FROM tbl_Favorites WHERE AccountID = @AccountID AND apiID = @UlamID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlconnection);
            selectCommand.Parameters.AddWithValue("@AccountID", accountID);
            selectCommand.Parameters.AddWithValue("@UlamID", ulamID);
            sqlconnection.Open();
            SqlDataReader read = selectCommand.ExecuteReader();
            if (read.HasRows)
            {
                sqlconnection.Close();
                return true;
            }
            else
            {
                sqlconnection.Close();
                return false;
            }
        }
        public void RemoveFavorite(int accountID, int ulamID)
        {
            var deleteStatement = "DELETE FROM tbl_Favorites WHERE AccountID = @AccountID AND (apiID = @UlamID OR ulamID = @UlamID)";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlconnection);
            deleteCommand.Parameters.AddWithValue("@AccountID", accountID);
            deleteCommand.Parameters.AddWithValue("@UlamID", ulamID);
            sqlconnection.Open();
            deleteCommand.ExecuteNonQuery();
            sqlconnection.Close();
        }
    }
}
