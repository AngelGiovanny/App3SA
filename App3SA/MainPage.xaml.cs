using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3SA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //Constructor de prueba
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            try
            {
                //almacenando en variables loque usuario ingresa
                string usuario = txtUsuario.Text;
                string password = txtClave.Text;

                //permite abrir la ventana (viewdos)
                await Navigation.PushAsync(new Page1(usuario,password));
            }
            catch (Exception ex)
            {

                await DisplayAlert("Alerta de error", ex.Message , "OK");
            }

        }
    }
}
