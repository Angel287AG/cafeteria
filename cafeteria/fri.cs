using System;

namespace Cafeteria
{
    internal class fri : Bebida
    {
        private int CantidadHielo;

        public int cantidadHielo
        {
            get { return CantidadHielo; }
            set { CantidadHielo = value; }
        }

        public fri(string _nombre, string _tamaño,
                   float _precio, int _cantidadHielo)
            : base(_nombre, _tamaño, _precio)
        {
            CantidadHielo = _cantidadHielo;
        }

        public override string Preparar()
        {
            return $"Preparando un {Nombre} frío de tamaño {Tamaño} con {CantidadHielo} hielos";
        }

        public string Mensaje()
        {
            return $"{Nombre} Frío";
        }
    }
}