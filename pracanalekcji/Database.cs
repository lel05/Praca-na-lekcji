using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace pracanalekcji
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<User>().Wait();
            _database.CreateTableAsync<Score>().Wait();
            _database.CreateTableAsync<Subject>().Wait();
        }

        public Task<int> InsertUser(User user)
        {
            return _database.InsertAsync(user);
        }
        public Task<List<User>> GetUsers()
        {
            return _database.QueryAsync<User>("SELECT * FROM User");
        }
        public Task<List<User>> GetUsersFilter(string login, string password)
        {
            return _database.QueryAsync<User>("SELECT * FROM User WHERE Login=? AND Password?", login, password);
        }
        public Task<List<Subject>> GetSubjects()
        {
            return _database.QueryAsync<Subject>("SELECT * FROM Subject");
        }
        public Task<List<Score>> GetScories()
        {
            return _database.QueryAsync<Score>("SELECT * FROM Score");
        }
        public Task<int> InsertSubject(Subject subject)
        {
            return _database.InsertAsync(subject);
        }
        public Task<int> InsertScore(Score score)
        {
            return _database.InsertAsync(score);
        }

    }
}
