using System;

namespace Repaso18
{
    //ingresa un numero, mostrarlo en binario, octal, hexadecimal
    class MainClass
    {
        public static void Main(string[] args)
        {
            string ingreso = "";
            int numeroIngresado = -1;
            do
            {
                Console.WriteLine("Ingresar un número positivo");
                ingreso = Console.ReadLine();
                if (ingreso == "") Console.WriteLine("Algo, no vacío");
                if (!int.TryParse(ingreso, out numeroIngresado)){
                    ingreso = "";
                    Console.WriteLine("Un número, por favor");
                } else if (numeroIngresado < 0){
                    numeroIngresado = -1;
                    ingreso = "";
                    Console.WriteLine("Un número positivo, por favor");
                }
            } while (ingreso == "");


            string numeroBinario = Convert.ToString(numeroIngresado, 2);
            string numeroOctal = Convert.ToString(numeroIngresado, 8);
            string numeroHexadecimal = Convert.ToString(numeroIngresado, 10);

            string mensaje = "Usted ingresó: " + numeroIngresado + "\n"+
                             "En binario eso es: " + numeroBinario + "\n"+
                             "En octal eso es: " + numeroOctal + "\n" +
                             "En hexadecimal eso es: " + numeroHexadecimal + "\n";
            Console.WriteLine(mensaje);


        }
    }
}
