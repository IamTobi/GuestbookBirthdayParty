using System.Collections.Generic;
using GuestbookBirthdayParty.Core.Models;
using GuestbookBirthdayParty.Core.Services;
using MvvmCross.Core.ViewModels;

namespace GuestbookBirthdayParty.Core.ViewModels
{
    public class FinishViewModel: MvxViewModel
    {
        private readonly IDataService _dataService;

        private string _pathToImage="";

        private List<Answer> _answerList;
        public List<Answer> AnswerList
        {
            get { return _answerList; }
            set { _answerList = value; RaisePropertyChanged(() => AnswerList); }
        }

        private string _textForUs;
        public string TextForUs
        {
            get { return _textForUs; }
            set { _textForUs = value; RaisePropertyChanged(() => TextForUs); }
        }


        public FinishViewModel(IDataService dataService)
        {
            _dataService = dataService;
        }

        public void Init()
        {
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
            _dataService.UpdateTheAnswer(TextForUs, 6);
            _dataService.UpdateTheAnswer(_pathToImage, 5);
            _dataService.InsertTheAnswer();
            ShowViewModel<FirstViewModel>();
        }

        public void SetPathToImage(string pathToImage)
        {
            _pathToImage = pathToImage;
        }
        

    }
}
