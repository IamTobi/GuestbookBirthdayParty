using MvvmCross.Core.ViewModels;

namespace GuestbookBirthdayParty.Core.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {

        MvxCommand _goFirstQuestionCommand;
        public System.Windows.Input.ICommand GoFirstQuestionCommand
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
    }
}
