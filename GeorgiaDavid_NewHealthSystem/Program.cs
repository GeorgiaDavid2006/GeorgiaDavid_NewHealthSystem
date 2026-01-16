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
            Console.Write("health: " + player._Health.CurrentHealth);
            Console.Write(" sheild: " + player._Sheild.CurrentHealth);
            Console.WriteLine(" status: " + player.GetStatusString());
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Press D key to take damage or H key to heal");
            Console.ReadKey();
            Console.Clear();

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            

        }
    }
}
