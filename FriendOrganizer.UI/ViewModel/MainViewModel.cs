using System.Collections.ObjectModel;
using System.Security.AccessControl;
using System.Threading.Tasks;
using FriendOrganizer.Model;
using FriendOrganizer.UI.Data;

namespace FriendOrganizer.UI.ViewModel
{
    public partial class MainViewModel : ViewModelBase
    {
        private  IFriendDataService _friendDataService;
        private Friend _selectedFriend;

        public MainViewModel(IFriendDataService friendDataService)
        {
            Friends = new ObservableCollection<Friend>();
            _friendDataService = friendDataService;
        }

        public async Task LoadAsync()
        {
            var friends = await _friendDataService.GetAllAsync();
            Friends.Clear();
            foreach (var friend in friends)
            {
                Friends.Add(friend);
            }
        }

        public ObservableCollection<Friend> Friends { get; set; }
  


        public Friend SelectedFriend
        {
            get { return _selectedFriend;  }
            set
            {
                _selectedFriend = value;
                OnPropertyChanged();
                // Callermembername excludes the need to provide selectedFriend name. OnPropertyChanged(nameof(SelectedFriend));
                // // From C# 6.0 no need to provide real name.Nameof also works "SelectedFriend");
            }
        }
    }
}
