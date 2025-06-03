using Baccofy.Config;
using Baccofy.Models;
using Npgsql;
using System;

namespace Baccofy.Controllers
{
    public class AuthController
    {
        public (bool isAuthenticated, string role) Login(string username, string password)
        {
            using (var conn = PostgresConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT a.id_akun, a.username, a.password, r.nama_role
                                     FROM akun a
                                     JOIN role r ON a.role_id_role = r.id_role
                                     WHERE a.username = @username AND a.password = @password";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader["nama_role"].ToString();
                                return (true, role);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return (false, null);
        }

        public bool Register(AkunModel akun)
        {
            using (var conn = PostgresConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"INSERT INTO akun (username, nomor_telepon, password, role_id_role)
                                     VALUES (@username, @nomor, @password, @role)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", akun.Username);
                        cmd.Parameters.AddWithValue("@nomor", akun.Nomor_Telepon);
                        cmd.Parameters.AddWithValue("@password", akun.Password);
                        cmd.Parameters.AddWithValue("@role", akun.Role_Id_Role); 

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
