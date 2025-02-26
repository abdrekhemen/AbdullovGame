using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdullovGame.Items
{
    internal class Potion : Item
    {
        
        public int healthToRegenerate = 60;

        public Potion(string name) : base(name)
        {
            name = "Зелье здоровья";
        }

        private void Use(Player player)
        {
            player.Heal(healthToRegenerate);
        }
    }

    
}
