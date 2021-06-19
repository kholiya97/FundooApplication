using BusinessLayer.Interface;
using CommonLayer;
using RepositoryLayer;
using RepositoryLayer.Interface;
using System;
namespace BusinessLayer.Services
{
    public class UserBL : IUserBL
    {
    IUserRL userRl;

        public UserBL(IUserRL userRl)
        {
            this.userRl = userRl;
        }
        
        public Users AddUser(Users user)
        {
            this.userRl.AddUser(user);
            return user;
        }
    }
}
