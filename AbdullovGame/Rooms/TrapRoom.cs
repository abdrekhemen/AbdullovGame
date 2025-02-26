using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdullovGame
{
    internal class TrapRoom : Room
    {
        public override void EnterRoom(Player player)
        {
            Console.WriteLine("Ловушка!");
            Random rnd = new Random();
            player.Damage(rnd.Next(10, 20));

        }
    }
}
