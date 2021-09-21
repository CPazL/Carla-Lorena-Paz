using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------Ejercicio 4--------------------");
            string color = "", maxcolor= "";
            int valor, rojos = 0, rojos5000 = 0, inferior5000 = 0, cant = 0, max = 0;
            float prom = 0f;
            /**4.Realizar el algoritmo que permita iterar el ingreso de dos datos de un vehiculo, un color(rojo verde o amarillo) 
             * y un valor entre 0 y 10000 hasta que el usuario quiera e informar al terminar el ingreso por consola:**/
            do
            {
                Console.WriteLine("Para finalizar con el ingreso de datos ingrese color: f");
                do
                {
                    Console.WriteLine("Ingrese el color : Rojo - verde - amarillo");
                    color = Console.ReadLine();
                    color = color.ToUpper();
                } while (!ValidarColor(color));
                do
                {
                    Console.WriteLine("Ingrese el valor - Entre 0 y 1000");
                    valor = Int32.Parse(Console.ReadLine());
                } while (!Validarvalor(valor));

                //a.La cantidad de rojos
                if (color == "ROJO") {
                    rojos++;
                    //b.La cantidad de rojos con precio mayor a 5000
                    if (valor < 5000) {
                        rojos5000++;
                    }
                }
                //c.La cantidad de vehículos con precio inferior a 5000
                if (valor < 5000 && color != "F")
                {
                    inferior5000++;
                }
                // d.El promedio de todos los vehículos ingresados.
                if (color != "F")
                {
                    cant++;
                    prom = +valor;
                }
              
                //e.El más caro y su color.
                if (valor > max && color!="F") {
                    max = valor;
                    maxcolor = color;
                }

            } while (color != "F");
            prom /= cant;
            Console.WriteLine("Cantidad de autos rojos: {0}", rojos);
            Console.WriteLine("Cantidad de autos rojos con valor superior a 5000: {0}", rojos5000);
            Console.WriteLine("cantidad de vehículos con precio inferior a 5000: {0}", inferior5000);
            Console.WriteLine("El promedio de todos los vehículos ingresados: {0}", prom);
            Console.WriteLine("El auto más caro vale {0} y su color es {1}", max, maxcolor);
        }
        static public bool ValidarColor(string color) {
            if (color == "ROJO" || color == "VERDE" || color == "AMARILLO"  || color == "F") {
                return true;
            }
            return false;
        }
        static public bool Validarvalor(int valor)
        {
            if (valor <= 0 && valor >= 10000) {
                return false;
            }
            return true;
        }
      

        

    }
}
