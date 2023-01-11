using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mfloresExamen.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, double total)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            txtNombreR.Text= nombre;
            txtTotal.Text = total.ToString();
        }

        private void btnInformacion_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Acerca De", "Maycol Vinicio Flores Flores", "Ok");


        }
    }
}