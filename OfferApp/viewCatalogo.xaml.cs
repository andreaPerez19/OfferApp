using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OfferApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class viewCatalogo : ContentPage
    {
        private const string Url = "http://192.168.100.245/offerApp/postEmpresa.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<OfferApp.DatosEmpresa> _post;
        public viewCatalogo()
        {
            InitializeComponent();
            get();
        }

        private async void get()
        {
            var content = await client.GetStringAsync(Url);
            List<OfferApp.DatosEmpresa> post = JsonConvert.DeserializeObject<List<OfferApp.DatosEmpresa>>(content);
            _post = new ObservableCollection<OfferApp.DatosEmpresa>(post);

            MyListView.ItemsSource = _post;

        }
    }
}