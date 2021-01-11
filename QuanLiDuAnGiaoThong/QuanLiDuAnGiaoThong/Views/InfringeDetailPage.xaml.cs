using QuanLiDuAnGiaoThong.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace QuanLiDuAnGiaoThong.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ChiTietLoiViPhamViewModel();
        }
    }
}