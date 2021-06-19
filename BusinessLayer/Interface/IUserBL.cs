using CommonLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    
    public interface IUserBL
    {

        bool SampleUserApi(Users user);
        Users AddUser(Users user);
    }
}
