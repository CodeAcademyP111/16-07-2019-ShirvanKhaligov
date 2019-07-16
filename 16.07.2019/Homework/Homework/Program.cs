using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region HomeWorkShehla
            //Card card = new Card(60);


            //card.NotEnough += delegate (double n, double m) {
            //    Console.WriteLine($"Balansinizdan {n} qeder vesait cixara bilersiniz ");
            //};
            //card.GetMoney(70);
            #endregion

            Thread threadLoop1 = new Thread(Loop1);
            Thread threadLoop2 = new Thread(Loop2);
            threadLoop2.Start();
            threadLoop2.Join();
            threadLoop1.Start();

            



        }

        static void Loop1()
        {
            for (int i = 0; i < 100; i++)
            {
                
                //Thread.Sleep(1000);
                Console.WriteLine("First "+i);
            }
        }

        static void Loop2()
        {
            for (int i = 0; i < 100; i++)
            {
                //Thread.Sleep(1000);
                Console.WriteLine("Second "+i);
            }
        }

    }

    


    #region HomeWorkShehla
    //class Card
    //{
    //    public event Action<double, double> NotEnough;
    //    public double Money { get; private set; }


    //    public Card(double n)
    //    {
    //        Money = n;
    //    }

    //    public void GetMoney(double money)
    //    {
    //        if (Money >= money)
    //        {
    //            Console.WriteLine("Emeliyyat ugurla yerine yetirilmisdir");
    //        }
    //        else
    //        {
    //            NotEnough?.Invoke(Money, money);
    //        }

    //    }

    //}
    #endregion

}
