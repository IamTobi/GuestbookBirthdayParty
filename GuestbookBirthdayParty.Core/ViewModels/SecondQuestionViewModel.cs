using MvvmCross.Core.ViewModels;
using GuestbookBirthdayParty.Core.Services;

namespace GuestbookBirthdayParty.Core.ViewModels
{
    public class SecondQuestionViewModel: MvxViewModel
    {
        private IDataService _dataService;

        public SecondQuestionViewModel(IDataService dataService)
        {
            _dataService = dataService;
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
            ShowViewModel<FinishViewModel>();
        }

        private void SaveChosenAnswer(string answer)
        {
            _dataService.UpdateTheAnswer(answer,2);
            
        }

    }
}
