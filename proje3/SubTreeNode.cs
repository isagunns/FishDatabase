using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje3
{
    internal class SubTreeNode
    {
        public string Word; // Kelime
        public SubTreeNode Left; // Sol çocuk
        public SubTreeNode Right; // Sağ çocuk

        public SubTreeNode(string word)
        {
            Word = word;
            Left = null;
            Right = null;
        }
    }
}
