using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppJSON
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaProductos : ContentPage
    {
        public ListaProductos()
        {
            InitializeComponent();
            llenarLista();

        }

        public async void llenarLista()
        {
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri("http://php-poisad3644396.codeanyapp.com/ultimatum.php");
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accept", "application/json");
            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<Productos>>(content);

                ListProductos.ItemsSource = result;

            }
        }

        private async void ListProductos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var itemData = e.Item as Productos;
            Console.WriteLine(" precio: " + itemData.pro_preciou);
            //App.Current.MainPage.DisplayAlert("Message", "tapped item data: " + itemData.pro_preciou, "OK");

            await Navigation.PushAsync(new Detalle(itemData));

        }
    }
}