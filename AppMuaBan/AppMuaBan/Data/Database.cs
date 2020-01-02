using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using AppMuaBan.Models;

namespace AppMuaBan.Data
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;
        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Sanpham>().Wait();
            _database.CreateTableAsync<Donhang>().Wait();
        }

        public Task<List<Sanpham>> GetSanphamAsync()
        {
            return _database.Table<Sanpham>().ToListAsync();
        }

        public Task<Sanpham> GetSanphamAsync(int id)
        {
            return _database.Table<Sanpham>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveSanphamAsync(Sanpham sp)
        {
            if (sp.ID != 0)
                return _database.UpdateAsync(sp);
            else
                return _database.InsertAsync(sp);
        }

        public Task<int> DeleteSanphamAsync(Sanpham sp)
        {
            return _database.DeleteAsync(sp);
        }
        public Task<List<Donhang>> GetDonhangAsync()
        {
            return _database.Table<Donhang>().ToListAsync();
        }

        public Task<Donhang> GetDonhangAsync(int id)
        {
            return _database.Table<Donhang>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveDonhangAsync(Donhang DH)
        {
            if (DH.ID != 0)
                return _database.UpdateAsync(DH);
            else
                return _database.InsertAsync(DH);
        }

        public Task<int> DeleteDonhangAsync(Donhang DH)
        {
            return _database.DeleteAsync(DH);
        }
    }
}
