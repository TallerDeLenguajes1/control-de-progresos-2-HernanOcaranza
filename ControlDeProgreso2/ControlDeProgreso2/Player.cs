using System;
using System.Collections.Generic;
using System.Text;

namespace ControlDeProgreso2
{
    enum TipoPersonaje
    {
        tipo1,
        tipo2,
        tipo3
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

        public Player(string nombreIngresado, string apodoIngresado, DateTime fechNacIngresada)
        {
            //Falta el tipo de dato
            Random NumeroAleatorio = new Random();
            nombre = nombreIngresado;
            apodo = apodoIngresado;
            fechaNac = fechNacIngresada;
            salud = 100;
            velocidad = NumeroAleatorio.Next((int)Maximos.velocidad);
            destreza = NumeroAleatorio.Next((int)Maximos.destreza);
            fuerza = NumeroAleatorio.Next((int)Maximos.fuerza);
            nivel = NumeroAleatorio.Next((int)Maximos.nivel);
            armadura =  NumeroAleatorio.Next((int)Maximos.armadura);
        }

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


        public int Edad()
        {
            int EdadPlayer = DateTime.Now.Year - FechaNac.Year;
            return EdadPlayer;
        }

    }
}
