using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeNetwork.Models.Users
{
    public class Friend
    {
       public int Id { get; set; }
       public string UserId { get; set; }
       public User User { get; set; }

        public string CurrentFriendId { get; set; }

        public User CurrentFriend { get; set; }
    }
}
