using Baccofy.Config;
using Baccofy.Models;
using Npgsql;
using System.Collections.Generic;

namespace Baccofy.Controllers
{
    public class AkunController
    {
        public static List<AkunModel> GetAll()
        {
            var list = new List<AkunModel>();
            using var conn = PostgresConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand("SELECT a.id_akun, a.username, a.password, a.nomor_telepon, a.role_id_role, r.nama_role FROM akun a JOIN role r ON a.role_id_role = r.id_role", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new AkunModel
                {
                    Id_Akun = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Password = reader.GetString(2),
                    Nomor_Telepon = reader.GetString(3),
                    Role_Id_Role = reader.GetInt32(4),
                    Nama_Role = reader.GetString(5)
                });
            }
            return list;
        }

        public static List<RoleModel> GetAllRoles()
        {
            var list = new List<RoleModel>();
            using var conn = PostgresConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand("SELECT id_role, nama_role FROM role", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new RoleModel
                {
                    Id_Role = reader.GetInt32(0),
                    Nama_Role = reader.GetString(1)
                });
            }
            return list;
        }

        public static void Create(AkunModel akun)
        {
            using var conn = PostgresConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand("INSERT INTO akun (username, password, nomor_telepon, role_id_role) VALUES (@username, @password, @nomor, @role)", conn);
            cmd.Parameters.AddWithValue("@username", akun.Username);
            cmd.Parameters.AddWithValue("@password", akun.Password);
            cmd.Parameters.AddWithValue("@nomor", akun.Nomor_Telepon);
            cmd.Parameters.AddWithValue("@role", akun.Role_Id_Role);
            cmd.ExecuteNonQuery();
        }

        public static void Update(AkunModel akun)
        {
            using var conn = PostgresConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand("UPDATE akun SET username = @username, password = @password, nomor_telepon = @nomor, role_id_role = @role WHERE id_akun = @id", conn);
            cmd.Parameters.AddWithValue("@id", akun.Id_Akun);
            cmd.Parameters.AddWithValue("@username", akun.Username);
            cmd.Parameters.AddWithValue("@password", akun.Password);
            cmd.Parameters.AddWithValue("@nomor", akun.Nomor_Telepon);
            cmd.Parameters.AddWithValue("@role", akun.Role_Id_Role);
            cmd.ExecuteNonQuery();
        }

        public static void Delete(int id)
        {
            using var conn = PostgresConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand("DELETE FROM akun WHERE id_akun = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}