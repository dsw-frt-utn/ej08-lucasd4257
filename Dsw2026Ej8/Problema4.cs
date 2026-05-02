using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {

            if (nota1 == null && nota2 == null && nota3 == null)
            {
                return 0;
            }

            var notas = new List<int?> { nota1, nota2, nota3 };

            int numero = 0;
            double suma = 0;

            foreach (var nota in notas)
            {

                if (nota != null && nota >= 0 && nota <= 10)
                {
                    numero++;
                    suma += (double)nota;
                }

            }

            if (numero == 0)
            {
                return 0;
            }
            else
            {
                return suma / numero;
            }
            
        }
    }
}
