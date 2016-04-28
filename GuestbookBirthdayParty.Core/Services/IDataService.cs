using GuestbookBirthdayParty.Core.Models;

namespace GuestbookBirthdayParty.Core.Services
{
    public interface IDataService
    {
        void CreateDatabase();
        void Insert(Answer answer);
        void Update(Answer answer);
        void Delete(Answer answer);
        int Count { get; }
    }
}
