using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_RPG
{
    internal class GameLoop
    {
        Map map;
        Player player;
        Random rand = new Random();

        ConsoleKeyInfo key;
        int monster = 0;
        int monster1_hp = 10;
        int monster2_hp = 20;
        int att;
        bool gameover = false;
        public void Awake()
        {
            map = new Map();
            player = new Player();

            Console.CursorVisible = false;
            player.Awake();
            map.Awake();
        }
        public void Start()
        {
            map.Start();



        }


        public void Update()
        {
            key = Console.ReadKey();
            switch (key.Key)
            {

                case ConsoleKey.LeftArrow:
                    {
                        if (player.Move == true)
                        {
                            monster1_hp = 10;
                            monster2_hp = 20;
                            Console.Clear();
                            player.Move_Left();

                            //monster가 3,4,5 일때 안전
                            if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 2)
                            {
                                monster = rand.Next(1, 6);
                                if (monster == 1 || monster == 2)
                                {
                                    player.SetMove(false);
                                }
                            }
                            //monster가 10 일때 안전
                            else if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 3)
                            {
                                monster = rand.Next(6, 11);
                                if (monster == 6 || monster == 7 || monster == 8 || monster == 9)
                                {
                                    player.SetMove(false);

                                }
                            }
                            else if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 4)
                            {
                                player.SetMove(false);
                            }
                        }

                    }
                    break;
                case ConsoleKey.UpArrow:
                    {
                        if (player.Move == true)
                        {
                            monster1_hp = 10;
                            monster2_hp = 20;
                            Console.Clear();

                            player.Move_Up();
                            if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 2)
                            {
                                monster = rand.Next(1, 6);
                                if (monster == 1 || monster == 2)
                                {
                                    player.SetMove(false);
                                }
                            }
                            //monster가 10 일때 안전
                            else if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 3)
                            {
                                monster = rand.Next(6, 11);
                                if (monster == 6 || monster == 7 || monster == 8 || monster == 9)
                                {
                                    player.SetMove(false);
                                }
                            }
                            else if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 4)
                            {
                                player.SetMove(false);
                            }
                        }

                    }
                    break;
                case ConsoleKey.RightArrow:
                    {
                        if (player.Move == true)
                        {
                            monster1_hp = 10;
                            monster2_hp = 20;
                            Console.Clear();
                            player.Move_Right();
                            if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 2)
                            {

                                monster = rand.Next(1, 6);
                                if (monster == 1 || monster == 2)
                                {
                                    player.SetMove(false);
                                }

                            }
                            //monster가 10 일때 안전
                            else if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 3)
                            {
                                monster = rand.Next(6, 11);
                                if (monster == 6 || monster == 7 || monster == 8 || monster == 9)
                                {
                                    player.SetMove(false);
                                }
                            }
                            else if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 4)
                            {
                                player.SetMove(false);
                            }
                        }
                    }
                    break;
                case ConsoleKey.DownArrow:
                    {
                        if (player.Move == true)
                        {
                            monster1_hp = 10;
                            monster2_hp = 20;

                            Console.Clear();
                            player.Move_Down();
                            if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 2)
                            {
                                monster = rand.Next(1, 6);
                                if (monster == 1 || monster == 2)
                                {
                                    player.SetMove(false);
                                }
                            }
                            //monster가 10 일때 안전
                            else if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 3)
                            {
                                monster = rand.Next(6, 11);
                                if (monster == 6 || monster == 7 || monster == 8 || monster == 9)
                                {
                                    player.SetMove(false);
                                }
                            }
                            else if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 4)
                            {
                                player.SetMove(false);
                            }
                        }
                    }
                    break;
                case ConsoleKey.Spacebar:
                    {
                        Console.Clear();
                        player.Move_Space();
                    }
                    break;

                case ConsoleKey.Z:
                    {
                        if (player.Move == false)
                        {
                            Console.Clear();

                            if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 2)
                            {
                                att = rand.Next(1, 3);
                                if (att == 1)
                                {
                                    if (monster1_hp > 0)
                                    {
                                        --monster1_hp;
                                        if (monster1_hp == 0)
                                        {

                                            player.SetMove(true);
                                            player.SetGold_P1(1);

                                        }

                                    }
                                }
                                else if (att == 2)
                                {


                                    player.SetHP_2(1);


                                }


                            }
                            if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 3)
                            {
                                att = rand.Next(1, 3);
                                if (att == 1)
                                {
                                    --monster2_hp;
                                    if (monster2_hp == 0)
                                    {

                                        player.SetMove(true);
                                        player.SetGold_P2(1);

                                    }
                                }
                                else if (att == 2)
                                {
                                    if (monster2_hp > 0)
                                    {


                                        player.SetHP_2(2);

                                    }
                                }

                            }
                        }
                        if (player.HP_2 == 0)
                        {
                            gameover = true;
                        }
                    }
                    break;

                case ConsoleKey.X:
                    {
                        if (player.Move == false)
                        {
                            Console.Clear();
                            if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 2)
                            {
                                att = rand.Next(1, 3);
                                if (att == 1)
                                {
                                    if (monster1_hp > 0)
                                    {

                                        player.SetHP_2(1);
                                    }
                                }
                                else if (att == 2)
                                {

                                    --monster1_hp;
                                    if (monster1_hp == 0)
                                    {

                                        player.SetMove(true);
                                        player.SetGold_P1(1);

                                    }
                                }

                            }
                            if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 3)
                            {
                                att = rand.Next(1, 3);
                                if (att == 1)
                                {
                                    player.SetHP_2(2);
                                }
                                else if (att == 2)
                                {
                                    if (monster2_hp > 0)
                                    {

                                        --monster2_hp;
                                        if (monster2_hp == 0)
                                        {

                                            player.SetMove(true);
                                            player.SetGold_P2(1);

                                        }


                                    }
                                }
                            }
                        }
                        if (player.HP_2 == 0)
                        {
                            gameover = true;
                        }
                    }
                    break;

                case ConsoleKey.Y:
                    {
                        Console.Clear();
                        if (player.Gold >= 50 && map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 4)
                        {
                            player.SetGold_M(1);
                            player.SetPotion(1);
                        }
                    }
                    break;
                case ConsoleKey.N:
                    {
                        Console.Clear();
                        if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 4)
                        {
                            player.SetMove(true);
                        }
                    }
                    break;

                case ConsoleKey.I:
                    {
                        Console.Clear();
                        if (monster == 6 || monster == 1 || monster == 6 || monster == 7 || monster == 8 || monster == 9)
                        {
                            if (player.Potion > 0 && player.HP_2 < 50)
                            {
                                player.SetPotion_M(1);
                                if (player.HP_2 < 30)
                                {
                                    player.SetHP_2P(1);


                                }
                                else if (player.HP_2 > 30)
                                {
                                    player.HP_2 = 50;

                                }

                            }



                        }
                    }
                    break;

            }




        }

        public void Render()
        {






            if (gameover == true)
            {
                Console.SetCursorPosition(10, 10);
                Console.WriteLine($"Game Over");
            }

            else if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 5)

            {
                Console.SetCursorPosition(10, 10);
                Console.WriteLine($"Game Clear");

            }




            else
            {

                if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 1)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("평지 - 안전");
                }
                if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 2)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("숲 - 위험");
                    if (monster == 1 && player.Move == false || monster == 2 && player.Move == false)
                    {

                        Console.SetCursorPosition(20, 0);
                        Console.Write("monster");

                        Console.Write("");

                        



                        Console.SetCursorPosition(20, 1);
                        Console.Write($"HP : {monster1_hp}");
                        Console.SetCursorPosition(20, 2);
                        Console.Write("홀 - Z   짝 - X");

                    }
                }
                if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 3)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("늪 - 매우 위험");
                    if (monster == 6 && player.Move == false || monster == 7 && player.Move == false || monster == 8 && player.Move == false || monster == 9 && player.Move == false)
                    {

                        Console.SetCursorPosition(20, 0);
                        Console.Write("monster2");
                        Console.SetCursorPosition(20, 1);
                        Console.Write($"HP : {monster2_hp}");
                        Console.SetCursorPosition(20, 2);
                        Console.Write("홀 - Z   짝 - X");
                        Console.SetCursorPosition(20, 3);
                        Console.Write("물약사용 - I");


                    }
                }
                if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 4 && player.Move == false)
                {

                    Console.Clear();

                    Console.SetCursorPosition(20, 0);
                    Console.Write("상점");
                    Console.SetCursorPosition(20, 1);
                    Console.Write("포션 구매 - Y");
                    Console.SetCursorPosition(20, 2);
                    Console.Write("나가기 - N");


                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("상점");
                }
                if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 5)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("탈출");
                }
                if (map.Gettile(player.Getplayer_x(), player.Getplayer_y()) == 6)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("영웅 소환지");
                }

                map.Render();
                player.Render();
            }




        }

    }
}




