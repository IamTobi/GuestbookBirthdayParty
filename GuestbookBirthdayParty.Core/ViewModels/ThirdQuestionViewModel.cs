using MvvmCross.Core.ViewModels;
using System.Diagnostics;
using GuestbookBirthdayParty.Core.Services;

namespace GuestbookBirthdayParty.Core.ViewModels
{
    public class ThirdQuestionViewModel: MvxViewModel
    {

        private IDataService _dataService;

        IMvxCommand _answerClickedCommand;

        public ThirdQuestionViewModel(IDataService dataService)
        {
            _dataService = dataService;
        }

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
           
            ShowViewModel<FinishViewModel>();
        }

        private void SaveChosenAnswer(string answer)
        {
            _dataService.UpdateTheAnswer(answer,3);
            Debug.WriteLine(answer);
        }

    }
}
