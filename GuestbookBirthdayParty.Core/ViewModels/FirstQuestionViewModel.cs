using MvvmCross.Core.ViewModels;

namespace GuestbookBirthdayParty.Core.ViewModels
{
    public class FirstQuestionViewModel: MvxViewModel
    {
        private string _answerChosen;
        public string AnswerChosen
        {
            get { return _answerChosen; }
            set { _answerChosen = value; RaisePropertyChanged(() => AnswerChosen); }
        }

    }
}
