using Job.Data.DAO;
using Job.Data.IDAO;
using Job.Data.Models.Domain;
using Job.Data.Repository;
using Job.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Services.Service
{
    public class UserService : IUserService
    {
        private IUserDAO userDAO;

        public UserService()
        {
            userDAO = new UserDAO();
        }

        //public User GetUser(string userId)
        //{
        //    using(var context = new JobContext())
        //    {
        //        return userDAO.GetUser(context, userId);
        //    }
        //}
    }
}
