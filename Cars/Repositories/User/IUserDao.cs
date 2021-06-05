using Cars.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Repositories
{
    public interface IUserDao
    {
        List<User> getAllUsers();
        User getUserById(int id);
        User addUser(User user); 
        bool removeUserById(int id);
        User editUserById(User user);
        int usersLength();

    }
}
