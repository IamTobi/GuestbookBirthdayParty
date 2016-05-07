using System.Collections.Generic;
using GuestbookBirthdayParty.Core.Models;
using GuestbookBirthdayParty.Core.Services;
using MvvmCross.Core.ViewModels;

namespace GuestbookBirthdayParty.Core.ViewModels
{
    public class FinishViewModel: MvxViewModel
    {
        private readonly IDataService _dataService;

        private List<Answer> _answerList;
        public List<Answer> AnswerList
        {
            get { return _answerList; }
            set { _answerList = value; RaisePropertyChanged(() => AnswerList); }
        }

        public FinishViewModel(IDataService dataService)
        {
            _dataService = dataService;
        }

        public void Init()
        {
            _dataService.InsertTheAnswer();
            AnswerList = _dataService.GetAllTheAnswers();
        }

        IMvxCommand _sendClickedCommand;
        public System.Windows.Input.ICommand SendClickedCommand
        {
            get
            {
                _sendClickedCommand = _sendClickedCommand ?? new MvxCommand(DoSendClickedCommand);
                return _sendClickedCommand;
            }
        }

        private void DoSendClickedCommand()
        {
            ShowViewModel<FirstViewModel>();
        }
        

    }
}
