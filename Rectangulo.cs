using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion_p1
{
    class Rectangulo: Geomtricos
    {
        public override string Nombre { get; set ; }
        

        //de la misma manera de los metodos anteriores se llaman iguales pero realizan tareas y mensajes diferentes
        public override void Saludo()
        {//mensaje
            Console.WriteLine("hello Resultado de rectangulo");
        }

        public override void operacion(int BaseA =5, int AlturaA = 7)
        {//operaciones
            double Res = BaseA * AlturaA;
            Console.WriteLine("El area es: " + Res);

            double Peri = (BaseA * 2)+(AlturaA * 2 );
            Console.WriteLine("el perimetro es: " + Peri);
        }
            
        

    }
}
