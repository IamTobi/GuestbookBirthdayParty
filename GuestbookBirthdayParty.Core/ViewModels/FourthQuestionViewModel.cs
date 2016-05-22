using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestbookBirthdayParty.Core.Services;
using MvvmCross.Core.ViewModels;

namespace GuestbookBirthdayParty.Core.ViewModels
{
    public class FourthQuestionViewModel:MvxViewModel
    {

        private readonly IDataService _dataService;

        public FourthQuestionViewModel(IDataService dataService)
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
            _dataService.UpdateTheAnswer(answer, 4);
        }
    }
}
