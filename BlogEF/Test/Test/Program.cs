//
// Escreva o corpo do método Calc(array, n1, n2).
//
//     Array é um array de inteiro.
//      Os parâmetros n1 e n2 são inteiros definidos pela relação 0 <= n1 <= n2 < array.Length
//
//  O método Calc deve retornar a soma dos inteiros do array cujo índice pertence ao
//  intervalo [n1;n2]


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Test
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] array = {0,1,2,3,4,5,3};
            var n1 = 0;
            var n2 = 4;

            Calc(array, n1, n2);
        }
        
        // <returns>the sum of integers whose index is between n1  n2</returns>
        private static void Calc(int[] array, int n1, int n2)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            int y= 0;
            int t = array.Select(x=> (int.TryParse(x.ToString(), out y) ? y : 0)).Sum();

            Console.WriteLine("\n t = {0}", t); // t = 6
        }
    }

}
// Escreva o corpo do método Calc(array, n1, n2)
// array é um array de inteiros. Os parâmetros n1 e n2 são inteiros definidos pela relação 0 <= n1 <= n2 < array.Comprimento
// O método calc deve retornar a soma dos inteiros de um array cujo índice pertence a [n1; n2] intervalo