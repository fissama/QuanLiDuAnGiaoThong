using QuanLiDuAnGiaoThong.Services;
using QuanLiDuAnGiaoThong.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuanLiDuAnGiaoThong
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<LoiViPhamService>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
