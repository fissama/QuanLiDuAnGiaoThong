using QuanLiDuAnGiaoThong.Models;
using QuanLiDuAnGiaoThong.ViewModels;
using QuanLiDuAnGiaoThong.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuanLiDuAnGiaoThong.Views
{
    public partial class ItemsPage : ContentPage
    {
        LoiViPhamViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();
            
            BindingContext = _viewModel = new LoiViPhamViewModel();
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
           
        }
    }
}