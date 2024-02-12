using Justo.Models;
using System.Data;
using System.Data.SqlClient;

namespace Justo.Data.Services
{
    public class UserService : IUserService
    {
        private readonly SqlConnectionConfiguration _configuration;

        public UserService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<List<User>> GetUsers()
        {
            try
            {
                List<User> users = new List<User>();
                using(SqlConnection con = new SqlConnection(_configuration.ConnectionString))
                {

                    const string query = "select * from dbo.AspNetUsers";
                    SqlCommand cmd = new SqlCommand(query, con)
                    {
                        CommandType = CommandType.Text
                    };
                    con.Open();
                    SqlDataReader reader = await cmd.ExecuteReaderAsync();
                    while(reader.Read())
                    {
                        User Usuario = new User
                        {
                            Id = Guid.Parse(reader["Id"].ToString()),
                            UserName = reader["Username"].ToString(),
                            Email = reader["Email"].ToString(),
                            RoleId = new Guid()
                        };

                        users.Add(Usuario);
                    }
                    cmd.Dispose();
                }
                return users;
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
                throw;
            }
        }
        public async Task<User> GetUser(Guid id)
        {
            try
            {
                User user = new User();
                using (SqlConnection con = new SqlConnection(_configuration.ConnectionString))
                {

                    const string query = "select * from dbo.AspNetUsers where Id = @Id";
                    using(SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Id", id);
                        con.Open();

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if(reader.Read())
                            {
                                user.Id = Guid.Parse(reader["Id"].ToString());
                                user.UserName = reader["Username"].ToString();
                                user.Email = reader["Email"].ToString();
                            }

                        }
                    }
                }
                return user;
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
                throw;
            }
        }



        public async Task<bool> UpdateUserRole(Guid id, User user)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(_configuration.ConnectionString))
                {

                    const string query = "insert into dbo.AspNetUsers " + "(UserId,RoleId) values(@UserId, @RoleId)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@UserId", id);
                        cmd.Parameters.AddWithValue("@RoleId", user.RoleId);

                        con.Open();
                    }
                }
                return true;
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
                throw;
            }
        }


        public async Task<bool> DeleteUser(Guid id)
        {
            try
            {
                User user = new User();
                using (SqlConnection con = new SqlConnection(_configuration.ConnectionString))
                {

                    const string query = "delete from dbo.AspNetUsers where Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, con)
                    {
                        CommandType = CommandType.Text,
                    };

                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    int result_linhas_afetadas =  await cmd.ExecuteNonQueryAsync();

                    cmd.Dispose();
                }
                return true;
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
                throw;
            }
        }

    }
}
