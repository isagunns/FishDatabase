using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje3
{
    public class MaxHeap
    {
        private List<EgeDeniziB> elements = new List<EgeDeniziB>();

        public int Count => elements.Count;

        // Çocuğun indeksine göre ebeveynin indeksini hesaplıyoruz
        private int GetParentIndex(int childIndex) => (childIndex - 1) / 2;

        // Ebeveynin indeksine göre sol çocuğun indeksini hesaplıyoruz
        private int GetLeftChildIndex(int parentIndex) => 2 * parentIndex + 1;

        // Ebeveynin indeksine göre sağ çocuğun indeksini hesaplıyoruz
        private int GetRightChildIndex(int parentIndex) => 2 * parentIndex + 2;

        // İndeksin sol çocuk olup olmadığını kontrol ediyoruz
        private bool HasLeftChild(int index) => GetLeftChildIndex(index) < Count;

        // İndeksin sağ çocuk olup olmadığını kontrol ediyoruz
        private bool HasRightChild(int index) => GetRightChildIndex(index) < Count;

        // İndeksin kök düğüm olup olmadığını kontrol ediyoruz
        private bool IsRoot(int index) => index == 0;

        // Çocuğun ebeveynini getiriyoruz
        private EgeDeniziB GetParent(int childIndex) => elements[GetParentIndex(childIndex)];

        // Ebeveynin sol çocuğunu getiriyoruz
        private EgeDeniziB GetLeftChild(int parentIndex) => elements[GetLeftChildIndex(parentIndex)];

        // Ebeveynin sağ çocuğunu getiriyoruz
        private EgeDeniziB GetRightChild(int parentIndex) => elements[GetRightChildIndex(parentIndex)];

        // İki elemanın yerlerini değiştiriyoruz
        private void Swap(int index1, int index2)
        {
            var temp = elements[index1];
            elements[index1] = elements[index2];
            elements[index2] = temp;
        }

        // Yeni bir eleman ekliyoruz ve heap yapısını güncelliyoruz
        public void Add(EgeDeniziB element)
        {
            elements.Add(element);
            HeapifyUp();
        }

        // Heap'in kök elemanını getiriyoruz
        public EgeDeniziB Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException("Heap is empty");

            return elements[0];
        }

        // Kök elemanı çıkarıyoruz ve heap yapısını güncelliyoruz
        public EgeDeniziB Pop()
        {
            if (Count == 0)
                throw new InvalidOperationException("Heap is empty");

            var result = elements[0];
            elements[0] = elements[Count - 1];
            elements.RemoveAt(Count - 1);
            HeapifyDown();
            return result;
        }

        // Yeni eklenen elemanı yukarı taşıyoruz
        private void HeapifyUp()
        {
            int index = Count - 1;
            while (!IsRoot(index) && string.Compare(elements[index].balik_Adi, GetParent(index).balik_Adi, StringComparison.OrdinalIgnoreCase) > 0)
            {
                int parentIndex = GetParentIndex(index);
                Swap(index, parentIndex);
                index = parentIndex;
            }
        }

        // Kökten başlayarak elemanları doğru pozisyona taşıyoruz
        private void HeapifyDown()
        {
            int index = 0;

            while (HasLeftChild(index))
            {
                int largerChildIndex = GetLeftChildIndex(index);

                if (HasRightChild(index) && string.Compare(GetRightChild(index).balik_Adi, GetLeftChild(index).balik_Adi, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    largerChildIndex = GetRightChildIndex(index);
                }

                if (string.Compare(elements[largerChildIndex].balik_Adi, elements[index].balik_Adi, StringComparison.OrdinalIgnoreCase) <= 0)
                {
                    break;
                }

                Swap(index, largerChildIndex);
                index = largerChildIndex;
            }
        }

        // Heap'teki tüm elemanları sırayla yazdırıyoruz
        public void PrintHeap()
        {
            foreach (var element in elements)
            {
                Console.WriteLine(element.balik_Adi);
            }
        }
    }
}
