using FriendOrganizer.Model;
using System.Collections.Generic;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            // TODO: Load data from the real database
            yield return new Friend { FirstName = "Mike", LastName = "Belyayev" };
            yield return new Friend { FirstName = "Felix", LastName = "Belyayev" };
            yield return new Friend { FirstName = "Kate", LastName = "Belyayeva" };
            yield return new Friend { FirstName = "Daniel", LastName = "Belyayev" };
            yield return new Friend { FirstName = "Victoria", LastName = "Belyayeva" };
        }
    }
}
