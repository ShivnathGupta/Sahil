using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserApi.Core.Models;

namespace UserApi.Core.Service
{
   public interface IUserServiceRepository
    {
        Task<UserClass> GetByIdAsync();
        Task<List<(bool, string)>> GetAllAsync();
        Task<(bool, string)> CreateAsync(UserClass userClass);

        Task<(bool, string)> UpdateAsync(UserClass userClass);

        Task<(bool, string)> DeleteAsync(Guid guid);
    }
}
