﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractas
{
    abstract class Animal
    {

        private string nombre;

        public Animal(string nombre)
        {
            NombreComun = nombre;
        }

        public string NombreComun
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public abstract string Come
        {
            get;
        }

        public override string ToString()
        {
            return NombreComun + "" + Come;
        }

    }
}
