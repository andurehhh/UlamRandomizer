using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlamCommon;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
namespace UlamRandomizerDataLogic
{
    class DBDataLogic : IURDataLogic
    {
        //static List<Ulam> ulamList;
        //connectionstring 
        static string connectionString = "Data Source =NITROV\\SQLEXPRESS; Initial Catalog = DBUlamRandomizer; Integrated Security = True; TrustServerCertificate = True;";

        static SqlConnection sqlConnection;

        public DBDataLogic()
        {
            //ulamList = new List<Ulam>();
            sqlConnection = new SqlConnection(connectionString);

        }
        public void CreateUlam(Ulam ulam)
        {
            throw new NotImplementedException();
        }

        public List<Ulam> GetUlams()
        {

            var selectStatement = "SELECT * FROM tbl_ulamDetails";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            var ulamList = new List<Ulam>();

            while (reader.Read())
            {
                ulamList.Add(new Ulam
                {
                    UlamName = reader["UlamName"].ToString(),
                    MainIngredient = reader["MainIngredient"].ToString(),
                    ulamDescription = reader["ulamDescription"].ToString(),
                    isMarked = Convert.ToBoolean(reader["isMarked"].ToString())

                }
                    );
            }

            sqlConnection.Close();
            return ulamList;
        }

        public void RemoveUlam(Ulam ulam)
        {
            throw new NotImplementedException();
        }

        public void UpdateUlam(Ulam ulam)
        {
            sqlConnection.Open();
            var updateStatement = $"UPDATE tbl_ulamDetails SET MainIngredient = @MainIngredient, ulamDescription = @ulamDescription WHERE UlamName = @UlamName";

            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);

            updateCommand.Parameters.AddWithValue("@UlamName", ulam.UlamName);
            updateCommand.Parameters.AddWithValue("@MainIngredient", ulam.MainIngredient);
            updateCommand.Parameters.AddWithValue("@ulamDescription", ulam.ulamDescription);
            updateCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
