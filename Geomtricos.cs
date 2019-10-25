using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion_p1
{
    public abstract class Geomtricos
    {
        //metodo
        public abstract void operacion(int BaseA = 5, int AlturaA=7);
        //aqui se coloca el metodo abstracto operacion y saludo los cuales se usaran en las otras clases con los mismos nombres

        public abstract void Saludo();
        public abstract string Nombre { get; set; }
       

    }
}
