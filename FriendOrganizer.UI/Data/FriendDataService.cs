using FriendOrganizer.Model;
using System.Collections.Generic;
using System.Linq;
using FriendOrganizer.DataAccess;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
   public class FriendDataService : IFriendDataService
   {
        private Func<FriendOrganizerDbContext> _contextCreator;

        // We make a func so autofac can just import the correct context
        public FriendDataService(Func<FriendOrganizerDbContext> contextCreator)
       {
           _contextCreator = contextCreator;
       }


        public async Task<Friend> GetByIdAsync(int friendId)
        {
            using (var ctx = _contextCreator())  //new FriendOrganizerDbContext())
            {
                return await ctx.Friends.AsNoTracking().SingleAsync(f => f.Id == friendId);
            }


            // Should be done from real database
         //   yield return new Friend { FirstName = "An", LastName = "Test" };
          //  yield return new Friend { FirstName = "Bert", LastName = "DeVlieger" };
           // yield return new Friend { FirstName = "Cara", LastName = "Pils" };

        }

    }
}
