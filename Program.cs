using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            Square[,] square= new Square[10, 10];
            Zone zone = new Zone(10, 10);
            Robot robot = new Robot("Robot");
            Element element = new Element("H", 4, 8);

            zone.CreateZone(square);
            square[element.y, element.x].data = element.name;
            robot.RobotStart(square,robot.y,robot.x);//roboto pradzios startas
            zone.DisplayTable(square);//lauko nupaisymas

            robot.Move(square,zone,element);  

            Console.ReadKey();
        }
        static void SquareInfo(Square[,] square)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < 10; a++)
                {
                    square[i, a].Display();
                }
            }
        }
    }
}
