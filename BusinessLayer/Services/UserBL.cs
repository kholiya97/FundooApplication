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
        public bool SampleUserApi(Users user)
        {
            try
            {
                return this.userRl.SampleUserApi(user);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public Users AddUser(Users user)
        {
            this.userRl.AddUser(user);
            return user;
        }
    }
}
