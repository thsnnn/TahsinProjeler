using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList() //constructor metod / ctor yazıp taba bas
                        //program çalıştığında çalışır
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; // temp geçici dizi, newlenince referans
                                   // kaybolmasın diye
            items = new T[items.Length + 1]; // Dizinin eleman
                                             // sayısını bir arttırdık
                // for ile elemanları tempArrayden item e çekiyoruz
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; // Elemanı şuan ekledik

        }
    }
}
