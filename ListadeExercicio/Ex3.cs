using System;

namespace ListadeExercicio
{
    class Ex3
    {
        public static void Renderizar()
        {
            /*Exercício 03
            Receber dois números inteiros e informar qual valor lido é o menor e qual é o maior*/

              Console.WriteLine("Digite um valor: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            if(valor1 > valor2)
            {
                Console.WriteLine("O primeiro valor é o maior!");
            }else{
                Console.WriteLine("O segundo valor é o maior");
            }
        }
    }
}           