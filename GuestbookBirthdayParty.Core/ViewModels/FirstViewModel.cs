using System.Windows.Input;
using GuestbookBirthdayParty.Core.Services;
using MvvmCross.Core.ViewModels;

namespace GuestbookBirthdayParty.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        #region services

        protected readonly IDataService DataService;

        #endregion

        #region init

        public FirstViewModel(IDataService dataService)
        {
            DataService = dataService;
        }

        public void Init()
        {
            DataService.CreateDatabase();
        }
        #endregion


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