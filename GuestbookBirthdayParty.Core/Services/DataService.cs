using System;
using System.Collections.Generic;
using System.Linq;
using GuestbookBirthdayParty.Core.Models;
using MvvmCross.Plugins.Sqlite;
using SQLite.Net;

namespace GuestbookBirthdayParty.Core.Services
{
    public class DataService : IDataService
    {
        #region Properties
        private readonly SQLiteConnection _connection;

        private Answer WhatThePeopleSaid;

        #endregion


        public DataService( IMvxSqliteConnectionFactory sqliteConnectionFactory)
        {
            
            _connection = sqliteConnectionFactory.GetConnection("data.dat");
            _connection.CreateTable<Answer>();
        }

        public void InitTheAnswer()
        {
            WhatThePeopleSaid= new Answer();
        }

        public void UpdateTheAnswer(string answer,int questionNumber)
        {
            switch (questionNumber)
            {
                case 1:
                    WhatThePeopleSaid.Answer1 = answer;
                    break;
                case 2:
                    WhatThePeopleSaid.Answer2 = answer;
                    break;
                case 3:
                    WhatThePeopleSaid.Answer3 = answer;
                    break;
                case 4:
                    WhatThePeopleSaid.Answer4 = answer;
                    break;
            }
        }

        public List<Answer> GetAllTheAnswers()
        {
            return _connection.Table<Answer>().ToList();
        }
        

        public void InsertTheAnswer()
        {
            _connection.Insert(WhatThePeopleSaid);
        }
        

        public int Count { get; }
    }
}
