using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // burası şuanda kredi bağımsız halde 
        // ILoggerService yazarak--Method injection yapıyoruz-yani hangi kredi türü olacağını hangi logu kullanacağını enjekte ediyoruz.Somut halleriyle
        public void Basvuruyap(IKrediManager krediManager, ILoggerService loggerService) // Hangi kredi türünü gönderirsen onun hesapla kısmı çalışır
                                                        //List<ILoggerService> yazarsak birden fazla log seçeneği seçebiliriz.
        {
            // Basvuran bilgilerini değerlendiririz
            //Kredi hesaplarız
            //Doğru kullanım değil //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //Doğru kullanım değil //konutKrediManager.Hesapla();
            // biden fazla log için aşşağıdaki kullanım ama programcs üzerinde list eklemen lazım basvuru yap 
            //5. dersin 2 saat 45 dk sında
            //foreach (var loggerService in loggerService)
            //{
            //    loggerService.log();
            //}

            krediManager.Hesapla();
            loggerService.Log();

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) // bu listenin türü IKrediManager
        {
            foreach (var kredi in krediler) // Burda kredileri dönüp List<IKrediManager> a gönderdiklerimizi hesaplıyor.
            {
                kredi.Hesapla();

            }
        }


    }
}
