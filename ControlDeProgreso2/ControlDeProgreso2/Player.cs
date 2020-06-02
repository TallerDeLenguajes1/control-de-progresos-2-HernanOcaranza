using System;
using System.Collections.Generic;
using System.Text;

namespace ControlDeProgreso2
{
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
        private string tipo;
        private string nombre;
        private string apodo;
        private DateTime fechaNac;
        private int salud;

        public string Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public int Salud { get => salud; set => salud = value; }

        /*public int Edad()
        {
            
        }*/

    }
}
