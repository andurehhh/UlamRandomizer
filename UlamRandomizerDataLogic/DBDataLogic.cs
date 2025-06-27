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
    public class DBDataLogic : IURDataLogic
    {
        static string connectionString = "Data Source =NITROV\\SQLEXPRESS; Initial Catalog = DBUlamRandomizer; Integrated Security = True; TrustServerCertificate = True;";

        static SqlConnection sqlConnection;

        public DBDataLogic()
        {
            sqlConnection = new SqlConnection(connectionString);

        }
        public void CreateUlam(Ulam ulam)
        {
            var insertStatement = "INSERT INTO tbl_ulamDetails(ulamName,MainIngredient1,MainIngredient2,ulamDescription) VALUES (@UlamName,@MainIngredient1,@MainIngredient2,@ulamDescription)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@UlamName", ulam.UlamName);
            insertCommand.Parameters.AddWithValue("@MainIngredient1", ulam.MainIngredient1);
            insertCommand.Parameters.AddWithValue("@MainIngredient2", ulam.MainIngredient2);
            insertCommand.Parameters.AddWithValue("@ulamDescription", ulam.ulamDescription);
            sqlConnection.Open();

            insertCommand.ExecuteNonQuery();

            sqlConnection.Close();
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
                    MainIngredient1 = reader["MainIngredient1"].ToString(),
                    MainIngredient2 = reader["MainIngredient2"].ToString(),
                    ulamDescription = reader["ulamDescription"].ToString(),
                }
                    );
            }

            sqlConnection.Close();
            return ulamList;
        }

        public void RemoveUlam(Ulam ulam)
        {

            var deleteStatement = "DELETE FROM tbl_ulamDetails WHERE UlamName = @UlamName";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
            deleteCommand.Parameters.AddWithValue("@UlamName", ulam.UlamName);

            sqlConnection.Open();
            deleteCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }

        public void UpdateUlam(Ulam ulam)
        {
            sqlConnection.Open();
            var updateStatement = $"UPDATE tbl_ulamDetails SET MainIngredient1 = @MainIngredient1, MainIngredient2 = @MainIngredient2 ulamDescription = @ulamDescription WHERE UlamName = @UlamName";

            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);

            updateCommand.Parameters.AddWithValue("@UlamName", ulam.UlamName);
            updateCommand.Parameters.AddWithValue("@MainIngredient1", ulam.MainIngredient1);
            updateCommand.Parameters.AddWithValue("@MainIngredient2", ulam.MainIngredient2);
            updateCommand.Parameters.AddWithValue("@ulamDescription", ulam.ulamDescription);
            updateCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
        
    }
}
