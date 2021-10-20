using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3SA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(string usuario, string clave)
        {
            InitializeComponent();
            
            lblUsuario.Text = usuario;
            lblPassword.Text = clave;
            txtUsuario.Text = usuario;
            txtClave.Text = clave;
            
        }
    }
}