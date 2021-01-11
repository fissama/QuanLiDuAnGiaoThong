using QuanLiDuAnGiaoThong.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QuanLiDuAnGiaoThong.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ChiTietLoiViPhamViewModel : BaseViewModel
    {
        private string itemId;
        private string loivipham1;
        private decimal mucphat;
        private int diemtru;
        public string Id { get; set; }

        public string LoiViPham1
        {
            get => loivipham1;
            set => SetProperty(ref loivipham1, value);
        }

        public decimal MucPhat
        {
            get => mucphat;
            set => SetProperty(ref mucphat, value);
        }
        public int DiemTru
        {
            get => diemtru;
            set => SetProperty(ref diemtru, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                LoiViPham1 = item.LoiViPham1;
                MucPhat = item.MucPhat;
                DiemTru = item.DiemTru;

            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
