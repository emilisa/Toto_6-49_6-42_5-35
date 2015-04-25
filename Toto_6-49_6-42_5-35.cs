using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Toto_6_49
{
    class Toto_6_49
    {
        /// <ToTo>
        /// Program that prints all possible combinations of ToTo Sport
        /// 5/35, 6/69 and 6/42.
        /// Also counts how many unique combinations can be made
        /// NOTE: Printing of cobinations itself is disabled becouse is much slower than 
        /// only counting the unique combinations possibilities. 
        /// However it can be used if needed
        /// In the program are included timers to show how fast calculations are.
        /// </ToTo>

        //Global variables:
        
        static int number;
        static int combination;
        static int counter;        
        static Stopwatch sw;
        
        static void Main()
        {
            sw = new Stopwatch();

            sw.Start();            
            
            //Toto5_35();

            //Toto5_35_Variant();

            //Toto6_49();

            Toto6_42();

            sw.Stop();
        }

        static void Toto6_42()
        {
            number = 42;

            combination = 6;

            counter = 0;
            
            for (int t1 = 1; t1 <= number; t1++)
            {
                for (int t2 = 1; t2 <= number; t2++)
                {
                    for (int t3 = 1; t3 <= number; t3++)
                    {
                        for (int t4 = 1; t4 <= number; t4++)
                        {
                            for (int t5 = 1; t5 <= number; t5++)
                            {
                                for (int t6 = 1; t6 <= number; t6++)
                                {
                                    if (t1 < t2 && t2 < t3 && t3 < t4 
                                        && t4 < t5 && t5 < t6)
                                    {
                                        //Console.WriteLine("{0} {1} {2} {3} {4} {5}", t1, t2, t3, t4, t5, t6 );
                                        //Makes program very slow because printing on the console takes time

                                        counter++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            UserFriendlyTextOutput(number, combination, counter, sw);
        }

        static void Toto6_49()
        {
            number = 49;

            combination = 6;

            counter = 0;
            
            for (int com1 = 1; com1 <= number; com1++)
            {
                for (int com2 = 1; com2 <= number; com2++)
                {
                    for (int com3 = 1; com3 <= number; com3++)
                    {
                        for (int com4 = 1; com4 <= number; com4++)
                        {
                            for (int com5 = 1; com5 <= number; com5++)
                            {
                                for (int com6 = 1; com6 <= number; com6++)
                                {
                                    if (com1 < com2 && com2 < com3 && com3 < com4 
                                        && com4 < com5 && com5 < com6)
                                    {
                                        //Console.WriteLine("{0} {1} {2} {3} {4} {5}", com1, com2, com3, com4, com5, com6);
                                        //Makes program very slow because printing on the console takes time

                                        counter++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            UserFriendlyTextOutput(number, combination, counter, sw);
        }

        static void Toto5_35()
        {
            number = 35;

            combination = 5;

            counter = 0;
            
            for (int a = 1; a <= number-4; a++)
            {
                for (int b = 1; b <= number-3; b++)
                {
                    for (int c = 1; c <= number-2; c++)
                    {
                        for (int d = 1; d <= number-1; d++)
                        {
                            for (int e = 1; e <= number; e++)
                            {
                                if (a < b && b < c && c < d && d < e)
                                {
                                    //Console.WriteLine("{0} {1} {2} {3} {4}", a, b, c, d, e);
                                    //Makes program very slow because printing on the console takes time

                                   counter++;
                                }
                                
                            }
                        }
                    }
                }
            }

            UserFriendlyTextOutput(number, combination, counter, sw);
        }

        static void Toto5_35_Variant()
        {
            number = 35;

            combination = 5;

            counter = 0;

            for (int a = 1; a <= number - 4; a++)
            {
                for (int b = a + 1; b <= number - 3; b++)
                {
                    for (int c = b + 1; c <= number - 2; c++)
                    {
                        for (int d = c + 1; d <= number - 1; d++)
                        {
                            for (int e = d + 1; e <= number; e++)
                            {
                                //Console.WriteLine("{0} {1} {2} {3} {4}", a, b, c, d, e);
                                //Makes program very slow because printing on the console takes time

                                counter++;
                            }
                        }
                    }
                }
            }

            UserFriendlyTextOutput(number, combination, counter, sw);
        }

        static void UserFriendlyTextOutput(int number, int combination, int counter, Stopwatch sw)
        {

            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine("Number of combinations in TOTO {0} / {1} = {2}", combination, number, counter);

            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine("Claculating time: {0}", sw.Elapsed);

            Console.WriteLine("--------------------------------------------------------------");

            //Bulgarian language explanation of digit lottary games

            Console.WriteLine("Тото е типична числова лотария.\n"
            + "От матема­тическа гледна точка,\n"
            + "този вид лотарии се поддават много\n"
            + "лесно на математически анализ.\n"
            + "За целта се използва 'Теорията на\n"
            + "вероятностите' и по-конкретно онази\n"
            + "част от нея, която се нарича 'Комбинаторика\n'"
            + "Като опорна формула за изчисление служи следния\n"
            + "мате­ма­ти­чески израз:C(k,n)= n(n-1)(n-2)(n-3)....(n-k+1)/k!\n"
            + "горния израз служи за изчисляване броя на комбинациите на\n"
            + "k числа от n възможни.Тук с буквата k са означени броя на\n"
            + "числата, които се теглят в тиража, а с буквата n са означени\n"
            + "броя на всички числа които могат да бъдат изтеглени\n"
            + "За конкретен пример да вземем най-популярния вариант на тотото 6 от 49.\n"
            + "В този конкретен случай k=6, n=49 Колко са всичките\n"
            + "комбинации на 6 числа от 49 възможни? Като приложим горната формула\n"
            + "ще получим: C(6,49) = 49.48.47.46.45.44/1.2.3.4.5.6 = 13 983 816\n"
            + "Формулата се прилага изключително про­с­то. Трябва само да умножите\n"
            + "последните k числа от всичките възможни n числа и получения резултат\n"
            + "да разделите на произведението от първите k числа. В нашия случай\n"
            + "умножаваме последните 6 числа и разделяме на произве­дени­ето\n"
            + "на първите 6 числа. За тото 5 от 35 ще получим съответно:\n"
            + "C(5,35) = 35.34.33.32.31/1.2.3.4.5 = 324 632\n"
            + "За тото 6 от 42 резултатът ще е:\n"
            + "C(6,42) = 42.41.40.39.38.37/1.2.3.4.5.6 = 5 245 786\n");
        }

    }
}
