﻿using System;

namespace p03_06_side_winder_maze
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.Initialize(25);
            Console.CursorVisible = false;
            const int WAIT_TICK = 1000 / 30;
            int lastTick = 0;
            while (true)
            {
                #region 프레임 설정
                int currentTick = System.Environment.TickCount;
                if (currentTick - lastTick < WAIT_TICK)
                    continue;
                lastTick = currentTick;
                #endregion

                //랜더링
                Console.SetCursorPosition(0, 0);
                board.Render();
            }
        }
    }
}