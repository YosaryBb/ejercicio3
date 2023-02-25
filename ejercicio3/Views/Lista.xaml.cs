using ejercicio3.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ejercicio3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lista : ContentPage
    {
        public Lista()
        {
            InitializeComponent();
        }

        private void txtLista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var elemento = e.CurrentSelection.FirstOrDefault() as Models.tareas2;//nos quedamos en video 31 vamos al 32
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            txtLista.ItemsSource = await App.Dbtarea.Listatarea2();
        }

        private async void Insertar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void ACTUAALIZAR_Clicked(object sender, EventArgs e)
        {
            string opcion = await DisplayActionSheet("Seleccione si desea eliminar o editar el registro", "Cancelar", null, "Eliminar", "Editar");

            switch (opcion)
            {
                case "Editar":
                // tarea persona = (tarea)e.CurrentSelection.FirstOrDefault();
                //  var editarInfo = new Editar();
                //  editarInfo.BindingContext = persona;
                //   await Navigation.PushAsync(editarInfo);
                //   break;

                case "Eliminar":
                //persona = (tarea)e.CurrentSelection.FirstOrDefault();
                //  int res = await App.Dbtarea.borrarPersona(persona);
                //  if (res != 0) mensaje("Aviso", "El empleado se a eliminado exitosamente");
                //  else mensaje("Error", "A ocurrido un error al eliminar al empleado");
                //  txtLista.ItemsSource = await App.Dbtarea.Listatarea2();
                ////  break;

                default:
                    break;
            }
        }
    }
}