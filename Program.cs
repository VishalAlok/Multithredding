using System;
using System.Threading;
public class ThreadExample
{
    public static void test1()
    {
        for(int i = 0; i<= 100; i++)
        {
            Console.WriteLine("test1 : " + i);
        }
    }
    public static void test2()
    {
        for (int i = 0; i <= 100; i++)
        {
            Console.WriteLine("test2  : " + i);

            if(i == 50)
            {
                Thread.Sleep(15000);
            }
        }
    }
    public static void test3()
    {
        for (int i = 0; i <= 100; i++)
        {
            Console.WriteLine("test3  : " + i);
        }
    }
    public static void Main(string[] args)
    {
        Thread t1 = new Thread(test1);
        Thread t2= new Thread(test2);
        Thread t3 = new Thread(test3);
        t1.Start();
        t2.Start();
        t3.Start();
    }
}