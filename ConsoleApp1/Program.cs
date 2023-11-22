using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int month1, month2, money=0;
            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.WriteLine("enter month1 &month2");
            //    month1 = int.Parse(Console.ReadLine());
            //    month2 = int.Parse(Console.ReadLine());
            //    ;
            //    if (month1 >100 && month2 >100)
            //    {
            //        if (month1 - month2 > 20)                 
            //            money = month2 * 2 -65; 
            //        if (month1 - month2 > 10 && month1 - month2 < 20)                  
            //            money = month2 * 2 + 15 - 50;                   
            //        if(month1-month2<10)
            //            money = month2 * 2 + 15;
            //    }
            //    Console.WriteLine($"the money is:{money}");


            //}

            //תרגיל שני
            int numcheck, possitive, negetive, border,count=0,maxpos=0,sumpos=0,
                sumbor=0,countbor=0,numcheck1=0,countcheck=0;
            bool flag= false;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("enter num of checks");
                numcheck = int.Parse(Console.ReadLine());
                for (int j = 0; i <= numcheck; i++)
                {
                    Console.WriteLine("enter 1 2 3 ");
                possitive= int.Parse(Console.ReadLine());
                negetive= int.Parse(Console.ReadLine());        
                border = int.Parse(Console.ReadLine());
                count++;
                    if(possitive>maxpos)
                    maxpos = possitive;
                sumpos = possitive;
                sumpos++;
                    sumbor = border;
                sumbor++;
                    if (numcheck > numcheck1)
                        countcheck++;
                            numcheck= numcheck1;
 if(possitive>negetive)
                        flag= true;
                

                }



            }
            Console.WriteLine($"count{count}");
            Console.WriteLine($"maxpos{maxpos}");
            Console.WriteLine($"sumpos{sumpos}");
            Console.WriteLine($"everage{sumbor/30}");
            Console.WriteLine($"countcheck{countcheck}");
            if(flag==true)
                Console.WriteLine($"{ flag}");
        }
    }
}
