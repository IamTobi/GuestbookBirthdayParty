using SQLite.Net.Attributes;

namespace GuestbookBirthdayParty.Core.Models
{
    [Table("Answer")]
    public class Answer
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string FirstAnswer { get; set; }
        public string NegativeAnswer { get; set; }
        public string PositiveAnswer { get; set; }
        public string AnswerForNumber4 { get; set; }
        public string TextForUs { get; set; }
        public string PathToImage { get; set; }

        public override string ToString()
        {
            return
                $"{FirstAnswer} | {NegativeAnswer} | {PositiveAnswer} | {AnswerForNumber4}  | {TextForUs} | {PathToImage}";
        }
    }
}
