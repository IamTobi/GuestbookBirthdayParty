using System.Collections.Generic;
using GuestbookBirthdayParty.Core.Models;
using GuestbookBirthdayParty.Core.Services;
using MvvmCross.Core.ViewModels;

namespace GuestbookBirthdayParty.Core.ViewModels
{
    public class StatsViewModel : MvxViewModel

    {
        private readonly IDataService _dataService;

        private List<Answer> _answerList;

        public StatsViewModel(IDataService dataService)
        {
            _dataService = dataService;
        }

        public List<Answer> AnswerList
        {
            get { return _answerList; }
            set
            {
                _answerList = value;
                RaisePropertyChanged(() => AnswerList);
            }
        }

        public void Init()
        {
            AnswerList = _dataService.GetAllTheAnswers();
        }
    }
}