using ejercicio3.Controllers;
using ejercicio3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ejercicio3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void btnagregar_Clicked(object sender, EventArgs e)
        {
            

           var tarea = new Models.tareas2()
            {
               nombre = nombre.Text,
              apellido= apellido.Text,
                edad= int.Parse(edad.Text),
                correo = correo.Text,


            };
            int resultado = await App.Dbtarea.StoreEquipo(tarea);
           if(resultado > 0)
            {
               await DisplayAlert("respuesta", "se ingreso con exito", "ok");
               

            }
            

//            var pagina = new Views.Page1();
  //          pagina.BindingContext = tarea;
    //        await Navigation.PushAsync(pagina);
        }

        private  async void lista_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Lista());

        }

        private async void TERCERA_Clicked(object sender, EventArgs e)
        {
            var tarea = new Models.tarea()
            {
                nombre = nombre.Text,
                apellido = apellido.Text,
                edad = edad.Text,//int.Parse(edad.Text),
                correo = correo.Text,
              

            };
            var pagina = new Views.Page1();
                    pagina.BindingContext = tarea;
               await Navigation.PushAsync(pagina);
        }
    }
}
