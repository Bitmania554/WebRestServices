using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRestServices
{
    [Produces("application/json")]
    [Route("api/users")]
    public class UserService : ControllerBase
    {
        private UsersBL usersBL;

        public UserService(UsersBL usersBL)
        {
            this.usersBL = usersBL;
        }

        public List<Users> ObtenerUsuarios()
        {
            List<Users> users = null;
            try
            {
                users = usersBL.getUserInfo();
            }
            catch(Exception ex)
            {

            }
            return users;
        }
    }
}
