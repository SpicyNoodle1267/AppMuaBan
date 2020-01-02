using SQLite;

namespace AppMuaBan.Models
{
    public class Sanpham
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string TenSP { get; set; }
        public int Price { get; set; }
    }
}
