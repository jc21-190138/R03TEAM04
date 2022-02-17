using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections;
using SQLite;

namespace NavPageSample
{
    public class Database

        //SQLiteDBへのアクセスクラス
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            //DBパスを渡して、
            _database = new SQLiteAsyncConnection(dbPath);
            //パス.create_tableでUSERテーブルを作るメソッド
            _database.CreateTableAsync<User>().Wait();
            _database.CreateTableAsync<Medicine>().Wait();
            _database.CreateTableAsync<Allergie>().Wait();
            _database.CreateTableAsync<TakeMedicine>().Wait();
            _database.CreateTableAsync<TakeTime>().Wait();
        
        }

        //USERテーブル関連
        //USERテーブルからデータを取得し、リストを返すメソッド
        public Task<List<User>>GetUsersAsync()
        {   
            return _database.Table<User>().ToListAsync();
        }

        //DBパスを渡して、
        public Task<User> GetUserAsync(int id)
        {
            return _database.Table<User>().Where(i => i.User_id == id).FirstOrDefaultAsync();
        }

        //ユーザテーブルにデータを保存するメソッド
        public Task<int> SaveUserAsync(User user)
        {   
            //ユーザIDっでどっちのメソッドにするか判別
            if (user.User_id != 0)
            {
                //USE_IDがあったら更新.
                return _database.UpdateAsync(user);
            }
            else
            {
                //なかったらuserインサート
                return _database.InsertAsync(user);
            }
        }

        //ユーザーテーブルの列を削除
        public Task<int> DeleteUserAsync(User user)
        {
            //user削除.
            return _database.DeleteAsync(user);
        }

        //薬テーブル関連
        //Medicineテーブルをリストにする
        public Task<List<Medicine>> GetMedicinesAsync()
        {
            return _database.Table<Medicine>().ToListAsync();
        }

        public Task<Medicine> GetMedicineAsync(int id)
        {
            return _database.Table<Medicine>().Where(i => i.Medicine_id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveMedicineAsync(Medicine medicine)
        {
            if(medicine.Medicine_id != 0)
            {
                return _database.UpdateAsync(medicine);
            }
            else
            {
                return _database.InsertAsync(medicine);
            }
        }

        //薬の服用テーブル
        public Task<List<TakeMedicine>> GetTakeMedicinesAysnc()
        {
            return _database.Table<TakeMedicine>().ToListAsync();
        }
        public Task<TakeMedicine> GetTakeMedicineAysnc(int id)
        {
            return _database.Table<TakeMedicine>().Where(i => i.Medicine_id == id).FirstOrDefaultAsync();
        }
        public Task<int> SaveTakeMedicineAsync(TakeMedicine takeMedicine)
        {
            if (takeMedicine.Medicine_id != 0)
            {
                return _database.UpdateAsync(takeMedicine);
            }
            else
            {
                return _database.InsertAsync(takeMedicine);
            }
        }
    }
}