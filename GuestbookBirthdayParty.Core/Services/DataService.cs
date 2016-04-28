using System.Collections.Generic;
using System.Linq;
using GuestbookBirthdayParty.Core.Models;
using MvvmCross.Plugins.Sqlite;
using SQLite.Net;

namespace GuestbookBirthdayParty.Core.Services
{
    public class DataService : IDataService
    {
        private readonly SQLiteConnection _connection;

        public DataService( IMvxSqliteConnectionFactory sqliteConnectionFactory)
        {
            _connection = sqliteConnectionFactory.GetConnection("data.dat");
            _connection.CreateTable<Answer>();
        }
        
        public List<Answer> GetAllTheAnswers()
        {
            return _connection.Table<Answer>().ToList();
        }

        public void Insert(Answer answer)
        {
            _connection.Insert(answer);
        }

        public void Update(Answer answer)
        {
            _connection.Update(answer);
        }

        public void Delete(Answer answer)
        {
            _connection.Delete(answer);
        }

        public int Count { get; }
    }
}
