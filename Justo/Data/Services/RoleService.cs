using Justo.Models.Users;
using Justo.Pages.Admin.Users;
using System.Data;
using System.Data.SqlClient;

namespace Justo.Data.Services
{
    public class RoleService : IRoleService
    {
        private readonly SqlConnectionConfiguration _configuration;
        public RoleService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;        
        }


        public async Task<List<Role>> GetRoles()
        {
            List<Role> roles = new List<Role>();
            try
            {
                using (SqlConnection con = new SqlConnection(_configuration.ConnectionString))
                {

                    const string query = "select * from dbo.AspNetRoles";
                    SqlCommand cmd = new SqlCommand(query, con)
                    {
                        CommandType = CommandType.Text
                    };
                    con.Open();
                    SqlDataReader reader = await cmd.ExecuteReaderAsync();
                    while (reader.Read())
                    {
                        Role usuario = new Role
                        {
                            Id = Guid.Parse(reader["Id"].ToString()),
                            Name = reader["Name"].ToString(),
                            NormalizedName = reader["NormalizedName"].ToString(),
                            ConcurrencyStamp = Guid.Parse(reader["ConcurrencyStamp"].ToString()),
                        };

                        roles.Add(usuario);
                    }
                    cmd.Dispose();
                }
                return roles;
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
                throw;
            }
}
    }
}
