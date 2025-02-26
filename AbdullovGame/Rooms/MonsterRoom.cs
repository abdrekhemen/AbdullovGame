using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdullovGame
{
    internal class MonsterRoom : Room
    {
        public override void EnterRoom(Player player)
        {
            Console.WriteLine("Монстр!");
        }
    }
}
