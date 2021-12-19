using FriendOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            yield return new Friend { FirstName = "Mike", LastName = "Belyayev" };
            yield return new Friend { FirstName = "Felix", LastName = "Belyayev" };
            yield return new Friend { FirstName = "Kate", LastName = "Belyayeva" };
            yield return new Friend { FirstName = "Daniel", LastName = "Belyayev" };
            yield return new Friend { FirstName = "Victoria", LastName = "Belyayeva" };
        }
    }
}
