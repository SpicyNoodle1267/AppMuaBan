using System;
using SQLite;

namespace AppMuaBan.Models
{
    public class Donhang
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string TenSP { get; set; }
        public int SL { get; set; }
        public string Address { get; set; }
        public string SDT { get; set; }
        public DateTime date { get; set; }
    }
}
