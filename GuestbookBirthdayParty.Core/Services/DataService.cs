using System.Collections.Generic;
using System.Linq;
using GuestbookBirthdayParty.Core.Models;
using MvvmCross.Plugins.Sqlite;
using SQLite.Net;

namespace GuestbookBirthdayParty.Core.Services
{
    public class DataService : IDataService
    {
        public DataService(IMvxSqliteConnectionFactory sqliteConnectionFactory)
        {
            _connection = sqliteConnectionFactory.GetConnection("final.dat");
            _connection.CreateTable<Answer>();
        }

        public void InitTheAnswer()
        {
            _whatThePeopleSaid = new Answer();
        }

        public void UpdateTheAnswer(string answer, int questionNumber)
        {
            switch (questionNumber)
            {
                case 1:
                    _whatThePeopleSaid.FirstAnswer = answer;
                    break;
                case 2:
                    _whatThePeopleSaid.NegativeAnswer = answer;
                    break;
                case 3:
                    _whatThePeopleSaid.PositiveAnswer = answer;
                    break;
                case 4:
                    _whatThePeopleSaid.AnswerForNumber4 = answer;
                    break;
                case 5:
                    _whatThePeopleSaid.PathToImage = answer;
                    break;
                case 6:
                    _whatThePeopleSaid.TextForUs = answer;
                    break;
            }
        }

        public List<Answer> GetAllTheAnswers()
        {
            return _connection.Table<Answer>().ToList();
        }


        public void InsertTheAnswer()
        {
            _connection.Insert(_whatThePeopleSaid);
        }


        public int Count { get; }

        #region Properties

        private readonly SQLiteConnection _connection;

        private Answer _whatThePeopleSaid;

        #endregion
    }
}