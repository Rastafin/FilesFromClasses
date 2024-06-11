using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            M1();
            M2();

            Console.WriteLine("--------------");

            Class1 class1 = new Class1();
            M3(class1);
            M4(class1);

            Console.WriteLine("--------------");
            
            //M5();
            //M6();

            Console.WriteLine("--------------");

            //New thread
            Task.Run(()=> {
                M7();
            });

            //New thread
            Task.Run(() => {
                M8();
            });

            Console.WriteLine("--------------");

            Console.ReadKey();
        }

        static void M1() {

            Class1 class1 = new Class1();

            class1.X = 20;
            class1.Y = 31;

        }

        static void M2() {

            Class1 class1 = new Class1();

            Console.WriteLine(class1.Sum());
        }

        static void M3(Class1 class1)
        {
            class1.X = 30;
            class1.Y = 31;
        }

        static void M4(Class1 class1)
        {
            Console.WriteLine(class1.Sum());
        }

        static void M5()
        {
            var singleton = Singleton.GetInstance();

            singleton.X = 20;
            singleton.Y = 31;
        }

        static void M6()
        {
            var singleton = Singleton.GetInstance();

            Console.WriteLine(singleton.Sum());
        }

        static void M7()
        {
            var singleton = Singleton2.GetInstance();

            singleton.X = 20;
            singleton.Y = 31;
        }

        static void M8()
        {
            var singleton = Singleton2.GetInstance();

            Console.WriteLine(singleton.Sum());
        }

        static void M9()
        {
            var singleton = Singleton4.GetInstance(); 
            singleton.X = 102;

            Singleton4.GetInstance().X = 102;

            Singleton4.Instance.X = 102;
        }
    }
}
