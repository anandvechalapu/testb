<code>using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sac.Service
{
    public class UserService
    {
        public void AddUser(string username, string password)
        {
            //Stored procedure to add user to database
        }

        public void DeleteUser(string username)
        {
            //Stored procedure to delete user from database
        }
    }
}

</code>
<code>using sac.DTO;

namespace sac.Service
{
    public interface IUserService
    {
        void AddUser(User user);
        void DeleteUser(string username);
    }
}
</code>
