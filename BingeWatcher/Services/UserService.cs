using BingeWatcher.Core.Dtos;
using BingeWatcher.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BingeWatcher.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient httpClient = new HttpClient();

        public async Task<UserDto> LoginUser(UserDto userDto)
        {
            var userJson = Json.StringifyAsync(userDto);
            var content = new StringContent(userJson.ToString());
            var response =  await httpClient.PostAsync("todo", content);
            var responseContent = await response.Content.ReadAsStringAsync();
            return await Json.ToObjectAsync<UserDto>(responseContent).ConfigureAwait(false);
        }
    }
}
