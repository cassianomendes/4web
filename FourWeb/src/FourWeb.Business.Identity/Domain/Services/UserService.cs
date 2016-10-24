using FourWeb.Abstraction.Domain.Entities;
using FourWeb.Abstraction.Domain.Services;
using FourWeb.Business.Identity.Domain.Repositories;
using FourWeb.Infrastructure.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourWeb.Business.Identity.Domain.Services
{
    public class UserService : CommandService<User>
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
            : base(userRepository)
        {
            _userRepository = userRepository;
        }
        
        public User GetByUsername(string userName)
        {
            return _userRepository.GetByUsername(userName);
        }

        public bool CheckPassword(User user, string password)
        {            
            var hash = StringHelper.Encrypt(password);
            return user.Password.Equals(hash);
        }
    }
}
