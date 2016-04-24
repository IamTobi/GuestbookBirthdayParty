using Chance.MvvmCross.Plugins.UserInteraction;
using Cirrious.CrossCore;
using MvvmCross.Core.ViewModels;
using System.Diagnostics;

namespace GuestbookBirthdayParty.Core.ViewModels
{
    public class SecondQuestionViewModel: MvxViewModel
    {
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
            ShowViewModel<ThirdQuestionViewModel>();
        }

        private void SaveChosenAnswer(string answer)
        {
            Debug.WriteLine(answer);
        }

    }
}
