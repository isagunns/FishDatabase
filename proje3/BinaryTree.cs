using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace proje3
{
    // Bu sınıf ikili ağaç yapısını temsil ediyor
    internal class BinaryTree
    {
        // Ağacın en tepe noktası (kök düğüm)
        public TreeNode Root;

        // Toplam derinlik bilgisi (isteğe bağlı bir şey)
        public int totalDepth = 0;

        // Başlangıçta ağacı oluşturuyoruz, kök düğüm yok
        public BinaryTree()
        {
            Root = null;
        }

        // Yeni bir balık ekliyoruz
        public void Insert(EgeDeniziB fish)
        {
            // Eğer ağaç boşsa, yeni balığı kök yapıyoruz
            if (Root == null)
            {
                Root = new TreeNode(fish.balik_Adi, fish.bilgi);
            }
            else
            {
                // Eğer kök doluysa uygun yere ekliyoruz
                Insert(Root, fish);
            }
        }

        // Yeni balığı ağaca eklemek için yardımcı metodumuz
        private void Insert(TreeNode node, EgeDeniziB fish)
        {
            // Balık isimlerini karşılaştırıyoruz (alfabetik sıralama için)
            if (string.Compare(fish.balik_Adi, node.Name) < 0)
            {
                // Daha küçükse sol tarafa gidiyoruz
                if (node.Left == null)
                {
                    node.Left = new TreeNode(fish.balik_Adi, fish.bilgi);
                }
                else
                {
                    Insert(node.Left, fish);
                }
            }
            else if (string.Compare(fish.balik_Adi, node.Name) > 0)
            {
                // Daha büyükse sağ tarafa gidiyoruz
                if (node.Right == null)
                {
                    node.Right = new TreeNode(fish.balik_Adi, fish.bilgi);
                }
                else
                {
                    Insert(node.Right, fish);
                }
            }
        }

        // Ağacı sırayla ekrana yazdırıyoruz (in-order traversal)
        public void PrintTree()
        {
            PrintTree(Root);
        }

        // Yazdırma işlemi için yardımcı metot
        public void PrintTree(TreeNode node)
        {
            if (node != null)
            {
                // Önce sol tarafı yazdırıyoruz
                PrintTree(node.Left);

                // Mevcut düğümün adını ve bilgilerini yazdırıyoruz
                Console.WriteLine($"Balık Adı: {node.Name}");

                // Bilgiyi tutan alt ağacı yazdırıyoruz
                Console.WriteLine("Bilgi Metni Kelimeleri:");
                node.InfoTree.PrintSubTree(node.InfoTree.Root);

                // Alt ağacın istatistiklerini ekrana yazdırıyoruz
                int subTreeNodeCount = node.InfoTree.GetNodeCount();
                int subTreeDepth = node.InfoTree.GetDepth();
                int subTreeBalancedDepth = node.InfoTree.GetBalancedTreeDepth();

                Console.WriteLine($"Alt Ağacın Düğüm Sayısı: {subTreeNodeCount}");
                Console.WriteLine($"Alt Ağacın Gerçek Derinliği: {subTreeDepth}");
                Console.WriteLine($"Dengeli Bir Alt Ağacın Derinliği: {subTreeBalancedDepth}");

                // Sonra sağ tarafı yazdırıyoruz
                PrintTree(node.Right);
            }
        }

        // Ağacı sırayla gezip tüm düğümleri listeye atıyoruz
        public List<TreeNode> GetTreeNodesInOrder()
        {
            List<TreeNode> treeNodes = new List<TreeNode>();
            GetTreeNodesInOrder(Root, treeNodes);
            return treeNodes;
        }

        // Ağacı sırayla gezmek için yardımcı metodumuz
        private void GetTreeNodesInOrder(TreeNode node, List<TreeNode> treeNodes)
        {
            if (node != null)
            {
                // Sol tarafı işliyoruz
                GetTreeNodesInOrder(node.Left, treeNodes);

                // Mevcut düğümü listeye ekliyoruz
                treeNodes.Add(node);

                // Sağ tarafı işliyoruz
                GetTreeNodesInOrder(node.Right, treeNodes);
            }
        }

        // Ağacın toplam derinliğini hesaplıyoruz
        public int GetDepth()
        {
            return GetDepth(Root);
        }

        // Derinlik hesaplamak için yardımcı metodumuz
        private int GetDepth(TreeNode node)
        {
            if (node == null)
                return 0;
            return 1 + Math.Max(GetDepth(node.Left), GetDepth(node.Right));
        }

        // Ağacın toplam düğüm sayısını hesaplıyoruz
        public int GetNodeCount()
        {
            return CountNodes(Root);
        }

        // Düğüm sayısını hesaplamak için yardımcı metodumuz
        private int CountNodes(TreeNode node)
        {
            if (node == null) return 0;
            return 1 + CountNodes(node.Left) + CountNodes(node.Right);
        }

        // Eğer ağaç dengeli olsaydı derinliği ne olurdu onu hesaplıyoruz
        public int GetBalancedTreeDepth()
        {
            int nodeCount = GetNodeCount();
            return (int)Math.Ceiling(Math.Log2(nodeCount + 1));
        }

        // Tüm alt ağaçların ortalama derinliğini hesaplıyoruz
        public double GetAverageDepthOfAllSubTrees()
        {
            double totalAverageDepth = 0;
            int fishCount = 0;
            CalculateAverageDepth(Root, ref totalAverageDepth, ref fishCount);
            return fishCount == 0 ? 0 : totalAverageDepth / fishCount;
        }

        // Ortalama derinlik hesaplamak için yardımcı metodumuz
        private void CalculateAverageDepth(TreeNode node, ref double totalAverageDepth, ref int fishCount)
        {
            if (node != null)
            {
                // Mevcut düğümün alt ağacını dahil ediyoruz
                totalAverageDepth += node.InfoTree.GetAverageDepth();
                fishCount++;

                // Sol ve sağ taraflara geçiyoruz
                CalculateAverageDepth(node.Left, ref totalAverageDepth, ref fishCount);
                CalculateAverageDepth(node.Right, ref totalAverageDepth, ref fishCount);
            }
        }

        // Belirli harfler arasındaki balık isimlerini bulma metodu
        public void GetFishNamesInRange(TreeNode node, char start, char end, List<string> result)
        {
            if (node == null)
                return;

            // Balık adının ilk harfini büyük harf olarak alıyoruz
            char firstLetter = char.ToUpper(node.Name[0]);

            // Eğer aralıkta olabilecek bir düğümse sola gidiyoruz
            if (firstLetter >= start)
            {
                GetFishNamesInRange(node.Left, start, end, result);
            }

            // Eğer tam aralıkta bir düğümse listeye ekliyoruz
            if (firstLetter >= start && firstLetter <= end)
            {
                result.Add(node.Name);
            }

            // Eğer aralıkta olabilecek bir düğümse sağa gidiyoruz
            if (firstLetter <= end)
            {
                GetFishNamesInRange(node.Right, start, end, result);
            }
        }
    }
}
