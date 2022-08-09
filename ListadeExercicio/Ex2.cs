
using System;

namespace ListadeExercicio
{
    class Ex2
    {
        public static void Renderizar()
        {
            /*Exercício 02
            Crie um algoritmo que permita fazer três conversões monetárias. O algoritmo devereceber o valor em real (R$) e apresentar os valores convertidos em:
            a) Dólar (1 dólar = 5,18 reais)
            b) Euro (1 euro = 5,31 reais)
            c) Peso argentino (1 peso argentino = 0,04 reais)*/

             Console.WriteLine("Digite o valor que deseja converter em reais: ");
             int real = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Digite a opção que deseja converter: 1-dolar 2-euro 3-peso");
             int op = Convert.ToInt32(Console.ReadLine());

             if(op == 1)
             {
                   double dolar = real / 5.18;
                   Console.WriteLine("Dolar: " + dolar);
             }else if (op == 2)
             {
                  double euro = real / 5.31;
                  Console.WriteLine("Euro: " + euro);
             }else if (op == 3)
             {
                  double peso = real / 5.31;
                  Console.WriteLine("Peso: " + peso);
             }else
             {
                 Console.Write("Digite uma opção...");
             }
        }
    }
}           
