using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService   //bi metin dosyasına bi formatta yazmak istiyoruz
    {
        public void Log()
        {
            
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
