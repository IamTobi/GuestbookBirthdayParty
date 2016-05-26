using System.Runtime.InteropServices.ComTypes;
using System.Windows.Input;
using Android.Util;
using GuestbookBirthdayParty.Core.Services;
using MvvmCross.Core.ViewModels;

namespace GuestbookBirthdayParty.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private readonly IDataService _dataService;
        private int _countForStats;

        public FirstViewModel(IDataService dataService1)
        {
            _dataService = dataService1;
        }

        public void Init()
        {
            _dataService.InitTheAnswer();
            _countForStats = 0;
        }
        #region commands




        private MvxCommand _goFirstQuestionCommand;
        public ICommand GoFirstQuestionCommand
        {
            get
            {
                _goFirstQuestionCommand = _goFirstQuestionCommand ?? new MvxCommand(DoGoFirstQuestionCommand);
                return _goFirstQuestionCommand;
            }
        }


        private void DoGoFirstQuestionCommand()
        {
            ShowViewModel<FirstQuestionViewModel>();
        }

        private MvxCommand _goStatsCommand;
        public ICommand GoStatsCommand
        {
            get
            {
                _goStatsCommand = _goStatsCommand ?? new MvxCommand(DoGoStatsCommand);
                return _goStatsCommand;
            }
        }


        private void DoGoStatsCommand()
        {
            _countForStats++;
            if (_countForStats==4)
            {
                _countForStats = 0;
                ShowViewModel<StatsViewModel>();
            }
            
        }
        #endregion
        
    }
}