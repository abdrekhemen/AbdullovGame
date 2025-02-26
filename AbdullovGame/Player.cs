using AbdullovGame.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdullovGame
{
    internal class Player
    {
        private int maxHealth = 100;
        private int health = 0;
        public int gold = 0;
        public int arrows = 5;
        public bool haveSword = true;
        public bool haveBow = true;
        public List<Item> backpack;


        public void Heal(int amount)
        {
            health += amount;
            Console.WriteLine("Здоровье игрока: " + health);
        }
        public void Damage(int amount)
        {
            health -= amount;
            Console.WriteLine("Здоровье игрока: " +health);
        }
        public void Init()
        {
            health = maxHealth;
            backpack = new List<Item>
            {
                new Potion("Зелье здоровья"),
                new Potion("Зелье здоровья"),
                new Potion("Зелье здоровья")

            };
        }

        public void CheckStats()
        {
            Console.WriteLine("Здоровье: " +health);
            Console.WriteLine("Золото: " +gold);
            Console.WriteLine("Стрел:"+ arrows);
        }
        public void CheckBackpack()
        {
            foreach (Item item in backpack) 
            { 
                Console.WriteLine(item._name);
            }
        }
    }
}
