using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Globalization;

namespace Conversor {
    class CoversorDeMoeda {
        public static double Iof = 6;
        public static double DolarParaReal(double quantia, double cotacao) {
            double total = quantia * cotacao;
            return total + total * (Iof / 100);
        }
    }
}
