using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion_p1
{
    public class Cuadrado: Geomtricos//heredamos de geometricos
    {
        public override string Nombre { get ; set ; }
        
        public override void Saludo()
        {
            Console.WriteLine("hello Resultado de cuadrado");
            
        }
        //usamos la abstraccion para que cada metodo se llame igual pero tenga diferentes operaciones
        public override void operacion(int BaseA = 5 , int AlturaA = 7)
        {
            
            double Res = BaseA * BaseA;

            Console.WriteLine("El area es: " + Res);
            //realizamos la operacion para el area y el perimetros 


            double Peri = BaseA * 4;
            Console.WriteLine("el perimetro es: " + Peri);
        }

        

    }
}
