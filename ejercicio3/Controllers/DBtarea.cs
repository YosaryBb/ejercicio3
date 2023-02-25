using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;



namespace ejercicio3.Controllers
{//
    
        //
    public class DBtarea
    {
        readonly SQLite.SQLiteAsyncConnection _conexion;
        public DBtarea() { 

        } 
        public DBtarea(String dbpath) {

            _conexion = new SQLite.SQLiteAsyncConnection(dbpath);

            //creacion de objeto base de datos
            _conexion.CreateTableAsync<Models.tareas2>().Wait();
           
           
        }
        //CRUD VIDEO 25 MINUTO 35
        public Task<int> StoreEquipo(Models.tareas2 t) {
            if (t.Id == 0)
            {
                return _conexion.InsertAsync(t);
            }
            else
            {
                return _conexion.InsertAsync(t);
            }

        }
        public Task<List<Models.tareas2>> Listatarea2()
        {
            return _conexion.Table<Models.tareas2>().ToListAsync();

        }
        public Task<Models.tareas2> Gettarea2(int pid)
        {
            return _conexion.Table<Models.tareas2>().Where(i => i.Id == pid).FirstOrDefaultAsync();
        }
        public Task<int> Delettarea2(Models.tareas2 t)
        {
            return _conexion.DeleteAsync(t);

        }
    }

}
