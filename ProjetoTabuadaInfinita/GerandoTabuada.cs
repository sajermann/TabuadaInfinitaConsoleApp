using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTabuadaInfinita
{
    class GerandoTabuada
    {

        public void GerarTabuada(double a, double b, double c)
        {
            for (double i = 0; i <= b; i += c)
            {
                Console.WriteLine($"{a} X {i} = {a * i}");
            }

        }
    }
}
