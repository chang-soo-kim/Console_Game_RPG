using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_RPG
{
    //몬스터1 - 위험1 몬스터2 - 매우위험2
    internal class Player
    {
        int player_x = 0;
        int player_y = 0;
        string playername;
        public int HP_2 = 50;
       public int Potion = 1;
        public int Gold = 0;

        public bool Move = true;
        public void SetMove(bool move)
        {   Move = move; }

        public int Getplayer_x()
            { return player_x/2; }
        public int Getplayer_y()
        { return player_y; }

        public void SetPotion(int a)
        {
            Potion += 1;
        }
        public void SetPotion_M(int a)
        {
            Potion -= 1;
        }
        public void SetHP_2P(int a)
        {
            HP_2 += 20;
        }

        public void SetGold_M(int a)
        {
            Gold -= 50;
        }

        public void SetGold_P1(int a)
        {
            Gold += 30;
        }

        public void SetGold_P2(int a)
        {
            Gold += 50;
        }

        public void SetHP_2(int a)
        {
            HP_2 -= 1;
        }

        public void Awake()
        {
            Console.WriteLine("플레이어 닉네임을 입력하세요!");
            playername = Console.ReadLine();

        }
        public void Start()
        {

        }


        public void Move_Left()
        {
            if(Move == true)
            {
            player_x-=2;
            if (player_x < 0)
            {
                player_x = 0;
            }
            }
        }
        public void Move_Right()
        {
            if (Move == true)
            {
                player_x += 2;
                if (player_x > 18)
                {
                    player_x = 18;
                }
            }
        }
        public void Move_Up()
        {
            if (Move == true)
            {
                --player_y;
                if (player_y < 0)
                {
                    player_y = 0;
                }
            }

        }
        public void Move_Down()
        {
            if (Move == true)
            {
                ++player_y;
                if (player_y > 9)
                {
                    player_y = 9;
                }
            }

        }
        public void Move_Space()
        {

        }

        public void Update()
        {
            Console.SetCursorPosition(player_x, player_y);


        }

        public void Render()
        {
            

            Console.SetCursorPosition(player_x, player_y);
            Console.WriteLine("◎");

            Console.SetCursorPosition(0, 11);
            Console.WriteLine($"{playername}");
            Console.WriteLine($"HP : {HP_2} / 50 ");
            Console.WriteLine($"물약 : {Potion}");
            Console.WriteLine($"골드 : {Gold}");


        }
    }
}
