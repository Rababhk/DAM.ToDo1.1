using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM.ToDo
{
    public enum ToDoPriority { regular, Important, Urgent }
    public class toDo
    {
        public string Task { get; set; }
        public string Details { get; set; }
        public DateTime Created { get; private set; }
        public ToDoPriority Priority { get; set; }
        public DateTime? Done { get; internal set; }
        public DateTime? Schedule { get; internal set; }

        public toDo() { }
        public toDo(string task) { 
         this.Task = task;
         Created = DateTime.Now;
        }
        public static class ToDoData
        {
            //Recogemos la ruta del archivo de configuración
            private static string DataPath
           = System.Configuration.ConfigurationManager.AppSettings["DataPath"];
        }
    }
}
