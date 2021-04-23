using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double AreaRetangulo()
        {
            return Largura * Altura;
        }
        
        public double PerimetroRetangulo()
        {
            return (Largura * 2) + (Altura * 2);
        }

        public double DiagonalRetangulo()
        {
            return Math.Sqrt((Math.Pow(Altura, 2) + Math.Pow(Largura, 2)));

        }

        public override string ToString()
        {
            return "AREA: " + (AreaRetangulo().ToString("F2")) 
                + "\nPERIMETRO: " + (PerimetroRetangulo().ToString("F2")) 
                + "\nDIAGONAL: " + (DiagonalRetangulo().ToString("F2"));

        }

    }
}
