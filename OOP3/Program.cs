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
            IKrediManager esnafKredimanager = new EsnafKredisiManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();//Loglama alternatifleri
            ILoggerService fileLoggerService = new FileLoggerService();//Loglama alternatifleri
            
            
            // Yukarıdakiler banka görevlisinin seçebileceği kutu görevi görevi görüyor.

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.Basvuruyap(esnafKredimanager, new SmsLoggerService());//basvuru yap a gönderme kısmını buradan yapıyoruz.
            //istersek yukarıdaki gibi parantez içinde instance oluşturabiliyoruz
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager,esnafKredimanager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
