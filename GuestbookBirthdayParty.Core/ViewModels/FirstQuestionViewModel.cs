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

        IMvxCommand _answerClickedCommand;
        public System.Windows.Input.ICommand AnswerClickedCommand
        {
            get
            {
                _answerClickedCommand = _answerClickedCommand ?? new MvxCommand<string>(DoAnswerClickedCommand);
                return _answerClickedCommand;
            }
        }

        private void DoAnswerClickedCommand(string chosenAnswer)
        {
            SaveChosenAnswer(chosenAnswer);
            ShowViewModel<FirstViewModel>();
        }

        private void SaveChosenAnswer(string answer)
        {

        }

    }
}
