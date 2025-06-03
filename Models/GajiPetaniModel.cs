namespace Baccofy.Models
{
    public class GajiPetaniModel
    {
        public int Id_Gaji { get; set; }
        public DateTime Tanggal { get; set; }
        public decimal Nominal { get; set; }
        public string Keterangan { get; set; } = "";
        public int Akun_Id_Akun { get; set; }
        public string Username { get; set; } = ""; // Untuk tampilan JOIN
    }
}
