using Dapper;
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
    public class UserDAL : BaseConnections
    {
      public List<Users> get()
        {
            string Query = "select * from Users";
            List<Users> usuarios = SqlMapper.Query<Users>(GetOpenConnection(), Query).ToList();
            return usuarios;
        }
    }
}
