using System;

namespace Cafeteria
{
    internal class Bebida
    {
        protected string Nombre;
        protected string Tamaño;
        protected float Precio;

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public string tamaño
        {
            get { return Tamaño; }
            set { Tamaño = value; }
        }

        public float precio
        {
            get { return Precio; }
            set
            {
                if (value > 0)
                    Precio = value;
            }
        }

        public Bebida(string _nombre, string _tamaño, float _precio)
        {
            Nombre = _nombre;
            Tamaño = _tamaño;
            Precio = _precio;
        }

        public virtual string Preparar()
        {
            return $"Preparando un {Nombre} de tamaño {Tamaño}";
        }

        public void Descuento(float descuento)
        {
            Precio = Precio * (1 - descuento / 100);
        }
    }
}