using System.Collections.Generic;
using Android.Accounts;
using GuestbookBirthdayParty.Core.Models;

namespace GuestbookBirthdayParty.Core.Services
{
    public interface IDataService
    {
        void InitTheAnswer();
        void UpdateTheAnswer(string answer,int questionNumber);
        void InsertTheAnswer();
        List<Answer> GetAllTheAnswers(); 
        int Count { get; }
    }
}
