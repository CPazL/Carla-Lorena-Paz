using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
  /**
      
**/
            Console.WriteLine("------------------Ejercicio 5--------------------");
  
            string alumno = "";
            int edad=0, nota=0, varonesAprob=0, ado=0, men=0, may=0, mujer=0, varon=0;
            char sexo =' ';
            float promVarones = 0f, promMujeres = 0f, promNotaMen =0f, promNotaAdo = 0f, promNotaMay=0f;
   /**5.Realizar el algoritmo que permita ingresar el nombre de un estudiante, la edad(validar) , el sexo(validar) y la nota del final(validar) 
             * hasta que el usuario quiera e informar al terminar el ingreso por consola:**/
            do
            {
                Console.WriteLine("Para finalizar con el ingreso de datos ingrese color: f");
               
                    Console.WriteLine("Ingrese el nombre del estudiante");
                    alumno = Console.ReadLine();
                    alumno = alumno.ToUpper();
                if (alumno != "F")
                {
                    do
                    {
                        Console.WriteLine("Ingrese la edad");
                        edad = Int16.Parse(Console.ReadLine());
                    } while (!ValidarEdad(edad));

                    do
                    {
                        Console.WriteLine("Ingrese la nota");
                        nota = Int16.Parse(Console.ReadLine());
                    } while (!Validarnota(nota));

                    Console.WriteLine("Ingrese el sexo");
                    sexo = Char.Parse(Console.ReadLine());


                    //   a.La cantidad de varones aprobados
                    if ((sexo == 'm' || sexo == 'M') && nota < 5)
                    {
                        varonesAprob++;

                    }
                    // b.El promedio de notas de los menores de edad
                    if (edad < 18)
                    {
                        promNotaMen = +nota;
                        men++;
                    }
                    // c.El promedio de notas de los adolescentes.

                    if (edad > 12 && edad < 18)
                    {
                        promNotaAdo = +nota;
                        ado++;
                    }


                    // d.El promedio de notas de los mayores
                    if (edad >= 18)
                    {
                        promNotaMay = +nota;
                        may++;
                    }
                    //e.El promedio de notas por sexo.
                    if (sexo == 'M')
                    {
                        promVarones = +nota;
                        varon++;
                    }
                    else if (sexo == 'F')
                    {
                        promMujeres = +nota;
                        mujer++;
                    }
                }
            } while (alumno != "F");
            Console.WriteLine("Cantidad de varones aprobados: {0}", varonesAprob);
            promNotaMen /= men;
            Console.WriteLine("Promedio de notas de menores ingresados: {0}", promNotaMen);
            promNotaAdo /= ado;
            Console.WriteLine("Promedio de notas de adolecentes ingresados: {0}", promNotaAdo);
            promNotaMay /= may;
            Console.WriteLine("Promedio de notas de mayores ingresados: {0}", promNotaMay);
            promVarones /= varon;
            Console.WriteLine("Promedio de notas de varones ingresados: {0}", promVarones);
            promMujeres /= mujer;
            Console.WriteLine("Promedio de notas de mujeres ingresadas: {0}", promMujeres);


        }
        static public bool ValidarEdad(int edad )
        {
            if (edad<0 && edad >130)
            {
                return false;
            }
            return true;
        }
        static public bool Validarnota(int valor)
        {
            if (valor < 0 && valor >= 10)
            {
                return false;
            }
            return true;
        }




    }
}
        
