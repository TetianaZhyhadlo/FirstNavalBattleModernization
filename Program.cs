using System;

namespace SimpleNavalBattle
{
    class Program
    {

        static void Main(string[] args)
        {
            InitPlayer();
            int mapSize = 12;
            MapsCreation1(mapSize);
            MapsCreation2(mapSize);
            Console.WriteLine();
            bool result;
            int mapNum1;
            int[,] myMap1 = new int[mapSize, mapSize];
            bool selection=false;
            while(!selection)
            {
                MapSelection();
                if (mapNum1 == 1)
                {
                    myMap1 = MapsCreation1(mapSize);
                    selection = true;
                }
                else if (mapNum1 == 2)
                {
                    myMap1 = MapsCreation2(mapSize);
                    selection = true;
                }

            }
            Console.WriteLine();
            Turn();
            mapNum1 = 0;
            InitPlayer();
            MapsCreation3(mapSize);
            MapsCreation4(mapSize);
            Console.WriteLine();
            selection = false;
            int[,] myMap2 = new int[mapSize, mapSize];
            while (!selection)
            {
                MapSelection();
                if (mapNum1 == 3)
                {
                    myMap2 = MapsCreation3(mapSize);
                    selection = true;
                }
                else if (mapNum1 == 4)
                {
                    myMap2 = MapsCreation4(mapSize);
                    selection = true;
                }

            }
            Turn();
            int[,] enemyMap1=EnemyMapCreation(mapSize);
            int[,] enemyMap2 = EnemyMapCreation(mapSize);
            int count = 0;
            bool winner = false;
            do
            {
                Console.Clear();
                Console.WriteLine("My map");
                ShowMap(myMap1);
                Console.WriteLine();
                Console.WriteLine("Enemy Map");
                ShowMap(enemyMap1);
                Console.WriteLine();
                Shot1();
                winner=ShipChecking(myMap2);
                Console.WriteLine();
                Turn();
                Console.WriteLine();
                Console.WriteLine("My map");
                ShowMap(myMap2);
                Console.WriteLine();
                Console.WriteLine("Enemy Map");
                ShowMap(enemyMap2);
                Console.WriteLine();
                Shot2();
                winner=ShipChecking(myMap1);
                Console.WriteLine();
                Turn();
            }
            while (!winner);
            void InitPlayer()
            {
                Console.WriteLine("Enter your name:");
                string player1 = Console.ReadLine();
            }
            int[,] MapsCreation1(int a)
            {
                int[,] map1 = new int[mapSize, mapSize];
                Console.WriteLine();
                Console.WriteLine("map1");
                for (int i = 0; i < mapSize - 1; i++)
                {
                    for (int k = 0; k < mapSize - 1; k++)
                    {

                        if (k == 0 && i != 0)
                            map1[i, k] = i;
                        if (k != 0 && i == 0)
                            map1[i, k] = k;
                        if (i == 1 && k == 1 || i == 3 && k == 8 || i == 7 && k == 4 || i == 10 && k == 8)
                            map1[i, k] = 1;
                        if (i == 1 && k >= 9 && k <= 10 || i >= 1 && i <= 2 && k == 5 || i == 10 && k >= 4 && k <= 5)
                            map1[i, k] = 1;
                        if (k == 1 && i >= 8 && i <= 10 || i == 4 && k >= 2 && k <= 5 || k == 10 && i >= 5 && i <= 7)
                            map1[i, k] = 1;
                        
                    }
                }
                ShowMap(map1);
                return map1;
            }
            int[,] MapsCreation2(int a)
            {
                int[,] map2 = new int[a, a];
                Console.WriteLine();
                Console.WriteLine("map2");
                for (int i = 0; i < a - 1; i++)
                {
                    for (int k = 0; k < a - 1; k++)
                    {

                        if (k == 0 && i != 0)
                            map2[i, k] = i;
                        if (k != 0 && i == 0)
                            map2[i, k] = k;
                        if (i == 4 && k == 4 || i == 9 && k == 2 || i == 5 && k == 7 || i == 5 && k == 10)
                            map2[i, k] = 1;
                        if (i >= 4 && i <= 5 && k == 1 || i == 2 && k >= 2 && k <= 3 || k == 10 && i >= 8 && i <= 9)
                            map2[i, k] = 1;
                        if (k == 8 && i >= 1 && i <= 3 || i == 9 && k >= 5 && k <= 8 || i == 7 && k >= 3 && k <= 5)
                            map2[i, k] = 1;
                    }

                }
                ShowMap(map2);
                return (map2);
            }
            int[,] MapsCreation3(int a)
            {
                int[,] map3 = new int[a, a];
                Console.WriteLine();
                Console.WriteLine("map3");
                for (int i = 0; i < a - 1; i++)
                {
                    for (int k = 0; k < a - 1; k++)
                    {

                        if (k == 0 && i != 0)
                            map3[i, k] = i;
                        if (k != 0 && i == 0)
                            map3[i, k] = k;
                        if (i == 9 && k == 1 || i == 9 && k == 3 || i == 9 && k == 6 || i == 9 && k == 9)
                            map3[i, k] = 1;
                        if (i >= 2 && i <= 3 && k == 7 || i == 1 && k >= 2 && k <= 3 || k == 10 && i >= 1 && i <= 2)
                            map3[i, k] = 1;
                        if (k == 2 && i >= 3 && i <= 6 || i == 6 && k >= 6 && k <= 8 || k == 10 && i >= 5 && i <= 7)
                            map3[i, k] = 1;
                    }
                }
                ShowMap(map3);
                return (map3);
            }
            int[,] MapsCreation4(int a)
            {
                int[,] map4 = new int[a, a];
                Console.WriteLine();
                Console.WriteLine("map4");
                for (int i = 0; i < a - 1; i++)
                {
                    for (int k = 0; k < a - 1; k++)
                    {

                        if (k == 0 && i != 0)
                            map4[i, k] = i;
                        if (k != 0 && i == 0)
                            map4[i, k] = k;
                        if (i == 1 && k == 2 || i == 3 && k == 4 || i == 5 && k == 6 || i == 7 && k == 8)
                            map4[i, k] = 1;
                        if (i >= 1 && i <= 2 && k == 8 || i >= 4 && i <= 5 && k == 9 || i >= 7 && i <= 8 && k == 10)
                            map4[i, k] = 1;
                        if (i >= 7 && i <= 10 && k == 3 || i == 5 && k >= 1 && k <= 3 || i == 9 && k >= 6 && k <= 8)
                            map4[i, k] = 1;
                    }
                }
                ShowMap(map4);
                return (map4);
            }
            int[,]EnemyMapCreation(int a)
            {
                int[,] player1Enemy = new int[mapSize, mapSize];
                for (int i = 0; i < mapSize - 1; i++)
                {
                    for (int k = 0; k < mapSize - 1; k++)
                    {

                        if (k == 0 && i != 0)
                            player1Enemy[i, k] = i;
                        else if (k != 0 && i == 0)
                            player1Enemy[i, k] = k;
                        else
                            player1Enemy[i, k] = 0;
                    }
                }
                ShowMap(player1Enemy);
                return player1Enemy;
            }
            void Turn()
            {
                Console.WriteLine("Press 0 to change player.");
                char nextPlayer = Convert.ToChar(Console.ReadLine());
                if (nextPlayer == '0')
                    Console.Clear();
            }
            void ShowMap(int[,] myMap)
            {
                    for (int i = 0; i < myMap.GetLength(0)-1; i++)
                    {
                        Console.WriteLine();
                        for (int k = 0; k < myMap.GetLength(1)-1; k++)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Write("\t|", ConsoleColor.DarkBlue);
                            Console.ResetColor();
                            if (k == 0 || i == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write($"{myMap[i, k]}", ConsoleColor.Green);
                                Console.ResetColor();
                            }
                            if (myMap[i, k] == 1 && i != 0 && k != 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("▲", ConsoleColor.Green);
                                Console.ResetColor();
                            }
                            else if (myMap[i, k] == 2 && i != 0 && k != 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("▼", ConsoleColor.Red);
                                Console.ResetColor();
                            }
                            else if (myMap[i, k] == -1 && i != 0 && k != 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("—", ConsoleColor.Blue);
                                Console.ResetColor();
                            }
                            else if (myMap[i, k] == 0 && i != 0 && k != 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("•", ConsoleColor.Blue);
                                Console.ResetColor();
                            }

                        }
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("\t|", ConsoleColor.DarkBlue);
                        Console.ResetColor();
                    }

            }  
            void Shot1()
            {
                Console.WriteLine("Enter coordinates for shooting:");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                if (myMap2[a, b] == 0)
                {
                    myMap2[a, b] = -1;
                    enemyMap1[a, b] = -1;
                    Console.Clear();
                    Console.WriteLine("My Map");
                    ShowMap(myMap1);
                    Console.WriteLine();
                    Console.WriteLine("Enemy Map");
                    ShowMap(enemyMap1);
                    Console.WriteLine();
                    Console.WriteLine("Ooops! Slip-up.");
                }
                else if (myMap2[a, b] == 1)
                {
                    myMap2[a, b] = 2;
                    enemyMap1[a, b] = 2;
                    Console.Clear();
                    Console.WriteLine("My Map");
                    ShowMap(myMap1);
                    Console.WriteLine();
                    Console.WriteLine("Enemy Map");
                    ShowMap(enemyMap1);
                    Console.WriteLine();
                    Console.WriteLine("Good shot!");
                    Console.WriteLine("Enter coordinates for shooting:");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    Shot1();
                }
                else
                {
                    Console.WriteLine("You've already shooted here, try again.");
                    Shot1();
                }

            }
            void Shot2()
            {
                Console.WriteLine("Enter coordinates for shooting:");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                if (myMap1[a, b] == 0)
                {
                    myMap1[a, b] = -1;
                    enemyMap2[a, b] = -1;
                    Console.Clear();
                    Console.WriteLine("My Map");
                    ShowMap(myMap2);
                    Console.WriteLine();
                    Console.WriteLine("Enemy Map");
                    ShowMap(enemyMap2);
                    Console.WriteLine();
                    Console.WriteLine("Ooops! Slip-up.");
                }
                else if (myMap1[a, b] == 1)
                {
                    myMap1[a, b] = 2;
                    enemyMap2[a, b] = 2;
                    Console.Clear();
                    Console.WriteLine("My Map");
                    ShowMap(myMap2);
                    Console.WriteLine();
                    Console.WriteLine("Enemy Map");
                    ShowMap(enemyMap2);
                    Console.WriteLine();
                    Console.WriteLine("Good shot!");
                    Shot2();
                }
                else
                {
                    Console.WriteLine("You've already shooted here, try again.");
                    Shot2();
                }

            }
            void MapSelection()
            {
                do
                {
                    Console.WriteLine("Choose number of your map:");
                    string firstPlayerMap = Console.ReadLine();
                    result = int.TryParse(firstPlayerMap, out mapNum1);
                }
                while (!result);

            }
            bool ShipChecking(int[,] map)
            {

                for (int i = 1; i < map.GetLength(0) - 1; i++)
                {
                    for (int k = 1; k < map.GetLength(1) - 1; k++)
                    {
                        if (map[i, k] == 1)
                            count++;
                    }
                }
                if (count == 0)
                {
                    winner = true;
                    
                }
                return winner;
            }

        }

    }
}