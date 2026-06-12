using System;

namespace Cafeteria
{
    internal class bebidaenerge : Bebida
    {
        private int Bebidacafeina;

        public int bebidacafeina
        {
            get { return Bebidacafeina; }
            set
            {
                if (value > 0)
                {
                    Bebidacafeina = value;
                }
                else
                {
                    Bebidacafeina = -1;
                }
            }
        }

        public bebidaenerge(string _nombre, string _tamaño, float _precio, int _bebidacafeina) : base(_nombre, _tamaño, _precio)
        {
            Bebidacafeina = _bebidacafeina;
        }

        public bebidaenerge()
        {
            Bebidacafeina = 0;

        }

        public override string Preparar()
        {
            return "Preparando un : " + Nombre + " tamaño : " + Tamaño;
        }

        public string Mensaje()
        {
            return Nombre + " mg";
        }

    }
}