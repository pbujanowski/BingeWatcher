using BingeWatcher.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BingeWatcher.Services
{
    public interface IUserService
    {
        Task<UserDto> LoginUser(UserDto userDto);
    }
}
