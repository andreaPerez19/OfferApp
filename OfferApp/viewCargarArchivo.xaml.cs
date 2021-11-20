using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OfferApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class viewCargarArchivo : ContentPage
    {
        public viewCargarArchivo()
        {
            InitializeComponent();
        }

        private async void btnTomarFoto_Clicked(object sender, EventArgs e)
        {
           
        }

        private void btnSeleccionarFoto_Clicked(object sender, EventArgs e)
        {

        }
    }
}