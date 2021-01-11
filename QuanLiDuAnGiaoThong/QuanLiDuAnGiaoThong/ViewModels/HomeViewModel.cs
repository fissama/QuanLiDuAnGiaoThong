using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace QuanLiDuAnGiaoThong.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            Title = "Trang chủ";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://google.com"));
        }

        public ICommand OpenWebCommand { get; }
    }
}