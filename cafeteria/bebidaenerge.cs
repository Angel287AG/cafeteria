using System;

namespace Cafeteria
{
    internal class bebidaenerge : Bebida
    {
        private int CantidadCafeina;
        private string Marca;

        public int cantidadCafeina
        {
            get { return CantidadCafeina; }
            set { CantidadCafeina = value; }
        }

        public string marca
        {
            get { return Marca; }
            set { Marca = value; }
        }

        public bebidaenerge(
            string _nombre,
            string _tamaño,
            float _precio,
            int _cantidadCafeina,
            string _marca)
            : base(_nombre, _tamaño, _precio)
        {
            CantidadCafeina = _cantidadCafeina;
            Marca = _marca;
        }

        public override string Preparar()
        {
            return "Preparando un " + Nombre +
                   " Energizante marca " + Marca +
                   " de tamaño " + Tamaño +
                   " con " + CantidadCafeina +
                   " mg de cafeína";
        }

        public string Mensaje()
        {
            return Nombre + " Energizante";
        }
    }
}