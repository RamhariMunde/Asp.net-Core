using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace MyStore.Pages.Clients
{
    public class CreateModel : PageModel
    {
        public ClientInfo clientInfo = new ClientInfo();
        public string errorMessage = "";
        public string successMessage = "";

        public void OnGet()
        {
        }

        public HttpRequest GetRequest()
        {
            return Request;
        }

        public void OnPost()
        {
            try
            {
                // Validate input fields
                clientInfo.name = Request.Form["name"];
                clientInfo.designation = Request.Form["designation"];
                clientInfo.doj = Request.Form["doj"];
                clientInfo.salary = Request.Form["salary"];
                clientInfo.gender = Request.Form["gender"];
                clientInfo.state = Request.Form["state"];

                if (string.IsNullOrWhiteSpace(clientInfo.name) ||
                    string.IsNullOrWhiteSpace(clientInfo.designation) ||
                    string.IsNullOrWhiteSpace(clientInfo.doj) ||
                    string.IsNullOrWhiteSpace(clientInfo.salary) ||
                    string.IsNullOrWhiteSpace(clientInfo.gender) ||
                    string.IsNullOrWhiteSpace(clientInfo.state))
                {
                    errorMessage = "All the fields are required";
                    return;
                }

                // Validate date format for DOJ
                if (!DateTime.TryParse(clientInfo.doj, out DateTime parsedDoj))
                {
                    errorMessage = "Invalid date format for Date of Joining (DOJ).";
                    return;
                }

                // Validate numeric salary
                if (!decimal.TryParse(clientInfo.salary, out decimal parsedSalary))
                {
                    errorMessage = "Salary must be a valid numeric value.";
                    return;
                }

                // Save the new client into the database
                string connectionString = "Data Source=XYZ;Initial Catalog=Employees;Integrated Security=True;Encrypt=False";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO Employee (name, designation, doj, salary, gender, state) " +
                                 "VALUES (@name, @designation, @doj, @salary, @gender, @state)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", clientInfo.name);
                        command.Parameters.AddWithValue("@designation", clientInfo.designation);
                        command.Parameters.AddWithValue("@doj", parsedDoj);
                        command.Parameters.AddWithValue("@salary", parsedSalary);
                        command.Parameters.AddWithValue("@gender", clientInfo.gender);
                        command.Parameters.AddWithValue("@state", clientInfo.state);

                        command.ExecuteNonQuery();
                    }
                }

                // Reset clientInfo and set success message
                clientInfo.name = "";
                clientInfo.designation = "";
                clientInfo.doj = "";
                clientInfo.salary = "";
                clientInfo.gender = "";
                clientInfo.state = "";
                successMessage = "New Client Added Correctly";

                // Redirect to Index page
                Response.Redirect("/Clients/Index");
            }
            catch (Exception ex)
            {
                errorMessage = "An error occurred: " + ex.Message;
            }
        }
    }
}
