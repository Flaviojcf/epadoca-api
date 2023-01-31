using epadoca_api.Model;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace epadoca_api.DAO
{
    public class BakeryDAO
    {
        readonly string databaseConnection = "Data Source=localhost\\;Initial Catalog=DB_BAKERY;User ID=flavio;Password=123456";

        public List<BakeryModel> GetBakery()
        {
            List<BakeryModel> bakeries = new List<BakeryModel>();

            using (SqlConnection conn = new SqlConnection(databaseConnection))
            {
                conn.Open();
                
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM BAKERIES", conn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                var bakery = new BakeryModel
                                {
                                    Id = reader["Id"].ToString(),
                                    City = reader["City"].ToString(),
                                    Name = reader["Name"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    State = reader["State"].ToString(),
                                    Street = reader["Street"].ToString()
                                };
                                bakeries.Add(bakery);
                            }
                        }
                    }
                }
            }
            return bakeries;
        }
    }
}
