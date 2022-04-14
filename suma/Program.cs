using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma
{
   internal class Program
    {
  
       static void Main(string[] args)
       
        {
            int numero1 = 8;
            double numero2 = 4.5; 
            double resultado;

            //Variable string 
            string saldo = "Hola";
            string nombre = "Raul";


            //Sumamos las dos variables
            resultado = numero1 + numero2; 

            //se va sumando una variable  y un dato puesto especificamente 
            resultado = numero1 + 22;
            //console.WriteLine(resultado) 

            //sumando o conectando dos cadenas que va almacenadas en variables
            Console.WriteLine(saldo + nombre + "¿Como te va?");
            Console.ReadKey();

        }
    }
}
