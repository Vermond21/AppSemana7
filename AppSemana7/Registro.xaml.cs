using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppSemana7.Models;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSemana7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        private SQLiteAsyncConnection con;
        public Registro()
        {
            InitializeComponent();
            con = DependencyService.Get<DataBase>().GetConnection();
        }

        private void bntAgregar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var Registros = new Estudiante { Nombre = txtNombre.Text, Usuario = txtUsuario.Text, Contrasenia = txtContrasenia.Text };
                con.InsertAsync(Registros);
                DisplayAlert("Alerta", "Dato ingresado", "ok");
                txtNombre.Text = "";
                txtContrasenia.Text = "";
                txtUsuario.Text = "";
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "ok");
            }
        }
    }
}