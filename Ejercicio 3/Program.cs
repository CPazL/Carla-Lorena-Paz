using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
             int tam = 2;
            Console.WriteLine("------------------Ejercicio 3--------------------");
            int i = 0, liv = 0, cantCarne = 0;
            string[] bolsa = new string[tam];
            int[] Kilos = new int[tam];
            string[] sabor = new string[tam];
            float promCarne = 0f;

            for (i = 0; i < tam; i++)
            {
                Console.WriteLine("\t Ingrese el nombre de la bolsa {0} \t ", i+1);
                bolsa[i] = Console.ReadLine();
                bolsa[i] = bolsa[i].ToUpper();
                Console.WriteLine("\t Ingrese los kilos de la bolsa {0} \t ", i+1);
                Kilos[i] = Int32.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine("\t Ingrese el sabor de la bolsa {0}: Carne, pollo o vegetales \t ", i+1);
                    sabor[i] = Console.ReadLine();

                } while (!validarSabor(sabor[i]));
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("\t El promedio en kilos es : {0}  ", promedio(Kilos, tam));
            liv = MasLiviana(Kilos, tam);
            Console.WriteLine("\t La bolsa más liviana es {0} con un peso de {1} en kilos con sabor a {2}  ", bolsa[liv], Kilos[liv], sabor[liv]);
            promCarne = PromSaborCarne(sabor, Kilos, tam);
            cantCarne = CantSaborCarne(sabor, tam);
            Console.WriteLine("\t Hay {0} bolsas sabor carne ", cantCarne);
            Console.WriteLine("\t El promedio de Kilos por bolsa de carne es {0} ", promCarne);


            static bool validarSabor(string sabor)
            {
                sabor = sabor.ToUpper();
                if (sabor != "CARNE" && sabor != "VEGETALES" && sabor != "POLLO") {
                    return false;
                }
                return true;

            }
            // a. El promedio de los kilos totales.
            static float promedio(int[] Kilos, int tam)
            {
                int i = 0;
                float prom = 0f;
                for (i = 0; i < tam; i++)
                {
                    prom = +Kilos[i];
                }
                prom = prom / tam;
                return prom;
            }
            // b. La bolsa más liviana y su sabor
            static int MasLiviana(int[] Kilos, int tam)
            {
                int i , min=0;
                int minKilos = Int32.MaxValue;
                for (i = 0; i < tam; i++)
                {
                    if (minKilos > Kilos[i])
                    {
                        minKilos = Kilos[i];
                        min = i;
                    }
                }
                return min;
            }

            // c. La cantidad de bolsas sabor carne y el promedio de kilos de sabor carne
            static float PromSaborCarne(string[] sabor, int[] Kilos, int tam)
            {
                int i , cant = 0;
                float prom = 0f;
                for (i = 0; i < tam; i++)
                {
                    if (sabor[i] == "CARNE"){
                        cant++;
                        prom = + (float)Kilos[i];
                    }
                }
                prom /= cant;
                return (prom);
            }
            static int CantSaborCarne(string[] sabor, int tam)
            {
                int i, cant = 0;
 
                for (i = 0; i < tam; i++)
                {
                    if (sabor[i] == "CARNE")
                    {
                        cant++;
                        
                    }
                }
               
                return cant;
            }

        }
    }
}
