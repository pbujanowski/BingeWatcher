using BingeWatcher.Core.Dtos;
using BingeWatcher.Core.Helpers;
using BingeWatcher.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BingeWatcher.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private readonly UserDto userDto = new UserDto();
        private readonly IUserService userService = new UserService();

        public string UserName
        {
            get { return userDto.UserName; }
            set
            {
                userDto.UserName = value;
                RaisePropertyChanged(nameof(UserName));
            }
        }

        public string Password
        {
            get { return userDto.Password; }
            set
            {
                userDto.Password = value;
                RaisePropertyChanged(nameof(Password));
            }
        }

        public ICommand AcceptLogin { get; set; }

        public ICommand CancelLogin { get; set; }

        public LoginViewModel()
        {
            AcceptLogin = new RelayCommand(AcceptLoginExecute);
            CancelLogin = new RelayCommand(CancelLoginExecute);
        }

        private async void AcceptLoginExecute()
        {
            var user = await userService.LoginUser(userDto).ConfigureAwait(false);
        }

        private void CancelLoginExecute()
        {
        }
    }
}
