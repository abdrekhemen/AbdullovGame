using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdullovGame
{
    internal class ChestRoom : Room
    {
        public override void EnterRoom(Player player)
        {
            Console.WriteLine("Перед вами сундук");
        }
    }
}
