using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    struct Square
    {
        public string data;
        public int x { get; set; }
        public int y;

        public void Display()
        {
            Console.WriteLine($"info:{data},x:{x},y:{y}");
        }
        
    }
}
