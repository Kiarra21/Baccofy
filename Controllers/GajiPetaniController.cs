using Baccofy.Config;
using Baccofy.Models;
using Npgsql;
using System.Collections.Generic;

namespace Baccofy.Controllers
{
    public class GajiPetaniController
    {
        public static List<GajiPetaniModel> GetAll()
        {
            var list = new List<GajiPetaniModel>();
            using var conn = PostgresConnection.GetConnection();
            conn.Open();
            var query = @"SELECT g.id_gaji, g.tanggal, g.nominal, g.keterangan, g.akun_id_akun, a.username
                          FROM gaji_petani g
                          JOIN akun a ON g.akun_id_akun = a.id_akun";
            using var cmd = new NpgsqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new GajiPetaniModel
                {
                    Id_Gaji = reader.GetInt32(0),
                    Tanggal = reader.GetDateTime(1),
                    Nominal = reader.GetDecimal(2),
                    Keterangan = reader.IsDBNull(3) ? "" : reader.GetString(3),
                    Akun_Id_Akun = reader.GetInt32(4),
                    Username = reader.GetString(5)
                });
            }
            return list;
        }

        public static void Insert(GajiPetaniModel gaji)
        {
            using var conn = PostgresConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand("INSERT INTO gaji_petani (tanggal, nominal, keterangan, akun_id_akun) VALUES (@tanggal, @nominal, @keterangan, @akun)", conn);
            cmd.Parameters.AddWithValue("@tanggal", gaji.Tanggal);
            cmd.Parameters.AddWithValue("@nominal", gaji.Nominal);
            cmd.Parameters.AddWithValue("@keterangan", gaji.Keterangan ?? "");
            cmd.Parameters.AddWithValue("@akun", gaji.Akun_Id_Akun);
            cmd.ExecuteNonQuery();
        }

        public static void Update(GajiPetaniModel gaji)
        {
            using var conn = PostgresConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand("UPDATE gaji_petani SET tanggal = @tanggal, nominal = @nominal, keterangan = @keterangan, akun_id_akun = @akun WHERE id_gaji = @id", conn);
            cmd.Parameters.AddWithValue("@id", gaji.Id_Gaji);
            cmd.Parameters.AddWithValue("@tanggal", gaji.Tanggal);
            cmd.Parameters.AddWithValue("@nominal", gaji.Nominal);
            cmd.Parameters.AddWithValue("@keterangan", gaji.Keterangan ?? "");
            cmd.Parameters.AddWithValue("@akun", gaji.Akun_Id_Akun);
            cmd.ExecuteNonQuery();
        }

        public static void Delete(int id)
        {
            using var conn = PostgresConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand("DELETE FROM gaji_petani WHERE id_gaji = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
