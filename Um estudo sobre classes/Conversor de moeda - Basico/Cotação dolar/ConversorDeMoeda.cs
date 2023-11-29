using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Globalization;

namespace Conversor {
    class ConversorDeMoeda {
        public static double Iof = 4.87; // Cotação do dólar dia 29/11/23.

        // Código de Conversão
        public static double DolarParaReal(double quantia, double cotacao) {
            double total = quantia * cotacao;
            return total + total * (Iof / 100);
        }
    }
}
