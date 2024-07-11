
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LayoutExamples.Models
{
    class MyPhotos
    {
        public List<string> Photos { get; set; }=new List<string>();

        public static async Task<List<string>> CreateMyPhotos() 
        {
            MyPhotos p= new MyPhotos();
            using (HttpClient client = new HttpClient())
            {
                p = await client.GetFromJsonAsync<MyPhotos>("https://raw.githubusercontent.com/xamarin/docs-archive/master/Images/stock/small/stock.json");
            };
            return p.Photos;
            
        }
    }
}
