using System;
using GuestbookBirthdayParty.Core.Models;
using MvvmCross.Plugins.Sqlite;
using SQLite.Net;

namespace GuestbookBirthdayParty.Core.Services
{
    public class DataService : IDataService
    {
        private readonly SQLiteConnection _connection;

        public DataService(IMvxSqliteConnectionFactory factory)
        {
            var config = new SqLiteConfig("db");
            _connection = factory.GetConnection(config);
        }

        public void CreateDatabase()
        {
            _connection.CreateTable<Answer>();
        }

        public void Insert(Answer answer)
        {
            throw new NotImplementedException();
        }

        public void Update(Answer answer)
        {
            throw new NotImplementedException();
        }

        public void Delete(Answer answer)
        {
            throw new NotImplementedException();
        }

        public int Count { get; }
    }
}
