using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAO.House
{
    public class MasterDataAccess
    {
        SqlConnection cnx;
        public MasterDataAccess()
        {
            cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=(local);Initial Catalog=DBSystem;Integrated Security=True";//ConfigurationManager.ConnectionStrings["cnx"].ConnectionString;
        }


        protected SqlCommand CreateCommand(string procedimiento)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = procedimiento;
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = cnx;

            return command;
        }

        protected SqlDataReader ExecuteReader(SqlCommand command)
        {
            cnx.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        protected void AddInPrameter(SqlCommand command,
            string paramName,
            object value)
        {
            command.Parameters.AddWithValue(paramName, value);
        }

        protected void ExecuteNonQuery(SqlCommand command)
        {
            cnx.Open();
            command.ExecuteNonQuery();
            cnx.Close();
        }
    }
}
