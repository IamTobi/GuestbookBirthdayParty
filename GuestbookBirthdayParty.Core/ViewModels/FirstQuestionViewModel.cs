using MvvmCross.Core.ViewModels;
using System.Diagnostics;
using GuestbookBirthdayParty.Core.Models;
using GuestbookBirthdayParty.Core.Services;

namespace GuestbookBirthdayParty.Core.ViewModels
{
    public class FirstQuestionViewModel: MvxViewModel
    {
        private readonly IDataService _dataService;

       

        public FirstQuestionViewModel(IDataService dataService)
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
            switch (chosenAnswer)
            {
                case "first":
                case "second":
                case "third":
                    ShowViewModel<SecondQuestionViewModel>();
                    break;
                case "fourth":

                    break;
                case "fifth":
                    break;
            }
        }

        private void SaveChosenAnswer(string answer)
        {
            
            _dataService.UpdateTheAnswer(answer,1);
        }

    }
}
