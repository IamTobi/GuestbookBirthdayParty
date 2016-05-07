using SQLite.Net.Attributes;

namespace GuestbookBirthdayParty.Core.Models
{
    [Table("Answer")]
    public class Answer
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string Text { get; set; }
        public string PathToImage { get; set; }

        public override string ToString()
        {
            return $"{Answer1} | {Answer2} | {Answer3}";
        }
    }
}
