using System; //LIBRERIA


namespace CONSOLA //conosla
{
    class Program //clases 
    {
        private static void Main(string[] /*args*/ argumentos) //elementos o metodos del programa
        //VOID NO RETORNA (argumentos)
        //argumentos podemos ingresar datos 
        {
            /*Console.WriteLine(args[0]);*/ //poscion no tiene elementos en el arreglo 
             if(argumentos.Length>0)
            {
                Console.WriteLine(argumentos[1]);
            }
            Console.BackgroundColor = ConsoleColor.Green;//cambia de color el fondo
            Console.Clear();//refresca consola
            Console.ForegroundColor = ConsoleColor.Red;//se cambia de color las letras

            Console.WriteLine(Console.BufferHeight);//genera un numero en especifico
            for (int i = 0; i < Console.BufferHeight; i++)
            {
                Console.WriteLine(i);
             }

            Console.Write("\nChao\nmundo\n");//varias lineas
            Console.WriteLine("Hola soy Tony!");//linea unida //escribe una linea("Hola mundo") 
            Console.Beep();//sonido
            Console.ReadKey();//se aplasta con un boton         
            
            //uso de variable string 
            Console.WriteLine("hola dame tu nombre completo por fa");
            string nombreCompleto;
            nombreCompleto = Console.ReadLine();
            Console.WriteLine("Hola {0} es un gusto conocerte", nombreCompleto); //asignamos en {0} el nombre del que ingresa
            Console.WriteLine("chao hasta luego");
            Console.ReadKey();
        }
    }
}
/*
namespace System
{
    class Console
    {
        void Write(string cadenaCaracter)
        {
            //impirme esto en pantalla

        }
    }
}
*/