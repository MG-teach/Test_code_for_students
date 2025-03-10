using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1_test
{
    internal class Chase
    {
        private List<Stone> path;

        public Chase(List<Stone> stones)
        {
            this.path = stones;
        }

        public void FindStone(int target)
        {
            Sort();
            
            int result = BinarySearch(path, target);
            if (result != -1)
            {
                if (path[result].Color == "green")
                {
                    Console.WriteLine("\nStone found: ");
                    Console.WriteLine(path[result]);
                    Console.WriteLine();
                    return;
                }
            }
            
            Console.WriteLine("No such stone found.");
            
        }
        private void Sort()
        {
           
        }


        private int BinarySearch(List<Stone> list, int target)
        {
            
        }
    }
}
