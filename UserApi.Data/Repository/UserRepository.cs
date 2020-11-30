using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApi.Core.Dtos;
using UserApi.Core.Models;
using UserApi.Core.Repository;
using UserApi.Data.Context;

namespace UserApi.Data.Repository
{
    public class UserRepository : IUserRepository

    {
        private readonly DataContext dataContext;
        private readonly IMapper mapper;
        public UserRepository(DataContext _dataContext, IMapper _mapper)
        {
            dataContext = _dataContext;
            mapper = _mapper;
        }

        public async Task<(bool, string)> CreateAsync(UserClassDto UserClassDto)
        {
            try
            {
                var data = dataContext.userClasses.SingleOrDefault(x => x.Guid == UserClassDto.Guid);
                if (data != null)
                {
                    return (false, "Id already exist");
                }
                else
                {
                    var data1 = mapper.Map<UserClassDto>(data);
                    await dataContext.AddAsync(data1);
                    await dataContext.SaveChangesAsync();
                    return (true, "Successfully Created");
                }
           

                //{
                //    userData.Guid = new Guid();
                //    userData.FirstName = UserClassDto.FirstName;
                //    userData.LastName = UserClassDto.LastName;
                //    userData.Email = UserClassDto.Email;
                //    userData.IsActive = UserClassDto.IsActive;
                //    userData.IsDeleted = UserClassDto.IsDeleted;
                //    userData.Address = UserClassDto.Address;
                //    userData.Phone = UserClassDto.Phone;
                //    await dataContext.userClasses.AddRangeAsync(userData);
                //    await dataContext.SaveChangesAsync();
                //    return (true, "Successfully Created");
                //}
            }
            catch (Exception ex)
            {
                return (false, "Failed to Create");
            }


        }

     

        public async Task<(bool, string)> DeleteAsync(Guid guid)
        {
            try
            {
                var data = await dataContext.userClasses.FindAsync(guid);
                if (data == null)

                    return (false, "Id does not Exist");

                data.IsDeleted = true;
                dataContext.userClasses.Update(data);
                await dataContext.SaveChangesAsync();
                return (true, "Successfully Removed");

            }
            catch(Exception ex)
            {
                return (false, null);
            }

        }

        public async Task<List<UserClass>> GetAllAsync(Guid Id)
        {
            if (Id == Guid.Empty)
            {
                return null;
            }
            else
            {
                var data = await dataContext.userClasses.Where(x => x.Guid == Id && x.IsDeleted == false).ToListAsync();
               return  mapper.Map<List<UserClass>>(data);
                
              
            }
        }

        public async Task<UserClass> GetByIdAsync(Guid Id)
        {
            var data = await dataContext.userClasses.Where(x => x.Guid == Id && x.IsDeleted == false).SingleOrDefaultAsync();
            return data;
        }


        public async Task<(bool, string)> UpdateAsync(UserClassDto userClassDto)
        {
            var data = await dataContext.userClasses.Where(x => x.Guid == userClassDto.Guid).FirstOrDefaultAsync();
            if(data== null)
            {
                return (false, "Id Already Exist");
            }
            else
            {

                UserClass userClass = new UserClass();
                userClass.Guid = userClassDto.Guid;

                    
            }
        }
    }
}
