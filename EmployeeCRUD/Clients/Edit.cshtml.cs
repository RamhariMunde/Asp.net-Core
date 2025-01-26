using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace MyStore.Pages.Clients
{
    public class EditModel : PageModel
    {
        public ClientInfo clientInfo = new ClientInfo();
        public string errorMessage = "";
        public string successMessage = "";
        public void OnGet()
        {
            string id = Request.Query["id"];

            try
            {
                string connectionString = "Data Source=XYZ;Initial Catalog=Employees;Integrated Security=True;Encrypt=False";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "Select * from Employee where id=@id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                clientInfo.id = "" + reader.GetInt32(0);
                                clientInfo.name = reader.GetString(1);
                                clientInfo.designation = reader.GetString(2);
                                clientInfo.doj = reader.GetDateTime(3).ToString("yyyy-MM-dd");
                                clientInfo.salary = reader.GetDecimal(4).ToString();
                                clientInfo.gender = reader.GetString(5);
                                clientInfo.state = reader.GetString(6);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
        }

        public void OnPost() 
        {   clientInfo.id = Request.Form["id"];
            clientInfo.name = Request.Form["name"];
            clientInfo.designation = Request.Form["designation"];
            clientInfo.doj = Request.Form["doj"];
            clientInfo.salary = Request.Form["salary"];
            clientInfo.gender = Request.Form["gender"];
            clientInfo.state = Request.Form["state"];

            if (string.IsNullOrWhiteSpace(clientInfo.id) || 
                string.IsNullOrWhiteSpace(clientInfo.name) ||
                   string.IsNullOrWhiteSpace(clientInfo.designation) ||
                   string.IsNullOrWhiteSpace(clientInfo.doj) ||
                   string.IsNullOrWhiteSpace(clientInfo.salary) ||
                   string.IsNullOrWhiteSpace(clientInfo.gender) ||
                   string.IsNullOrWhiteSpace(clientInfo.state))
            {
                errorMessage = "All the fields are required";
                return;
            }

            try
            {
                string connectionString = "Data Source=RBM;Initial Catalog=Employees;Integrated Security=True;Encrypt=False";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "Update Employee " + 
                                 "Set name=@name, designation=@designation, doj=@doj, salary=@salary, gender=@gender, state=@state " +
                                 "where id=@id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                            command.Parameters.AddWithValue("@name", clientInfo.name);
                            command.Parameters.AddWithValue("@designation", clientInfo.designation);
                            command.Parameters.AddWithValue("@doj", clientInfo.doj);
                            command.Parameters.AddWithValue("@salary",clientInfo.salary);
                            command.Parameters.AddWithValue("@gender", clientInfo.gender);
                            command.Parameters.AddWithValue("@state", clientInfo.state);
                            command.Parameters.AddWithValue("@id", clientInfo.id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }
            Response.Redirect("/Clients/Index");
        }

    }
}
