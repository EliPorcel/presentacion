using System;

namespace presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor=ConsoleColor.Magenta;
            Console.WriteLine("Para iniciar, presione una tecla cualquiera...");
            Console.ReadKey(); 
            Console.ForegroundColor=ConsoleColor.DarkYellow;
            Console.WriteLine("¿Cuál es cualquiera?");
            Console.ReadKey();
            Console.ForegroundColor=ConsoleColor.Green; 
            Console.WriteLine("Veo la Esc,...");
            Console.ReadKey();
            Console.ForegroundColor=ConsoleColor.Cyan; 
            Console.WriteLine("...Ctrl...");
            Console.ReadKey();
            Console.ForegroundColor=ConsoleColor.Yellow; 
            Console.WriteLine("...y Pg Up"); 
            Console.ReadKey();
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine("¡No tiene tecla Cualquiera!"); 
            Console.ReadKey();
            Console.ForegroundColor=ConsoleColor.Blue;
            Console.WriteLine("Tanta computación me dio sed, creo que aquí hay cerveza Tab.");
            Console.ReadKey(); 
            Console.BackgroundColor=ConsoleColor.Red;
            Console.ForegroundColor=ConsoleColor.Black;
            Console.WriteLine("¡Ahh no hay tiempo para eso, finalizó la computadora!");
            Console.ReadKey();
            Console.ForegroundColor=ConsoleColor.White;
            Console.BackgroundColor=ConsoleColor.Black;
            Console.WriteLine("¡Gracias! Presione una tecla cualquiera para salir.");
            Console.ReadKey();
        }
    }
}
        
    

