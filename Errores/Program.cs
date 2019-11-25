using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errores
{
    class Program
    {
        static void Main(string[] args)
        {
            var Estudiante = new List<Estudiante>(); //Creamos la variable "Estudiante" y le asignamos la instancia de la nueva lista

            var Agregar = true; //Creamos la variable "Agregar" y la asignamos como true

            while (Agregar) //Ciclo while en la variable "Agregar"
            { 
                try //Try-Cath por si ingresamos por error letras en la matricula...
                {
                    int Matricula = 0; //Creamos una variable Matricula como int y la igualamos a 0

                    var E = new Estudiante(); //Instanciamos la clase "Estudiante" como E

                    Console.WriteLine(""); //cw para pasar de linea...

                    Console.WriteLine("Ingrese Matricula:");
                    bool result = int.TryParse(Console.ReadLine(), out Matricula); //Creamos una variable "resul" como bool y aplicamos el int.TryParse, pidiendo la Matricula al usuario
                    Console.WriteLine(""); //cw para pasar de linea...             //seguido del metodo out usando la variable "Matricula" que esta igualada a 0

                    if (result == false) //Condicion por si la variable "resul" es falsa
                    {
                        Console.WriteLine("Ingrese un numero..."); //Mensaja de aviso...
                        Matricula = int.Parse(Console.ReadLine()); //Volvemos pedir como int.Parse
                    }

                    Console.WriteLine(""); //cw para pasar de linea...

                    Console.WriteLine("Inrgese Nombre:");
                    E.Nombre = Console.ReadLine(); //Pedimos al usuario el Nombre
                    Console.WriteLine(""); //cw para pasar de linea...

                    Console.WriteLine("Ingrese Semestre:");
                    E.Semestre = Console.ReadLine(); //Pedimos al usuario el Semestre
                    Console.WriteLine(""); //cw para pasar de linea...

                    Console.WriteLine("Ingrese Carrera:");
                    E.Carrera = Console.ReadLine(); //Pedimos al usuario la Carrera
                    Console.WriteLine(""); //cw para pasar de linea...

                    Estudiante.Add(E); //Agregamos los valores ingresado de la instancia "E" a la lista "Estudiante"

                    Console.WriteLine("¿Quiere agregar otro usuario?    Y/N"); //Preguntamos al usuario...

                    if (Console.ReadLine() !="Y") //Condicion por si respondemos que si
                    {
                        Agregar = false; //Cambiamos de true a false la variable Agregar
                    }

                }
                catch (Exception) //Si cometemos el error entonces se desplega el mensaje
                {
                    Console.WriteLine("Error agregando el usuario, intente nuevamente..."); //Mensaje de aviso...
                    Console.ReadKey(); //Console ReadKey para que no se cierre el programa
                    Console.Clear(); //Limpiamos la consola...
                }
            }

            //En resumen lo que hicimos fue darle a entender a la consola que ingresamos numeros
            //en una variable que esta dada principalmente como string (ya que al ser string admite
            //como numeros y letras) usamos el try.Parse con una variable igualada a 0 asi que cuando
            //ingresamos letras en la matricula primero iguala la variable "Matricula"
            //como int.Parse y de ahi te manda al catch para darte el mensaje de ingreses solo numero
            //y si no ingresaste letras el ciclo sigue igual dependiendo la condicion que le des al if.
        }
    }
}
