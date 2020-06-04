using System;
using System.Collections.Generic;
using System.Linq;

namespace ControlDeProgreso2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CANT_RONDAS = 30;
            const int CANT_PLAYERS = 2;
            LinkedList<Player> listaDePersonajes = new LinkedList<Player>();
            for (int j = 0; j < CANT_PLAYERS; j++)
            {
                Player pj = new Player();
                listaDePersonajes.AddLast(pj);
            }
            Player pj1 = listaDePersonajes.ElementAt(0);
            Player pj2 = listaDePersonajes.ElementAt(1);
            int i = 0;
            while (i < CANT_RONDAS && pj1.EstaVivo() && pj2.EstaVivo())
            {
                RealizarRonda(pj1, pj2);
                i++;
            }

            if (pj1.Salud > pj2.Salud)
            {
                listaDePersonajes.Remove(pj2);
                Console.WriteLine("Gano " + pj1.Nombre + " el " + pj1.Tipo);
                pj1.Salud += 20;
                pj1.Nivel++;
                Console.WriteLine("");
                pj1.MostarDatos();
                pj1.MostarCaracteristicas();
            }
            else if (pj1.Salud < pj2.Salud)
            {
                listaDePersonajes.Remove(pj1);
                Console.WriteLine("Gano " + pj2.Nombre + " el " + pj2.Tipo);
                pj2.Salud += 20;
                pj2.Nivel++;
                Console.WriteLine("");
                pj2.MostarDatos();
                pj2.MostarCaracteristicas();
            }
            else
            {
                Console.WriteLine("EMPATE");
                Console.WriteLine("");
                pj1.MostarDatos();
                pj1.MostarCaracteristicas();
                Console.WriteLine("");
                pj2.MostarDatos();
                pj2.MostarCaracteristicas();
            }
            
            
        }

        static public void RealizarRonda(Player pj1, Player pj2)
        {
            pj1.Atacar(pj2);
            pj2.Atacar(pj1);
        }
    }
}
