using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Robot
    {
        public string name;
        public int x=5;
        public int y=8;

        public Robot(string name)
        {
            this.name = name;
        }
        public void Move(Square[,] square,Zone zone,Element element)
        {
            int kiek = 0;
            int eat = 0;
            while (true)
            {
                ConsoleKeyInfo e = Console.ReadKey();
                if (e.Key == ConsoleKey.LeftArrow)
                {
                    square[y, x].data = " ";
                    if (x == 0 )
                    {
                        square[y, x].data = "R";
                    }
                    else if (x >= 0)
                    {
                        if (square[y, x - 1].data == "H")
                        {
                            eat++;
                        }
                            square[y, x - 1].data = "R";
                        x = x - 1; 
                    }
                    kiek++;
                }
                if (e.Key == ConsoleKey.RightArrow)
                {
                    square[y, x].data = " ";
                    if (x == 9)
                    {
                        square[y, x].data = "R";
                    }
                    else
                    {
                        if (square[y, x + 1].data == "H")
                            eat++;
                        square[y, x + 1].data = "R";
                        x = x + 1;
                    }
                    kiek++;
                }
                if (e.Key == ConsoleKey.DownArrow)
                {
                    square[y, x].data = " ";
                    if (y == 9)
                    {
                        square[y, x].data = "R";
                    }
                    else
                    {
                        if (square[y+ 1, x ].data == "H")
                            eat++;
                        square[y+1, x ].data = "R";
                        y = y + 1;
                    }
                    kiek++;
                }
                if (e.Key == ConsoleKey.UpArrow)
                {
                    square[y, x].data = " ";
                    if (y == 0)
                    {
                        square[y, x].data = "R";
                    }
                    else
                    {
                        if (square[y- 1, x ].data == "H")
                            eat++;
                        square[y - 1, x].data = "R";
                        y = y - 1;
                    }
                    kiek++;
                }
                Console.Clear();
                CreateH(element,square);
                zone.DisplayTable(square);  
                Console.WriteLine("Padaryti ejimai: " + kiek);
                Console.WriteLine("Kiek kartu suvalgei: " + eat);
            }
        }
        public void CreateH(Element element,Square[,] square)
        {
            Random rnd = new Random();
            if (square[element.y,element.x].data!="H")
            {
                square[rnd.Next(1, 9), rnd.Next(1, 9)].data = "H";
            }
        }
        public void RobotStart(Square[,] square, int y, int x)
        {
            square[y, x].data = "R";
        }
    }
}

