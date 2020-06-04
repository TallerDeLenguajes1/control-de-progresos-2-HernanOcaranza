using System;

namespace ControlDeProgreso2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player pj1 = new Player();
            Player pj2 = new Player();
            pj1.MostarDatos();
            pj1.MostarCaracteristicas();
            Console.WriteLine("");
            pj2.MostarDatos();
            pj2.MostarCaracteristicas();

        }
    }
}
