using System;
using System.Collections.Generic;
using System.Text;

namespace ControlDeProgreso2
{
    enum TipoPersonaje
    {
        Mago,
        Guerrero,
        Druida,
        Bardo,
        Clerigo
    };

    enum Maximos
    {
        velocidad = 10,
        destreza = 5,
        fuerza = 10,
        nivel = 10,
        armadura = 10
    };
    class Player
    {
        private TipoPersonaje tipo;
        private string nombre;
        private string apodo;
        private DateTime fechaNac;
        private int salud;
        private int velocidad;
        private int destreza;
        private int fuerza;
        private int nivel;
        private int armadura;

        

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public int Salud { get => salud; set => salud = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        public TipoPersonaje Tipo { get => tipo; set => tipo = value; }

        public Player()
        {
            Random r = new Random();
            Array valoresTiposPersonaje = Enum.GetValues(typeof(TipoPersonaje));
            TipoPersonaje tip = (TipoPersonaje)valoresTiposPersonaje.GetValue(r.Next(valoresTiposPersonaje.Length));
            string[] nom = { "Kei Minoo", "Atilus Hafza", "Mirko", "Josapath" };
            string[] apod = { "KM", "Ati", "Mir", "Jos" };
            int indA = r.Next(4);
            DateTime fechN = new DateTime(DateTime.Now.Year - 300, DateTime.Now.Month, DateTime.Now.Day).AddDays(r.Next(365 * 300));
            int vel = r.Next((int)Maximos.velocidad) + 1;
            int des = r.Next((int)Maximos.destreza) + 1;
            int fuer = r.Next((int)Maximos.fuerza) + 1;
            int niv = r.Next((int)Maximos.nivel) + 1;
            int arm = r.Next((int)Maximos.armadura) + 1;
            CargarDatos(tip, nom[indA], apod[indA], fechN);
            CargarCaracteristicas(vel, des, fuer, niv, arm);
        }
        public int Edad()
        {
            int EdadPlayer = DateTime.Now.Year - FechaNac.Year;
            return EdadPlayer;
        }
        public void CargarDatos(TipoPersonaje tip, string nom, string apod, DateTime fechN)
        {
            Tipo = tip;
            Nombre = nom;
            Apodo = apod;
            FechaNac = fechN;
            Salud = 100;
        }

        public void CargarCaracteristicas(int vel, int des, int fuer, int niv, int arm)
        {
            Velocidad = vel;
            Destreza = des;
            Fuerza = fuer;
            Nivel = niv;
            Armadura = arm;
        }

        public void MostarDatos()
        {
            Console.WriteLine("DATOS DE MI PERSONAJE");
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apodo: " + Apodo);
            Console.WriteLine("Fecha de nacimiento: " + FechaNac);
            Console.WriteLine("Edad: " + Edad());
            Console.WriteLine("Salud: " + Salud);
        }

        public void MostarCaracteristicas()
        {
            Console.WriteLine("CARACTERISTICAS DE MI PERSONAJE");
            Console.WriteLine("Velocidad: " + Velocidad);
            Console.WriteLine("Destreza: " + Destreza);
            Console.WriteLine("Fuerza: " + Fuerza);
            Console.WriteLine("Nivel: " + Nivel);
            Console.WriteLine("Armadura: " + Armadura);
        }


    }
}
