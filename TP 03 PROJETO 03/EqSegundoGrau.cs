using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_03_PROJETO_03
{
    public class EqSegundoGrau
    {
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }

        public string CalcDelta()
        {
            double delta = Math.Pow(float.Parse(B), 2) - 4 * float.Parse (A) * float.Parse(C);

            MessageBox.Show ($"Delta: {delta}");
            return $"{delta}";
        }
        // Método para calcular a primeira raiz (x1) de uma equação de segundo grau
        public string CalcX1()
        {
            double delta = Math.Pow(float.Parse(B), 2) - 4 * float.Parse(A) * float.Parse(C);
            if (delta < 0)
            {
                MessageBox.Show("A equação não possui a primeira raíz X1.");
            }

            double X1 = (- float.Parse(B) + Math.Sqrt(delta)) / (2 * float.Parse(A));
            return $"{X1}";
        }

        // Método para calcular a segunda raiz (x2) de uma equação de segundo grau
        public string CalcX2()
        {
            double delta = Math.Pow(float.Parse(B), 2) - 4 * float.Parse(A) * float.Parse(C);
            if (delta < 0)
            {
                MessageBox.Show("A equação não possui a segunda X2.");
            
            }

            double X2 = (-float.Parse(B) - Math.Sqrt(delta)) / (2 * float.Parse(A));
            return $"{X2}";
        }
    }
}



