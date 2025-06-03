using Baccofy.Config;
using Baccofy.Models;
using Npgsql;
using System.Collections.Generic;
using System.Data;

namespace Baccofy.Controllers
{
    public class DetailPencatatanController
    {
        public static List<DetailPencatatanModel> GetByPencatatanId(int id)
        {
            List<DetailPencatatanModel> list = new List<DetailPencatatanModel>();

            using (var conn = PostgresConnection.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(@"SELECT dp.id_detail, dp.quantity, dp.keterangan, dp.bahan_id_bahan, b.nama_bahan
                                              FROM detail_pencatatan dp
                                              JOIN bahan b ON dp.bahan_id_bahan = b.id_bahan
                                              WHERE dp.pencatatan_id_pencatatan = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new DetailPencatatanModel
                        {
                            Id_Detail = reader.GetInt32(0),
                            Quantity = reader.GetInt32(1),
                            Keterangan = reader.IsDBNull(2) ? "" : reader.GetString(2),
                            Bahan_Id_Bahan = reader.GetInt32(3),
                            Nama_Bahan = reader.GetString(4),
                            Pencatatan_Id_Pencatatan = id
                        });
                    }
                }
            }

            return list;
        }

        public static List<BahanModel> GetAllBahan()
        {
            List<BahanModel> list = new List<BahanModel>();

            using (var conn = PostgresConnection.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT id_bahan, nama_bahan FROM bahan", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new BahanModel
                        {
                            Id_Bahan = reader.GetInt32(0),
                            Nama_Bahan = reader.GetString(1)
                        });
                    }
                }
            }

            return list;
        }

        public static void InsertDetail(int idPencatatan, int idBahan, int quantity, string keterangan)
        {
            using (var conn = PostgresConnection.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(@"INSERT INTO detail_pencatatan 
                    (quantity, keterangan, pencatatan_id_pencatatan, bahan_id_bahan)
                    VALUES (@qty, @ket, @idPencatatan, @idBahan)", conn);
                cmd.Parameters.AddWithValue("@qty", quantity);
                cmd.Parameters.AddWithValue("@ket", keterangan ?? "");
                cmd.Parameters.AddWithValue("@idPencatatan", idPencatatan);
                cmd.Parameters.AddWithValue("@idBahan", idBahan);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
