using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;

namespace QuanLiDuAnGiaoThong.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void OnImageThongTinCaNhanTapped(object sender, EventArgs e)
        {
            try
            {
                //Code to execute on tapped event
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void OnImageLichSuViPhamTapped(object sender, EventArgs e)
        {
            
            try
            {
                

                
                Shell.Current.Items.FirstOrDefault().Items.Add(new ShellContent { ContentTemplate = new DataTemplate(typeof(ItemsPage)) });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}