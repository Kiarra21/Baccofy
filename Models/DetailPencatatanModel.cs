namespace Baccofy.Models
{
    public class DetailPencatatanModel
    {
        public int Id_Detail { get; set; }
        public int Quantity { get; set; }
        public string Keterangan { get; set; }
        public int Bahan_Id_Bahan { get; set; }
        public string Nama_Bahan { get; set; }
        public int Pencatatan_Id_Pencatatan { get; set; }
    }
}
