using FriendOrganizer.Model;
using System.Collections.Generic;

namespace FriendOrganizer.UI.Data
{
   public class FriendDataService : IFriendDataService
   {

        public IEnumerable<Friend> GetAll()
        {
            // Should be done from real database
            yield return new Friend { FirstName = "An", LastName = "Test" };
            yield return new Friend { FirstName = "Bert", LastName = "DeVlieger" };
            yield return new Friend { FirstName = "Cara", LastName = "Pils" };

        }

    }
}
