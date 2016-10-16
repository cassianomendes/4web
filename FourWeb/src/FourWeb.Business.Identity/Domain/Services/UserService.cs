using FourWeb.Abstraction.Domain.Entities;
using FourWeb.Abstraction.Domain.Services;
using FourWeb.Business.Identity.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Identity.Domain.Services
{
    public class UserService : CommandService<User>
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
            : base(userRepository)
        {

        }
    }
}
