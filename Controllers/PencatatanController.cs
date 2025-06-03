using Baccofy.Config;
using Baccofy.Models;
using Npgsql;
using System.Collections.Generic;
using System.Data;

public class PencatatanController
{
    public static List<KeyValuePair<int, string>> GetAllAkun()
    {
        var list = new List<KeyValuePair<int, string>>();
        using var conn = PostgresConnection.GetConnection();
        conn.Open();
        var cmd = new NpgsqlCommand("SELECT id_akun, username FROM akun", conn);
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
        }
        return list;
    }

    public static List<PencatatanModel> GetAll()
    {
        var list = new List<PencatatanModel>();
        using var conn = PostgresConnection.GetConnection();
        conn.Open();
        var cmd = new NpgsqlCommand("SELECT id_pencatatan, tanggal, akun_id_akun FROM pencatatan", conn);
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new PencatatanModel
            {
                Id_Pencatatan = reader.GetInt32(0),
                Tanggal = reader.GetDateTime(1),
                Akun_Id_Akun = reader.GetInt32(2)
            });
        }
        return list;
    }

    public static PencatatanModel GetById(int id)
    {
        using var conn = PostgresConnection.GetConnection();
        conn.Open();
        var cmd = new NpgsqlCommand("SELECT id_pencatatan, tanggal, akun_id_akun FROM pencatatan WHERE id_pencatatan = @id", conn);
        cmd.Parameters.AddWithValue("@id", id);
        using var reader = cmd.ExecuteReader();
        if (reader.Read())
        {
            return new PencatatanModel
            {
                Id_Pencatatan = reader.GetInt32(0),
                Tanggal = reader.GetDateTime(1),
                Akun_Id_Akun = reader.GetInt32(2)
            };
        }
        return null;
    }

    public static void Insert(PencatatanModel model)
    {
        using var conn = PostgresConnection.GetConnection();
        conn.Open();
        var cmd = new NpgsqlCommand("INSERT INTO pencatatan (tanggal, akun_id_akun) VALUES (@tgl, @id_akun)", conn);
        cmd.Parameters.AddWithValue("@tgl", model.Tanggal);
        cmd.Parameters.AddWithValue("@id_akun", model.Akun_Id_Akun);
        cmd.ExecuteNonQuery();
    }

    public static void Update(PencatatanModel model)
    {
        using var conn = PostgresConnection.GetConnection();
        conn.Open();
        var cmd = new NpgsqlCommand("UPDATE pencatatan SET tanggal = @tgl, akun_id_akun = @id_akun WHERE id_pencatatan = @id", conn);
        cmd.Parameters.AddWithValue("@tgl", model.Tanggal);
        cmd.Parameters.AddWithValue("@id_akun", model.Akun_Id_Akun);
        cmd.Parameters.AddWithValue("@id", model.Id_Pencatatan);
        cmd.ExecuteNonQuery();
    }

    public static DataTable GetAllWithUsername()
    {
        using var conn = PostgresConnection.GetConnection();
        conn.Open();
        var cmd = new NpgsqlCommand(@"
            SELECT 
                p.id_pencatatan, 
                p.tanggal, 
                a.username 
            FROM pencatatan p 
            JOIN akun a ON a.id_akun = p.akun_id_akun
            ORDER BY p.id_pencatatan ASC", conn);
        var adapter = new NpgsqlDataAdapter(cmd);
        var dt = new DataTable();
        adapter.Fill(dt);
        return dt;
    }
}
