using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdullovGame.Rooms
{
    internal class BossRoom : Room
    {
        public string Name = "Комната с боссом";
        public override void EnterRoom(Player player)
        {
            Console.WriteLine("Перед вами босс");
        }

    }
}
