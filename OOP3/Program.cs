using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService fileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(),
                new List<ILoggerService>() { new DatabaseLoggerService(), new SmsLoggerService() });

            List<IKrediManager> krediler = new List<IKrediManager>()
            {
                ihtiyacKrediManager,//added
                tasitKrediManager,
                konutKrediManager,
                esnafKrediManager
            };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
