using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HuffmanTree
{
    class Test
    {
        static void Main(string[] args)
        {
            HuffmanTree hTree = new HuffmanTree();
            hTree.addSorted("A", 3);
            hTree.addSorted("B", 3);
            hTree.addSorted("C", 2);
            hTree.addSorted("D", 4);
            hTree.addSorted("X", 3.5);
            hTree.addSorted("Z", 10);
            hTree.addSorted("K", 1);
            hTree.addSorted("E", 1);
            hTree.Display();
            hTree.CreateHuffmanTree();
            Console.WriteLine(hTree.Encode("AAAA"));
            Console.WriteLine(hTree.isDecode(""));

        }
    }
}
