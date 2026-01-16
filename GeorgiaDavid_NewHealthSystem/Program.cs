using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeorgiaDavid_NewHealthSystem
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string playerName = Console.ReadLine();

            Player player = new Player(playerName, 100, 100);

            Console.WriteLine("player: " + player.Name);
        }
    }
}
