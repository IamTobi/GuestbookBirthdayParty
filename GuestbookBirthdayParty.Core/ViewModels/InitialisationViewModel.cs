using MvvmCross.Core.ViewModels;

namespace GuestbookBirthdayParty.Core.ViewModels
{
    public class InitialisationViewModel 
        : MvxViewModel
    {
        private string _hello = "Hello MvvmCross";
        public string Hello
        { 
            get { return _hello; }
            set { SetProperty (ref _hello, value); }
        }

        MvxCommand _firstQ_ClickCommand;
        public System.Windows.Input.ICommand FirstQ_ClickCommand
        {
            get
            {
                _firstQ_ClickCommand = _firstQ_ClickCommand ?? new MvxCommand(DoFirstQ_ClickCommand);
                return _firstQ_ClickCommand;
            }
        }

        private void DoFirstQ_ClickCommand()
        {
            ShowViewModel<FirstQViewModel>();
        }

    }
}
