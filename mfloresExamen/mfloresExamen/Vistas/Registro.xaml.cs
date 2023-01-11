using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using mfloresExamen.Vistas;

namespace mfloresExamen.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        double pago_mensual = 0;
        double curso = 4000;
        double total = 0;
        double monto_inicial = 0;


        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text= usuario;
           
        }

        private void btnPagoMensual_Clicked(object sender, EventArgs e)
        {
            
          
            monto_inicial = Convert.ToDouble(txtMontoInicial.Text);
            

            pago_mensual = ((curso - monto_inicial) / 5) + (4000 * 0.05);

            txtPagoMensual.Text = pago_mensual.ToString();


        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            total = (pago_mensual * 5) + monto_inicial;
            string nombre = txtNombre.Text;

            DisplayAlert("Notificación", "Elemento guardado con exito", "ok");
            Navigation.PushAsync(new Resumen(lblUsuario.Text, nombre, total));

        }

        private void txtMontoInicial_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato = Convert.ToDouble(txtMontoInicial.Text);

                if (dato >= curso)
                {
                    DisplayAlert("Validación", "Íngrese Cantidad Mayor a 0 y Menor a 4000", "cerrar");
                    txtMontoInicial.Text = "".ToString();
                } else if (dato < 0) {
                    DisplayAlert("Validación", "Íngrese Cantidad Mayor a 0 y Menor a 4000", "cerrar");
                    txtMontoInicial.Text = "".ToString();
                }



            }
            catch
            {

            }
        }
    }
}