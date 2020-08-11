using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEqualityComparerExample
{
    class Program
    {
        private static IDictionary<Box, string> boxDictionary = new Dictionary<Box, string>(new BoxEqualityComparer());

        static void Main(string[] args)
        {
            AddBox(new Box(9, 4, 7), "black");
            AddBox(new Box(5, 3, 1), "white");
            AddBox(new Box(9, 4, 7), "green");
            AddBox(new Box(7, 4, 6), "brown");
            AddBox(new Box(3, 1, 5), "yellow");

            Console.WriteLine($"List contains {boxDictionary.Count} boxes.");
        }

        private static void AddBox(Box box, string name)
        {
            try
            {
                boxDictionary.Add(box, name);
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"{box} cannot be added. It's already in the list.");
            }
        }
    }

    class Box
    {
        public Box(int w, int h, int d)
        {
            Width = w;
            Height = h;
            Depth = d;
        }

        public int Width { get; }

        public int Height { get; }

        public int Depth { get; }

        public override string ToString()
        {
            return $"Box:w{Width}.h{Height}.d{Depth}";
        }
    }

    class BoxEqualityComparer : IEqualityComparer<Box>
    {
        bool IEqualityComparer<Box>.Equals(Box x, Box y)
        {
            if (x == null && y == null) return true;

            if (x == null || y == null) return false;

            if (x.Width == y.Width &&
                x.Height == y.Height &&
                x.Depth == y.Depth)
            {
                return true;
            }

            return false;
        }

        int IEqualityComparer<Box>.GetHashCode(Box obj)
        {
            var hCode = obj.Width ^ obj.Height ^ obj.Depth;
            return hCode.GetHashCode();
        }
    }
}
