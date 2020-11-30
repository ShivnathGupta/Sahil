using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserApi.Core.Models;
using UserApi.Core.Repository;
using UserApi.Core.Service;

namespace UserApi.Service.Service
{
    public class UserServiceRepository : IUserServiceRepository
    {
        private readonly IUserRepository userRepository;
        public UserServiceRepository(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }


        public async Task<(bool, string)> CreateAsync(UserClass userClass)
        {
            throw new NotImplementedException();
        }

        public Task<(bool, string)> DeleteAsync(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Task<List<(bool, string)>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserClass> GetByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task<(bool, string)> UpdateAsync(UserClass userClass)
        {
            throw new NotImplementedException();
        }
    }
}
