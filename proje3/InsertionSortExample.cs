using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje3
{
    class InsertionSortExample
    {
        // Bu metot, verilen bir dizi üzerinde sıralama yapıyor.
        public static void InsertionSort(int[] array)
        {
            int n = array.Length; // Dizinin uzunluğunu alıyoruz.

            // 1. elemandan başlayarak diziyi sıralıyoruz.
            for (int i = 1; i < n; i++)
            {
                // Şu anki elemanı number değişkenine alıyoruz.
                int number = array[i]; // İlk olarak dizinin 2. elemanını seçiyoruz (i = 1).
                int j = i - 1; // Dizinin bir önceki indeksine bakıyoruz (j = 0).

                // Seçtiğimiz elemanı doğru yerine yerleştiriyoruz.
                while (j >= 0 && array[j] > number) // Eğer dizideki önceki eleman, seçtiğimiz elemandan büyükse
                {
                    array[j + 1] = array[j]; // Elemanları bir adım sağa kaydırıyoruz.
                    j--; // Bir önceki elemanı kontrol etmeye devam ediyoruz.
                }

                // Doğru pozisyona seçtiğimiz elemanı yerleştiriyoruz.
                array[j + 1] = number;
            }
        }
    }
}

