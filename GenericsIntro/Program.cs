﻿using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>(); // Generic yapı olduğu için tipi belirtilmeli
            isimler.Add("Engin");

            Console.WriteLine("Hello World!");
        }
    }
}
