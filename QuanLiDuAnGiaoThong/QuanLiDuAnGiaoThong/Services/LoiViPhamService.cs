using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using QuanLiDuAnGiaoThong.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Diagnostics;
using System.Linq;
using Xamarin.Forms;

namespace QuanLiDuAnGiaoThong.Services
{
    public class LoiViPhamService : IDataLoiViPham<LoiViPhams>
    {
        private string uri = "http://172.28.160.1/api/LoiViPham";
        readonly List<LoiViPhams> items;

        public LoiViPhamService()
        {
            items = new List<LoiViPhams>();
            ExecuteLoadLoiViPhamApiCommand();
        }

        public async void ExecuteLoadLoiViPhamApiCommand()
        {
            try
            {
                var client = new HttpClient();
                var response = await client.GetAsync(uri);
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<LoiViPhams>>(content);
                foreach(var el in result)
                {
                    items.Add(el);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("\tERROR {0}", ex.Message);
            }

        }

        public async Task<bool> AddItemAsync(LoiViPhams item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((LoiViPhams arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<LoiViPhams> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<LoiViPhams>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items); ;
        }

        public async Task<bool> UpdateItemAsync(LoiViPhams item)
        {
            var oldItem = items.Where((LoiViPhams arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }
    }
}
