using System;

namespace Cafeteria
{
    internal class calient : Bebida
    {
        private int Temperatura;

        public int temperatura 
        {
            get { return Temperatura; }
            set { Temperatura = value; }
        }

 
        public calient(string _nombre, string _tamaño, float _precio, int _temperatura) : base(_nombre, _tamaño, _precio)
        {
            Temperatura = _temperatura;
        }

   
        public override string Preparar()
        {
            return "Preparando un : " + Nombre + " Caliente  de tamaño : " + Tamaño;
        }

        public string Mensaje()
        {
            return Nombre + " Caliente";
        }

    }
}