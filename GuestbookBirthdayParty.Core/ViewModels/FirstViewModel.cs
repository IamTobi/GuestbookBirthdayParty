using System.Windows.Input;
using GuestbookBirthdayParty.Core.Services;
using MvvmCross.Core.ViewModels;

namespace GuestbookBirthdayParty.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private IDataService _dataService;

        public FirstViewModel(IDataService dataService1)
        {
            _dataService = dataService1;
        }

        public void Init()
        {
            _dataService.InitTheAnswer();
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
        #endregion
        
    }
}