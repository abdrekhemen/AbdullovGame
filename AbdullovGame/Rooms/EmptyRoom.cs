using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdullovGame.Rooms
{
    internal class EmptyRoom : Room
    {
        public override void EnterRoom(Player player)
        {
            Console.WriteLine("Комната пуста...");
        }
    }
}
