using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje3
{
    internal class TreeNode
    {
        public string Name; // Balığın ismi
        public SubTree InfoTree; // Alt ağaç (kelimeler için)
        public TreeNode Left; // Sol çocuk
        public TreeNode Right; // Sağ çocuk

        public TreeNode(string name, string info)
        {
            Name = name;
            InfoTree = CreateInfoTree(info);
            Left = null;
            Right = null;
        }
        //alt ağacı oluşturan metod
        private SubTree CreateInfoTree(string info)
        {
            var words = info.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var subTree = new SubTree();
            foreach (var word in words)
            {
                subTree.Insert(word);
            }
            return subTree;
        }
        //tree nodu yazdıran metod
        public void PrintNodeSubTree()
        {
            Console.WriteLine($"Kelime Ağacı ({Name}):");
            if (InfoTree != null)
            {
               InfoTree.PrintSubTree(InfoTree.Root);
            }
            else
            {
                Console.WriteLine("Kelime ağacı boş.");
            }
        }

    }
}
