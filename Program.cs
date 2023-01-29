using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Alcoólica_para_Drinks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Qual a porcentagem de álcool da sua bebida alcoólica?");
            float porcentagemBase = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine(" Qual porcentagem de álcool você quer no seu drink");
            float porcentagemFinal = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine(" Quantos mL seu drink terá?");
            float volumeFinal = float.Parse(Console.ReadLine());
            Console.Clear();

            float numDiv1 = 1000 * porcentagemFinal / porcentagemBase;
            float numDiv2 = volumeFinal / 1000;
            float numMult = numDiv1 * numDiv2;

            Console.WriteLine(" Coloque " + numMult + " mL da sua bebida alcoólica de " + porcentagemBase + 
                "%, para \n preparar seu drink de " + volumeFinal + "mL, com " + porcentagemFinal + "% de alcool!");
            Console.ReadLine();
        }
    }
}
