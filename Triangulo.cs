using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion_p1
{
    //usamos la abstraccion para que cada metodo se llame igual pero tenga diferentes operaciones
    public class triangulo : Geomtricos //heredamos de geometricos
    {
        public override string Nombre { get; set; }
        

        public override void Saludo()
        {
            Console.WriteLine("hello Resultado de triangulo");
            //imprimo el nombre de lo que se realizara en este caso sera sobre triangulo
        }

        public override void operacion(int BaseA = 5 , int AlturaA =7 )
        {
            double Res = (BaseA * AlturaA)/2;
            Console.WriteLine("El area es: " + Res);

            //la operacion de abstraccion se realiza aqui
           
        }

       

        
    }
}
