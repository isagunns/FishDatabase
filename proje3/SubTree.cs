using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje3
{
    internal class SubTree
    {
        public SubTreeNode Root;

        // Başlangıçta bir alt ağaç oluşturuyoruz ve kök düğümümüzü boş yapıyoruz
        public SubTree()
        {
            Root = null;
        }

        // Alt ağaca yeni bir kelime ekliyoruz
        public void Insert(string word)
        {
            // Eğer kök düğüm yoksa, ilk kelimeyi kök yapıyoruz
            if (Root == null)
            {
                Root = new SubTreeNode(word);
            }
            else
            {
                // Kök varsa, kelimeyi uygun yere ekliyoruz
                Insert(Root, word);
            }
        }

        private void Insert(SubTreeNode node, string word)
        {
            // Eğer eklemek istediğimiz kelime, mevcut düğümdeki kelimeden küçükse
            if (string.Compare(word, node.Word) < 0)
            {
                // Sol tarafa ekliyoruz
                if (node.Left == null)
                {
                    node.Left = new SubTreeNode(word);
                }
                else
                {
                    Insert(node.Left, word);
                }
            }
            // Eğer kelime mevcut düğümdekinden büyükse
            else if (string.Compare(word, node.Word) > 0)
            {
                // Sağ tarafa ekliyoruz
                if (node.Right == null)
                {
                    node.Right = new SubTreeNode(word);
                }
                else
                {
                    Insert(node.Right, word);
                }
            }
        }

        // Alt ağacı yazdırıyoruz
        public void PrintSubTree(SubTreeNode node)
        {
            if (node != null)
            {
                // Önce sol alt ağacı yazdırıyoruz
                PrintSubTree(node.Left);

                // Daha sonra mevcut düğümdeki kelimeyi yazdırıyoruz
                Console.WriteLine($"  - {node.Word}");

                // En son sağ alt ağacı yazdırıyoruz
                PrintSubTree(node.Right);
            }
        }

        // Alt ağacın derinliğini hesaplıyoruz
        public int GetDepth()
        {
            return GetDepth(Root);
        }

        private int GetDepth(SubTreeNode node)
        {
            // Eğer düğüm boşsa derinlik sıfırdır
            if (node == null)
                return 0;

            // Sol ve sağ alt ağaçların derinliğini hesaplayıp büyük olanı alıyoruz
            return 1 + Math.Max(GetDepth(node.Left), GetDepth(node.Right));
        }

        // Alt ağaçtaki toplam düğüm sayısını hesaplıyoruz
        public int GetNodeCount()
        {
            return CountNodes(Root);
        }

        private int CountNodes(SubTreeNode node)
        {
            // Eğer düğüm boşsa, düğüm sayısı sıfırdır
            if (node == null) return 0;

            // Sol ve sağ alt ağaçların düğüm sayısını toplayıp kök düğümle birlikte döndürüyoruz
            return 1 + CountNodes(node.Left) + CountNodes(node.Right);
        }

        // Dengeli bir ağaç olması durumunda derinliği hesaplıyoruz
        public int GetBalancedTreeDepth()
        {
            int nodeCount = GetNodeCount();

            // Dengeli bir ağaçta maksimum derinlik, düğüm sayısının log2'sidir
            return (int)Math.Ceiling(Math.Log2(nodeCount + 1));
        }

        // Ortalama derinliği hesaplıyoruz
        public double GetAverageDepth()
        {
            int totalDepth = 0;
            int totalNodes = 0;

            // Toplam derinlik ve toplam düğüm sayısını hesaplıyoruz
            CalculateDepthAndCount(Root, 1, ref totalDepth, ref totalNodes);

            // Ortalama derinlik = toplam derinlik / toplam düğüm sayısı
            return totalNodes == 0 ? 0 : (double)totalDepth / totalNodes;
        }

        private void CalculateDepthAndCount(SubTreeNode node, int currentDepth, ref int totalDepth, ref int totalNodes)
        {
            if (node != null)
            {
                // Mevcut derinliği toplam derinliğe ekliyoruz
                totalDepth += currentDepth;

                // Düğüm sayısını artırıyoruz
                totalNodes++;

                // Sol ve sağ alt ağaçlar için aynı işlemi yapıyoruz
                CalculateDepthAndCount(node.Left, currentDepth + 1, ref totalDepth, ref totalNodes);
                CalculateDepthAndCount(node.Right, currentDepth + 1, ref totalDepth, ref totalNodes);
            }
        }
    }
}