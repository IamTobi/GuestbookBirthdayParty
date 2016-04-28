using MvvmCross.Core.ViewModels;

namespace GuestbookBirthdayParty.Core.ViewModels
{
    public class FinishViewModel: MvxViewModel
    {
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
