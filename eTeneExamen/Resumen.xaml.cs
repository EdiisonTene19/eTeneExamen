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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, string total)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            lblNombre.Text = nombre;
            lblTotal.Text = total;
            
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Este proyecto fue realizado por:", "Edison Tene 2023", "Salir");
        }
    }
}