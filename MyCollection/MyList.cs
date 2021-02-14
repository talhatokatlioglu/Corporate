using System;
using System.Collections.Generic;
using System.Text;

namespace MyCollection
{
    class MyList<T> // T takma ad başka şeylerde yazılabilirdi bu kullanıcı ne isterse o tipte çalış demektir
    {
        T[] items;//MyList cagrıldıgı anda arrayi oluşturulur
        public MyList() // Consructor MyList newlendigi anda çalışacak fonksiyondur
        {
            items = new T[0]; // Koleksiyonlar arkada bir array çalıştırır ve ilk array 0 elemanlıdır
        }
        public void Add(T item) // İtem ekleme fonskiyonu 
        {
            T[] tempItems = items; // items in elemanlarını gecici olarak tempItems e veririz.Aslında burda referans numarasını veririz ve eski itemelri tutar
            items = new T[items.Length + 1]; // yeni bir items arrayi oluştururuz ama oncekinden 1 fazla elemanlısını

            for (int i = 0; i < tempItems.Length; i++) //Sonra tempItemstan tum elemanları almak içi tempItems kadar dondururuz
            {
                items[i] = tempItems[i]; // Gecici olarak verdigimiz elemanları items a alırız
            }

            items[items.Length - 1] = item; // Kullanıcıdan gelen item ı items ın son elemanına koyarız.
        }

        public int Length
        {
            get { return items.Length; } //items ın uzunlugu bilgisini dondurur kullanılmak uzere
        }
        public T[] Items
        {
            get { return items; } // items ın itemlerini dondurur.Kullanılmak uzere
        }
    }
}
