﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona  
    {
        private string nombre;
        private string apellido;
        private int edad;
        private int dni;

        protected Persona(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.Dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Dni { get => dni; set => dni = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.nombre + " | " + this.apellido + " | " + this.edad + " | " + this.Dni);

            return sb.ToString();
        }
    }
}
