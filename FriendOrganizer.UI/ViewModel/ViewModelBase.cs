using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FriendOrganizer.UI.ViewModel
{

    public class ViewModelBase : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        // CallerMemberName retrieves the name of the caller automatically. No need for the caller to provide its "name".
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)   //string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

}