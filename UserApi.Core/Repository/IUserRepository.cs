using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserApi.Core.Dtos;
using UserApi.Core.Models;

namespace UserApi.Core.Repository
{
   public interface IUserRepository
    {
        Task<UserClass> GetByIdAsync(Guid Id);
        Task<List<UserClass>> GetAllAsync(Guid Id);
        Task<(bool, string)> CreateAsync(UserClassDto userClassDto);

        Task<(bool, string)> UpdateAsync(UserClassDto userClassDto);

        Task<(bool, string)> DeleteAsync(Guid guid);
    }
}
