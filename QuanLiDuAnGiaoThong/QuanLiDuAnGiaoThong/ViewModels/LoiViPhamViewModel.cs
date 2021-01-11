using QuanLiDuAnGiaoThong.Models;
using QuanLiDuAnGiaoThong.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QuanLiDuAnGiaoThong.ViewModels
{
    public class LoiViPhamViewModel : BaseViewModel
    {
        private LoiViPhams _selectedItem;

        public ObservableCollection<LoiViPhams> LoiViPham { get; }
        public Command LoadItemsCommand { get; }
        public Command<LoiViPhams> ItemTapped { get; }

        public LoiViPhamViewModel()
        {
            Title = "Lịch sử vi phạm";
            LoiViPham = new ObservableCollection<LoiViPhams>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            ItemTapped = new Command<LoiViPhams>(OnItemSelected);
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                LoiViPham.Clear();
                var items = await DataStore.GetItemsAsync(true);

                foreach (var item in items)
                { 
                    LoiViPham.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        public LoiViPhams SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

        async void OnItemSelected(LoiViPhams item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ChiTietLoiViPhamViewModel.ItemId)}={item.Id}");
        }
    }
}