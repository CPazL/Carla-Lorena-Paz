using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String continente, pago;
            float descTotal = 0f;
            float recargoTotal = 0f, total=0f;
            int dias=0;
            //2. Una empresa de viajes le solicita ingresar que continente le gustaría visitar y la cantidad de días ,
            //la oferta dice que por día se cobra $100 , que se puede pagar de todas las maneras: 

            Console.WriteLine("------------------Ejercicio 2--------------------");

            Console.WriteLine("Ingrese el continente");
            continente = Console.ReadLine();
       
            while(!Continente(continente)) {
                Console.WriteLine(" Error: ingrese un continente válido");
                continente = Console.ReadLine();
            }
            Console.WriteLine("Ingrese los dias");
            dias = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la forma de pago");
            pago = Console.ReadLine();

            while (!FormaPago(pago))
            {
                Console.WriteLine(" Error: ingrese un continente válido");
                pago = Console.ReadLine();
            }
            total = dias * 100;
            Console.WriteLine("\n             SUBTOTAL: {0} ", total);

            descTotal = Descuento(continente, pago)*total;
            Console.WriteLine("\n            Descuento: {0} ", descTotal);

            recargoTotal = Recargo(continente,pago) *total;
            Console.WriteLine("\n              Recargo: {0} ", recargoTotal);
           
            total =  total - descTotal + recargoTotal;
            Console.WriteLine("\n          TOTAL FINAL: {0} ", total);
        }
         
        static public bool Continente(String cont) {
            cont = cont.ToUpper();
            if (cont == "AMÉRICA" || cont == "ASIA" || cont == "EUROPA" || cont == "AFRICA" || cont == "OCEANÍA" ) {
                return true;
            }
            else {
                return false;
            }
        }
        static public bool FormaPago(String form)
        {
            form = form.ToUpper();
            if (form == "DÉBITO" || form == "CRÉDITO" || form == "EFECTIVO" || form == "MERCADO PAGO" || form == "CHEQUE" || form == "LELIQ")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public float Descuento(String cont, String pago)
        {
            float desc=0f;
        
            //b.Si es América tiene un 15 % de descuento y si además paga por débito se le agrega un 10 % más de descuento
            if (cont == "AMÉRICA" || cont == "AMERICA") {
                desc = 0.15f;
                if (pago == "DÉBITO") {
                    desc = desc + 0.1f;
                }
                return desc;
            //c.Si es África u Oceanía tiene un 30 % de descuento y si además paga por mercadoPago o efectivo se le agrega un 15 % más de descuento
            }
            else if (cont == "AFRICA") {
                desc = 0.3f;
                if (pago == "MERCADO PAGO" || pago == "EFECTIVO")
                {
                    desc = desc + 0.15f;
                }
                
                return desc;
            }
            else if (cont == "ASIA")
            {
                desc = 0f;
                return desc;
            }
            //d.Si es Europa tiene un 20 % de descuento y si además paga por débito se le agrega un 15 % , por mercado Pago un 10 % y cualquier otro medio 5 %
          
            else if (cont == "EUROPA")
            {
                desc = 0.2f;
                if (pago == "DÉBITO" )
                {
                    desc = desc + 0.15f;
                }
                if (pago == "MERCADO PAGO")
                {
                    desc = desc + 0.1f;
                }
                else {
                    desc = desc + 0.05f;
                }
                return desc;
            }
            else if (cont == "OCEANÍA")
            {
                desc = 0.3f;
                if (pago == "MERCADO PAGO" || pago == "EFECTIVO")
                {
                    desc = desc + 0.15f;
                }
                return desc;
              
            }
            return desc;

        }
        //e.cualquier otro continente tiene un recargo del 20 %
        static public float Recargo(String cont, String form)
        {
            //f.en cualquier continente, si paga con cheque, se recarga un 15 % de impuesto al cheque
            float recargo =0f;
          
                if (form == "CHEQUE")
                {
                    recargo =  0.1f;
                    return recargo;
                }

            if (cont == "EUROPA")
            {
                recargo = 0.0f;
                return recargo;
            }
            else {
                recargo = 0.2f;
                return recargo;
            }
            
           
        }

    }
}
