using CommonLayer;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Services
{
    public class UserRL : IUserRL
    {
       
        private UserContext _userDbContext;
        public UserRL(UserContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        public Users AddUser(Users newuser)
        {
            _userDbContext.Users.Add(newuser);
            _userDbContext.SaveChanges();
            return newuser;
        }
    }
}
