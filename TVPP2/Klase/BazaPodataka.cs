using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace TVPP2.Klase
{
    public class BazaPodataka
    {
        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Damjan\OneDrive\Desktop\TVPRENTA\RentACarDB.accdb";

        public DataTable IzvrsiUpit(string query)
        {
            DataTable result = new DataTable();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    connection.Open();
                    adapter.Fill(result);
                }
            }

            return result;
        }

        public DataTable IzvrsiUpit(string query, OleDbParameter[] parameters)
        {
            DataTable result = new DataTable();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        connection.Open();
                        adapter.Fill(result);
                    }
                }
            }

            return result;
        }

        public void IzvrsiKomandu(string commandText, OleDbParameter[] parameters = null)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(commandText, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public object IzvrsiSkalarUpit(string query)
        {
            object result;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    result = command.ExecuteScalar();
                }
            }
            return result;
        }
    }

}
