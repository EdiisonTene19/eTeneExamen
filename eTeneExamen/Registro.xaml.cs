using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eTeneExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
          
            InitializeComponent();
            lblUsuario.Text = usuario;
        }


        private  void btnCalcular_Clicked_1(object sender, EventArgs e)
        {

           double montoInicial = Convert.ToDouble(txtMontoInicial.Text);
            if (montoInicial < 4000) { 
                double pagoMensual = (4000 - montoInicial) / 5 + 5 % 4000;

            txtPagoMensual.Text = pagoMensual.ToString();
           

            }
            else
            {
                DisplayAlert("El valor minimo ingresado excede lo permitido", "Vuelva a ingresar el valor correctamente", "Salir");
                txtMontoInicial.Text = string.Empty;
            }

        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string usuario = lblUsuario.Text;
            string nombre =txtNombre.Text;
            string total = txtPagoMensual.Text;
            Navigation.PushAsync(new Resumen(usuario, nombre, total));
        }
    }
}