using System.Data.SqlClient;
using System.Net.Http;


#nullable disable

namespace Application.Models
{
    public class Repository
    {

        public int SignInAdmin(Admin admin)
        {    
         
            SqlConnection connection = new SqlConnection(getAdminConnection());
            connection.Open();
            int ID=admin.AdminID;
            string Password=admin.AdminPassword;

            SqlCommand command = new SqlCommand($"Select Count(*) from AdminData where AdminID='"+ID+"' AND AdminPassword='"+Password+"';",connection);
            
            int count=Convert.ToInt32(command.ExecuteScalar());
            try{            
            if(count==1)
            {
                return 1;
            }

            }        

            // catch(SqlException sqlexception)
            // {
            //     Console.WriteLine("Error : "+ sqlexception.Message.ToString());
            // }
            finally
            {
                Console.WriteLine("Press any key to exit.....");
                connection.Close(); 
            }   

            return 0;
        
        }

    public static string getAdminConnection()
        {

        var build = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json",optional:true,reloadOnChange:true);

        IConfiguration configuration = build.Build();

        string connectionString = Convert.ToString(configuration.GetConnectionString("AdminData"));

        return connectionString;

        }
    }
}