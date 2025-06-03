using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baccofy.Models
{
    public class AkunModel
    {
        public int Id_Akun { get; set; }
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public string Nomor_Telepon { get; set; } = "";
        public int Role_Id_Role { get; set; }
        public string Nama_Role { get; set; } = "";
    }
}
