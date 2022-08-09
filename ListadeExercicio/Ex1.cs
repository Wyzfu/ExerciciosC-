using System;

namespace ListadeExercicio
{
    class Ex1
    {
        public static void Renderizar()
        {
            /*Exercício 01
            Escrever um algoritmo que receba a altura e a largura de um retângulo e calcule a sua área.*/

            Console.WriteLine("Escreva a altura do triangulo: "); //comando q escreve uma mensagem no terminal
            /*int32 = converte para inteiro ao inves de string*/
             int altura = Int32.Parse( Console.ReadLine()); //le a informaçao digitada e guarda

              /*UM MODELO DIFERENTE DO OUTRO*/

            Console.WriteLine("Escreva a largura do triangulo: ");
             /*Conversão de string para um valor inteiro com convert*/
             int largura =Convert.ToInt32(Console.ReadLine());

            int area = altura * largura ;

            Console.WriteLine("Area: " + area); /*com contotenação*/ 
            Console.WriteLine($"Area:  {area}");  /*interpolação:  mais facil para grandes textos*/


            /*MODELO NORMAL DO CONSOLE.READLINE:
            string x = Console.ReadLine();
            */
        }
    }
}           