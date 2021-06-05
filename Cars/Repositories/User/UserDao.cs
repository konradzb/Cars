using Cars.Configuration;
using Cars.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Repositories
{
    public class UserDao : IUserDao
    {

        private readonly ApplicationDbContext _dbcontext;
        public UserDao(ApplicationDbContext db)
        {
            _dbcontext = db;
        }

        public User addUser(User user)
        {
            _dbcontext.Add(user);
            _dbcontext.SaveChanges();
            return user;
        }

        public User editUserById(User user)
        {
            _dbcontext.Update(user);
            _dbcontext.SaveChanges();
            return user;
        }

        public List<User> getAllUsers()
        {
            return _dbcontext.Information_Users.OrderBy(u => u.position).ToList();
        }

        public User getUserById(int id)
        {
            return _dbcontext.Information_Users.Where(u => u.id == id).FirstOrDefault();
        }

        public bool removeUserById(int id)
        {
            _dbcontext.Remove(id);
            _dbcontext.SaveChanges();
            if (getUserById(id) == null)
                return true;
            else
                return false;
        }

        public int usersLength()
        {
            return getAllUsers().Count;
        }
    }
}
