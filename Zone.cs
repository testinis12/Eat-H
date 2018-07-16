using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Zone
    {
        Element element;
        public int x;
        public int y;

        public Zone(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public void CreateZone(Square [,]square)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < 10; a++)
                {
                    square[i, a].y = i;
                    square[i, a].x = a;
                    square[i, a].data = " ";
                }
            }
        }
        public void DisplayTable(Square[,] square)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + "#");
                for (int a = 0; a < 10; a++)
                {
                    Console.Write(square[i, a].data);
                }

                Console.WriteLine();
            }

            Console.WriteLine(" ###########");
            Console.WriteLine("  0123456789");
        }
    }
}
