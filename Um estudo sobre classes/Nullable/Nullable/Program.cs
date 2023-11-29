using System;

namespace Course {
    class Program {
        static void Main(string[] args) {
            // Estudando as tres formas de se utilizar o Nullable.

            double? x = null;
            double? y = 10;

            // Forma 1 de verificar se tem valor ou n. GetValueOrDefault qr dizer: pegue/mostre o numero que tem atribuido ou mostre o padrao do metodo, que no caso é 0.
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            // Forma 2 olha se tem valor, se tiver, mostre
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue) {
                // Forma 3 pede p mostrar, mas se o valor for nulo/null o programa da erro, por isso precisa da lógica de if.
                Console.WriteLine(x.Value);                
            }
            else {
                Console.WriteLine("X is null");
            }

            if (y.HasValue) {
                Console.WriteLine(y.Value);
            }
            else {
                Console.WriteLine("Y is null");
            }

            // Operador de coalescencia nula(??), se não tiver nada, ou seja, se for null ele adiciona o valor do lado.     
            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}