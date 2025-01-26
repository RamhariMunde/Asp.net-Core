using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Reflection.PortableExecutable;


namespace MyStore.Pages.Clients
{
    public class IndexModel : PageModel
    {
        public List<ClientInfo> ListClients { get; set; } = [];
        public void OnGet()
        {
            
            try
            {
                //string connectionString = "Server=.;Database=RBM;Trusted_Connection=True;TrustServerCertificate=Truel;";
                string connectionString = "Data Source=RBM;Initial Catalog=Employees;Integrated Security=True;Encrypt=False";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "Select * from employee";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader()) 
                        {
                            while (reader.Read())
                            {
                                ClientInfo clientInfo = new ClientInfo();
                                clientInfo.id = "" + reader.GetInt32(0);
                                clientInfo.name = reader.GetString(1);
                                clientInfo.designation = reader.GetString(2);
                                clientInfo.doj = reader.GetDateTime(3).ToString();
                                clientInfo.salary =""+reader.GetDecimal(4);
                                clientInfo.gender = reader.GetString(5);
                                clientInfo.state = reader.GetString(6);

                                ListClients.Add(clientInfo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }
    }
    public class ClientInfo
    {
        public string id;
        public string name;
        public string designation;
        public string doj;
        public string salary;
        public string gender;
        public string state;
    }
}
