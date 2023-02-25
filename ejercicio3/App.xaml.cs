using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ejercicio3
{
    public partial class App : Application
    {
        static Controllers.DBtarea dbtarea;

        public static Controllers.DBtarea Dbtarea
        { 
            get
            {
                if (dbtarea == null)
                {
                    // var PathApp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    // var DBName = Models.Configuraciones.DBname;
                    //  var PathFull = Path.Combine(PathApp, DBName);
                    //  dbtarea = new Controllers.DBtarea(PathFull); 
                    dbtarea = new Controllers.DBtarea(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),Models.Configuraciones.DBname));
                }
                return dbtarea;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
