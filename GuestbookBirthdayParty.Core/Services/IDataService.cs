using System.Collections.Generic;
using GuestbookBirthdayParty.Core.Models;

namespace GuestbookBirthdayParty.Core.Services
{
    public interface IDataService 
    {
        List<Answer> GetAllTheAnswers(); 
        void Insert(Answer answer);
        void Update(Answer answer);
        void Delete(Answer answer);
        int Count { get; }
    }
}
