using DevExpress.Mvvm;

namespace DevExWpfMvvm.ViewModels
{
    public class MainViewModel : BindableBase
    {

        public MainViewModel()
        {

        }

        public string FirstName
        {
            get { return GetValue<string>(); }
            set { SetValue(value, changedCallback: NotifyFullNameChanged); }
        }

        public string LastName
        {
            get { return GetValue<string>(); }
            set { SetValue(value, changedCallback: NotifyFullNameChanged); }
        }

        public string FullName { get { return FirstName + " " + LastName; } }

        void NotifyFullNameChanged()
        {
            RaisePropertyChanged(() => FullName);
        }

        void Save()
        {
            //Save Changes to database
        }
    }
}
