using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        interface Mammal
        {
            void GetMammal();
        }
        
        interface hoofed
        {
            void GetHoofed();
        }

        interface bird
        {
            void GetBird();
        }

        interface animal
        {
            void GetAnimal();
        }

        class lifeonearth : Mammal,hoofed,animal
        {
            public void GetMammal() { Console.WriteLine("Млекопитающие ходят по земле."); }
            public void GetHoofed() { Console.WriteLine("Парнокопытные скачут по земле."); }
            public void GetAnimal() { Console.WriteLine("Мы животные населяем всю планету."); }

        }
        
        class life : lifeonearth, bird
        {
            public void GetBird() { Console.WriteLine("Птицы летают по небу."); }
        }

        delegate void Message();

        public static void Main(string[] args)
        {
            Message mes;

            mes = Life;
            mes();

        }
        public static void Life()
        {
            life l = new life();

            l.GetMammal();
            l.GetHoofed();
            l.GetAnimal();
            l.GetBird();
        }
    }
}
