using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Data
{
    public class Test
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Test(int id, string text)
        {
            Id = id;
            Text = text;
        }


        public override string ToString()
        {
            return $"Id: {Id}, Text: {Text}";
        }
    }

    public class DBManager
    {
        public string ConnectionString = "Data Source=\"10.0.0.40, 1433\";Initial Catalog=ado_test;User ID=student;Password=1111;Encrypt=True;Trust Server Certificate=True";
        public string ConnectionString = "Data Source=10.0.0.40,1433;Initial Catalog=ado_test;User ID=student;Password=1111;Encrypt=True;Trust Server Certificate=True";

        public DBManager()
        {

        }

        public List<Test> SelectFromDb()
        {
            try
@@ -95,17 + 96,50 @@ public void UpdateToDb(Test test)

        public void OpenConnection()
            {
                throw new NotImplementedException();
                try
                {
                    using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                    {
                        connection.Open();
                        // Optionally, you can perform some actions after opening the connection
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            public void CloseConnection()
            {
                throw new NotImplementedException();
                try
                {
                    // Connection closing is handled automatically when the connection object goes out of scope,
                    // but you can explicitly close it if needed
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            public DataTable GetAllStationery()
            {
                throw new NotImplementedException();
                try
                {
                    DataTable result = new DataTable();
                    using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Stationery", connection);
                        adapter.Fill(result);
                    }
                    return result;
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            public List<string> GetAllStationeryTypes()
            {
                throw new NotImplementedException();
            }
            public List<string> GetAllSalesManagers()
            {
                throw new NotImplementedException();
            }
            public DataTable GetStationeryWithMaxUnits()
            {
                throw new NotImplementedException();
            }
            public DataTable GetStationeryWithMinUnits()
            {
                throw new NotImplementedException();
            }
            public DataTable GetStationeryWithMinCost()
            {
                throw new NotImplementedException();
            }
            public DataTable GetStationeryWithMaxCost()
            {
                throw new NotImplementedException();
            }
            public DataTable GetStationeryByType(string selectedType)
            {
                throw new NotImplementedException();
            }
            public DataTable GetStationeryByManager(string selectedManager)
            {
                throw new NotImplementedException();
            }
            public DataTable GetStationeryByBuyer(string selectedBuyer)
            {
                throw new NotImplementedException();
            }
            public DataRow GetRecentSale()
            {
                throw new NotImplementedException();
            }
            public Dictionary<string, double> GetAverageItemsPerType()
            {
                throw new NotImplementedException();
            }
        }
    }
}