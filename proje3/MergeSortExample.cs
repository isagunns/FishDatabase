using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje3
{
    public class MergeSortExample
    {
        // Merge Sort algoritmasını uyguluyoruz
        public static void MergeSort<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            // Eğer alt dizi birden fazla eleman içeriyorsa
            if (left < right)
            {
                // Ortadaki indeksi hesaplıyoruz
                int middle = left + (right - left) / 2;

                // Sol yarıyı sıralıyoruz
                MergeSort(array, left, middle);

                // Sağ yarıyı sıralıyoruz
                MergeSort(array, middle + 1, right);

                // Sıralanmış iki yarıyı birleştiriyoruz
                Merge(array, left, middle, right);
            }
        }

        // İki sıralı diziyi birleştirme işlemini yapıyoruz
        public static void Merge<T>(T[] array, int left, int middle, int right) where T : IComparable<T>
        {
            // Sol ve sağ alt dizilerin boyutlarını hesaplıyoruz
            int n1 = middle - left + 1;
            int n2 = right - middle;

            // Sol ve sağ alt diziler için yeni diziler oluşturuyoruz
            T[] leftArray = new T[n1];
            T[] rightArray = new T[n2];

            // Verileri ana diziden sol ve sağ dizilere kopyalıyoruz
            Array.Copy(array, left, leftArray, 0, n1);
            Array.Copy(array, middle + 1, rightArray, 0, n2);

            // Sol ve sağ dizilerin başlangıç indekslerini tanımlıyoruz
            int leftIndex = 0, rightIndex = 0;

            // Ana dizideki birleşim işlemi için başlangıç indeksini ayarlıyoruz
            int k = left;

            // İki alt diziyi karşılaştırarak ana diziye kopyalıyoruz
            while (leftIndex < n1 && rightIndex < n2)
            {
                if (leftArray[leftIndex].CompareTo(rightArray[rightIndex]) <= 0)
                {
                    array[k] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[k] = rightArray[rightIndex];
                    rightIndex++;
                }
                k++;
            }

            // Eğer sol dizide kalan elemanlar varsa, onları ana diziye ekliyoruz
            while (leftIndex < n1)
            {
                array[k] = leftArray[leftIndex];
                leftIndex++;
                k++;
            }

            // Eğer sağ dizide kalan elemanlar varsa, onları ana diziye ekliyoruz
            while (rightIndex < n2)
            {
                array[k] = rightArray[rightIndex];
                rightIndex++;
                k++;
            }
        }
    }
}