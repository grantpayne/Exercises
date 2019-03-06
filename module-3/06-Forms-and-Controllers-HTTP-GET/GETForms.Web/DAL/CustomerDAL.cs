using GETForms.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.DAL
{
    public class CustomerDAL : ICustomerDAL
    {
        private string connectionString;

        public CustomerDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Searches for customers.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="sortBy"></param>
        /// <returns></returns>
        public IList<Customer> SearchForCustomers(string search, string sortBy)
        {
            IList<Customer> customers = new List<Customer>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT first_name, last_name, email, active FROM customer WHERE (last_name LIKE @search) OR (first_name LIKE @search)", conn);
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                switch (sortBy)
                {
                    case "Last Name":
                        cmd.CommandText += "ORDER BY last_name";
                        break;
                    case "email":
                        cmd.CommandText += "ORDER BY email";
                        break;
                    case "active":
                        cmd.CommandText += "ORDER BY active";
                        break;
                }
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    customers.Add(MapRowToCustomer(reader));
                }
            }

            return customers;
        }

        private Customer MapRowToCustomer(SqlDataReader reader)
        {
            return new Customer()
            {
                FirstName = Convert.ToString(reader["first_name"]),
                LastName = Convert.ToString(reader["last_name"]),
                Email = Convert.ToString(reader["email"]),
                IsActive = (bool)(reader["active"]),
            };
        }
    }
}
