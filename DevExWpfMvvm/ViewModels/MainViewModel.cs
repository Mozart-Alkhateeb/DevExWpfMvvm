using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace DevExWpfMvvm.ViewModels
{
    /*   public class MainViewModel : BindableBase
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
       }*/

    public class MainViewModel : ViewModelBase
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

        [Command]
        public void Save()
        {
            // Saved
        }

        public bool CanSave()
        {
            return !string.IsNullOrEmpty(FirstName);
        }
    }
}
