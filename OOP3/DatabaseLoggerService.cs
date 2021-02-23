using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService
    {
        
        public void Log()
        {
            //interface için de sadece imza metotları olur içi dolu olamaz


            Console.WriteLine("Veritabanına loglandı");
        }
    }

    
}
