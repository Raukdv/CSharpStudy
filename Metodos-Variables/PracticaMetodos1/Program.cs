using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Main es el nombre del metodo principal es decir siempre sera el punto de inicio y de entrada.
            //Static hace referencia ha que no hay ningun objecto para iniciar y Main no es un objecto pero si el punto de inicio y de entrada.
            //Ya que es el punto de inicio y no es un objecto se le asigna static para poder ser llamado, ejecutado y sirva como punto de entrada.
            //Se le asigna void ya que no devolvera nada en un return.
            //Llamar a un metodo ajeno de Main tiene pasos extras debito a static, static hace referencia a que el metodo de inicio pueda ser llamado y ejecutado sin ser un objecto, es decir: Sin inicializarlo como un objecto.
            //Si lo llamas tal cual obtendras la siguinte salida de error: "Se requiere una referencia a un objeto para el campo, método o propiedad no estática"
            //mensajeEnPantalla();

            //Llamado de metodo con parametros:
            sumaNumeros(6,10);
            //LLamada y devuelva de metodo con parametros
            int devuelvo = devuelveSumaNumeros(7, 10);
            Console.WriteLine(devuelvo);
            Console.WriteLine(divideNumeros(10.5, 4));
        }
        //Nuevo metodo para monstrar un mensaje:
        //Si este metodo no se llamada dento de main, el flujo de inicio y de entrada terminara en main (vacio).
        //Para poder llamarlo y evitar el "Se requiere una referencia a un objeto para el campo, método o propiedad no estática"
        //debes asignar static al nuevo metodo.
        //static void mensajeEnPantalla()
        //{
        //    Console.WriteLine("Hola soy un mensaje desde otro metodo.");
        //}

        //Paso de variables por metodos:
        //Cuando se llame a un metodo que recibe parametros, debe iniciarse con dichos valores ya dados.
        //De otra forma, el programa solo dara un error por falta de referencias
        static void sumaNumeros(int var1, int var2)
        {
            int resultado = var1 + var2;
            Console.WriteLine($"La suma de los numeros es: {resultado}");
        }

        //Return - Devuelta de valores
        static int devuelveSumaNumeros(int var1, int var2)
        {
            int resultado = var1 + var2;
            return resultado;
        }
        //Otra forma de devolver un metodo simple
        static double divideNumeros(double var1, int var2) => var1 / var2;
 
    }
}
