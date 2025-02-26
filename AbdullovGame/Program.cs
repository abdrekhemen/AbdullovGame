using AbdullovGame.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdullovGame
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Player player = new Player();

            player.Init();
            Room[] dungeonMap = Init();
            for (int i=0; i<dungeonMap.Length;i++)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1: Войти в комнату");
                Console.WriteLine("2: Посмотреть характеристики");
                Console.WriteLine("3: Посмотреть рюкзак");

                string action = Console.ReadLine();
                switch(action)
                {
                    case "1":
                        dungeonMap[i].EnterRoom(player);
                        break;
                    case "2":
                      player.CheckStats();
                        break;
                    case "3":
                        player.CheckBackpack();
                        break;
                }
            }
        }

       static Room[] Init()
        {
            Room[] map = new Room[10];
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(9); i++)
            {
                switch (rnd.Next(5))
                {
                    case 0:
                        map[i] = new EmptyRoom();
                        break;
                    case 1:
                        map[i] = new MonsterRoom();
                        break;
                    case 2:
                        map[i] = new TrapRoom();
                        break;
                    case 3:
                        map[i] = new ShopRoom();
                        break;
                    case 4:
                        map[i] = new ChestRoom();
                        break;
                }
            }
            map[9] = new BossRoom();
            return map;
        }
    }
}
