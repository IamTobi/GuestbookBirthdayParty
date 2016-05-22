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
                case "ganz schlecht":
                case "schlecht":
                case "ok":
                    ShowViewModel<SecondQuestionViewModel>();
                    break;
                case "gut":
                    ShowViewModel<FourthQuestionViewModel>();
                    break;
                case "hammer!":
                    ShowViewModel<ThirdQuestionViewModel>();
                    break;
            }
        }

        private void SaveChosenAnswer(string answer)
        {
            
            _dataService.UpdateTheAnswer(answer,1);
        }

    }
}
