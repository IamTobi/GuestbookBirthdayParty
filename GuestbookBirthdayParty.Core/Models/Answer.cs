using SQLite.Net.Attributes;

namespace GuestbookBirthdayParty.Core.Models
{
    public class Answer
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Text { get; set; }
        public string PathToImage { get; set; }
    }
}
