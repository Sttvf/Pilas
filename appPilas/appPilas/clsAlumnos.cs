using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPilas
{
    public class clsAlumnos
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string NoControl { get; set; }

        public override string ToString()
        {
            return 
                this.Nombre + " " + 
                this.ApellidoPaterno + " - " + 
                this.ID;
        }
    }
}
