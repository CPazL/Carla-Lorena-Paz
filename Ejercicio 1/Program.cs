using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            /***Pedir dos números por consola y mostrar el resultado: */
            Console.WriteLine("------------------Ejercicio 1--------------------");
            Console.WriteLine("Ingrese el primer número entero");
            a = Int32.Parse(Console.ReadLine());
          
            Console.WriteLine("Ingrese el segundo número entero");
            b = Int32.Parse(Console.ReadLine());
            //a. Si son iguales muestro el cuadrado del número. 
            if (Iguales(a, b))
            {
                Console.WriteLine("\n Si son iguales y el resultado es {0}", Cuadrado(a, b));
            }
            else {
                Console.WriteLine("\n No son iguales");
            }
            //b. Si el primero es divisible por el segundo, los resto, de lo contrario muestro solo el resto. 
            if (div(a, b))
            {
                Console.WriteLine("\n {0} es divisible por {1} entonces su resta {0}-{1} = {2}", a, b, restos(a, b));
            }
            else
            {
                Console.WriteLine("\n {0} no es divisible por {1} entonces su resto es {2}", a, b, restos(a, b));
            }

            //c. si el resto es mayor a 3 (tres) informar por consola. 
            if (restos3(a, b)) {
                Console.WriteLine("\n El resto de {0}/{1} es mayor a 3",a,b);
            }

        }
        //a. Si son iguales muestro el cuadrado del número. 
        static public int Cuadrado(int a, int b) {
                return a * b;
        }
        static public bool Iguales(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //b. Si el primero es divisible por el segundo, los resto, de lo contrario muestro solo el resto. 
        static public bool div(int a, int b)
        {
            if (b == 0) {
                return false;
            }
            if(a % b == 0){
                return true;
            }else{
                return false;
            }
            
        }
        static public int restos(int a, int b)
        {
            if (div(a,b))
            {
                return a-b;
            }
            else
            {
                return a%b;
            }

        }
        //c. si el resto es mayor a 3(tres ) informar por consola. 
        static public bool restos3(int a, int b)
        {
            if (a%b>3)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
