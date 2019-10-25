using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion_p1
{
    class Menu
    {
        //creamos una clase y un metodo menu para el usuario pueda escoger lo que decea hacer
        public void menu()
        {



            //instanciamos 
            triangulo T = new triangulo();
            


            Cuadrado C = new Cuadrado();
           
            


            Rectangulo R = new Rectangulo();
           
            //por si no se puede heredar la clase
            Geomtricos G = new triangulo();

            


            int op;

            Console.WriteLine("Menu de areas y perimetros");
            Console.WriteLine("1.triangulo");
            Console.WriteLine("2.Cuadrado");
            Console.WriteLine("3.Rectangulo");
            Console.WriteLine("4.las 3 primeras opciones");




            Console.WriteLine("Dame opcion");
            op = Convert.ToInt32(Console.ReadLine());
            //Menu de opciones

            switch (op)
            {//se manda a llamar a los metodos instanciados
                case 1:
                    T.Saludo();
                    T.operacion();
                    Console.ReadKey();
                    Console.Clear();
                    menu();
                    break;
                case 2:
                    C.Saludo();
                    C.operacion();
                    Console.ReadKey();
                    Console.Clear();
                    menu();
                    break;
                case 3:
                    R.Saludo();
                    R.operacion();
                    Console.ReadKey();
                    Console.Clear();
                    menu();

                    break;
                case 4:
                    T.Saludo();
                    T.operacion();
                    C.Saludo();
                    C.operacion();
                    R.Saludo();
                    R.operacion();
                    Console.ReadKey();
                    Console.Clear();
                    menu();
                    break;
                    //se imprimen los 6 metodos



            }
           
             


            }

    }
}
