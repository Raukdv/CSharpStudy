using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraApp
{
    internal class Program
    {
        //static void Main(string[] args) => Console.WriteLine("Hola soy una app de consola.");
        
        static void Main(string[] args)
        {
            //Operadores aritmeticos:
            //Multiplicacion
            //Console.WriteLine(7 * 5);

            //Division - Colocar valores entereos en division dara como resultado, un entero, no un decima.
            //Se debe indicar que el valor a usar es decimal en todo momento para obtener el valor esperado de la division
            //Console.WriteLine(5 / 2); //dara 2
            //Console.WriteLine(5.0 / 2.0); //dara 2.5

            //Reciduo
            //Console.WriteLine(9 % 3); // 0 por ser reciduo de la division

            //Concatenacion de Strings
            //int edad = 23;
            //Console.WriteLine("Tienes una edad de " + edad + " años");
            //Interpolacion de Strings
            //Console.WriteLine($"Tienes una edad de {edad} años");

            //Operador '=' declaraciones de varaibles implicitas y conversion de implicita a explicita
            //int personaEdad1;
            //int personaEdad2;
            //int personaEdad3;
            //int personaEdad4;

            //Inicar las 4 variables con una sola linea de codigo
            //personaEdad1 = personaEdad2 = personaEdad3 = personaEdad4 = 27;
            //Esto solo asignara el nuevo valor a personaEdad4 no al resto puesto que se esta separando por ','
            //int personaEdad1, personaEdad2, personaEdad3, personaEdad4 = 27;
            //Console.WriteLine(personaEdad4);

            //Declaraciones implicitas
            //var edadPersona = 27; //<-Asignara en la ejecución dicho valor, no en la compilación, requiere un valor a asignar
            // var volvera inmutable la variable asignada y solo admitira el valor y tipo previamente asignado
            //edadPersona += 3;
            //Console.WriteLine(edadPersona);

            //double temperatura = 34.6;
            //int temperaturaMcy;
            //Conversión explicita y/o casting
            //temperaturaMcy = (int) temperatura; //<- No redondeara los valores decimales
            //Round Math <= 0.5 sera el mismo valor.
            //Round Math >= 0.6 sera el siguiente valor.
            //temperaturaMcy = (int) Math.Round(temperatura);
            //Console.WriteLine(temperaturaMcy);

            //Conversion Implicita
            //int habitantesCiudad=415000;
            //long habitantesCiudad2022 = habitantesCiudad;
            //Console.WriteLine(habitantesCiudad2022);
            //float pesoPluma= 0.003F;
            //double pesoPlumaPrec = pesoPluma;
            //Console.WriteLine(pesoPlumaPrec);

            //Conversiones de texto a numero
            //Console.WriteLine("Introduce el primer número:");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Introduce el segundo número:");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("El resultado es: " + (num1 + num2));

            //Declaracion de constantes y variables
            //declaracion de constantes en una sola linea - convencion en MAY
            //const int VALOR = 5; const int VALOR2 = 10; const int VALOR3 = 20;
            //otro metodo de concatenación de textos: {0}
            //Console.WriteLine("El valor de la primera constante es: {0}", VALOR);

            //ejemplo con un calculo de area de un circulo
            //const double PI = 3.1416;
            //Console.WriteLine("Introduce la media del radio");
            //double radio = double.Parse(Console.ReadLine());
            //double area = radio * radio * PI; //sin math lib
            //double area = Math.Pow(radio, 2) * PI;
            //Console.WriteLine("El area del ciruclo es de: {0}", area);

            //METODOS
            //Son sentencias que se les da un nombre identificativo y que realizan una tarea en concreto
            //Los metodos no realizaran dicha tarea asignada al menos que sean llamados en el momento necesario.
            //Todos los metodos iran dentro de una clase
            //Se debe especificar el tipo de devolucion de valor y los parametros
            //No hay distinciones entre metodos y funciones, aqui son lo mismo, entonces un metoodo es una funcion en python.
            //Cuando el metodo no devuelve nada, es decir, no requiere return value; en vez de especificar algun tipo se usara void
            //Se se especifica void, no se usara return.
        }

    }

}

