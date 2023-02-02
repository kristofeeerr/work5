using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Aleksey";
            int age = 21;
            var zodiacSign = "Aquarius";
            bool worksFactory = true;
            Console.WriteLine($"Вас зовут {name}. Вам {age} год. Ваш знак зодиака {zodiacSign}. " +
            $"Вы работаете на заводе - {worksFactory}.");
        }
    }
}
