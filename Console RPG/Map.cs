using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_RPG
{
    internal class Map
    {
        char block;
        
        Random random = new Random();
        
        int[,] block_xy = new int[10, 10];

        public int Gettile(int a, int b)
        { return tile[a, b]; }

        //영웅소환위치 - 6 / 평지 - 안전1 / 숲 - 위험2 / 늪  - 매우위험3 / 상점 4 / 탈출 5
        int[,] tile = new int[10,10];
        int tile_x = 0;
        int tile_y = 0;


  
        
        //탈출 위치 좌표 0,10
        
        public void Awake()
        {
            // 색상 바꾸기
            block = '■';
            //색상 초기화
        }
        public void Start()
        {
            tile[0, 9] = 5;
            tile[0, 0] = 6;

            do
            {
                tile_x = random.Next(0, 5);
                tile_y = random.Next(0, 5);
                tile[tile_x, tile_y] = 4;
            } while (tile_x == 0 && tile_y == 0);

            tile_x = random.Next(5, 10);
            tile_y = random.Next(0, 5);
            tile[tile_x, tile_y] = 4;

            do
            {
            tile_x = random.Next(0, 5);
            tile_y = random.Next(5, 10);
            tile[tile_x, tile_y] = 4;
            } while (tile_x == 0 && tile_y == 9);

            tile_x = random.Next(5, 10);
            tile_y = random.Next(5, 10);
            tile[tile_x, tile_y] = 4;


            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (tile[x, y] != 6 && tile[x, y] != 4 && tile[x, y] != 5)
                        tile[x, y] = random.Next(1, 4);
                }

            }

        }


        public void Update()
        {

        }

        public void Render()
        {
            

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {

                    switch (tile[x,y])
                    {

                        case 6:
                            {

                                Console.SetCursorPosition(x * 2, y);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write(block);
                                Console.ResetColor();//글씨색상 초기화
                                

                            }
                            break;
                        case 1:
                            {

                            Console.SetCursorPosition(x*2, y);
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.Write(block);
                                Console.ResetColor();//글씨색상 초기화
                            }
                            break;
                        case 2:
                            {

                                Console.SetCursorPosition(x * 2, y);
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                
                                Console.Write(block);
                                Console.ResetColor();//글씨색상 초기화
                            }
                            break;
                        case 3:
                            {

                                Console.SetCursorPosition(x * 2, y);
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(block);
                                Console.ResetColor();//글씨색상 초기화
                            }
                            break;
                        case 4:
                            {
                                Console.SetCursorPosition(x * 2, y);
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write(block);
                                Console.ResetColor();//글씨색상 초기화
                            }
                            break;
                        case 5:
                            {

                                Console.SetCursorPosition(x * 2, y);
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.Write(block);
                                Console.ResetColor();//글씨색상 초기화
                            }
                            break;
                    }

                }
            }

            
        }
    }
}
