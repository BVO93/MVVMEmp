﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendOrganizer.Model;
using FriendOrganizer.UI.Data;

namespace FriendOrganizer.UI.ViewModel
{
   public class NavigationViewModel : INavigationViewModel
   {
        private readonly IFriendLookupDataService _friendLookupDataService;

        public NavigationViewModel(IFriendLookupDataService friendLookupDataService)
        {
            _friendLookupDataService = friendLookupDataService;
            Friends = new ObservableCollection<LookupItem>();
        }

        public async Task LoadAsync()
        {
            var lookup = await _friendLookupDataService.GetFriendsLookupAsync();
            Friends.Clear();
            foreach (var item in lookup)
            {
                Friends.Add(item);
            }
        }

        public ObservableCollection<LookupItem> Friends { get; }

    }
}