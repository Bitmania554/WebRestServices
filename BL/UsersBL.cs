using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRestServices
{
    public class UsersBL
    {
        private UserDAL userDAL;

        public UsersBL(UserDAL userDAL)
        {
            this.userDAL = userDAL;
        }

        public List<Users> getUserInfo()
        {
            List<Users> users = userDAL.get();
            return users;
        }
    }
}
