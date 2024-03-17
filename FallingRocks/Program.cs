using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FallingRocks
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int WindowsHeight = 40;
            const int WindowsWidth = 50;
            const int SizeOfScorePanel = 10;

            int score = 0;
            Console.WriteLine("Rocks spawn rate hardness level(from 1 to 10 - 4 is prefferable");
            string inputSpawnRate = Console.ReadLine();

            int rocksSpawnRate = ProcessPlayerRocksSpawnRateChoice(inputSpawnRate);
            Console.WriteLine("Rocks spawn rate hardness level(from 50 to 150 - 120 is prefferable");
            string inputFallSpeed = Console.ReadLine();
            string rocksFallSpeed = ProcessPlayerRocksSpawnChoice(inputFallSpeed);
            // SetWindowProperties();

            int playerWindowCenterWidth() = (Console.WindowWidth - 1) / 2;
            int consoleMaxHeight = Console.WindowHeight = Console.WindowHeight - SizeOfScorePanel;

            int playerWindowBottomHeight = consoleMaxHeight - 1;
            Player player = new Player();

            List<Rock> rocks = new List<Rock>();

            while (true)
            {
                //RedrawConsole();
                //CreateRocks();
                player.Draw();
                DrawRocks();
                player.Move();
                //MoveRocks;

                if(player.HasBeenHit)
                {
                    //EndGame();
                    return;
                }
                Thread.Sleep(rocksFallSpeed);

            }

            int ProcessPlayerRocksSpawnRateChoice(string inputSpawnRate)
            {
                //here 
            }
            int ProcessPlayerRocksFallSpeedChoice(string inputFallSpeed)
            {
                //here 
            }
        }
        void SetWindowProperties()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetWindowSize(WindowWidth, WindowHeight);
            Console.SetBufferSize(WindowWidth, WindowHeight);

        }
        void RedrawConsole()
        {
            Console.SetCursorPosition(0,0);
            for(int i =0; i < WindowHeight - SizeOfScorePanel; i++)
            {
                Console.WriteLine(new String(" ", WindowWidth)); //here 
            }
            //DrawScorePanel();
        }
        void DrawScorePanel()
        {
            //here 
        }
        void CreateRocks()
        {
            int consoleMaxWidth = Console.WindowWidth - 1;
            for( int width = 1; width <= consoleMaxWidth; width++)
            {
                if(/*ShouldGenerateRock()*/)
                {

                }
            }
        }
        bool ShouldGenerateRock()
        {
            Random random = new Random();
            int spawnRateMaxValue = 100;

            return random.Next(0, 101) >= spawnRateMaxValue - rocksSpawnRate;
        }

        List<Rock> rocks = new List<Rock>(); //Shoud this be here?
        void DrawRocks()
        {
            foreach(Rock rock in rocks)   //rocks
            {
                Console.SetCursorPosition(rock.X, rock.Y);
                Console.Write(rock.Symbol);
            }
        }
        void MoveRocks()
        {
            List<Rock> rocksToRemove = new List<Rock>();

            foreach (Rock rock in rocks)
            {
                rock.Y++;

                if(rock.Y == consoleMaxHeight)
                {
                    //here 
                }

                if (/*ThereIsCollision(rock, player)*/)
                {
                    player.HasBeenHit = true;
                }
            }
            //RemoveRocks(rocksToRemove, rocks);
        }
        bool ThereIsCollision(Rock rock, Player player)
        {
            if (/*RockAndPlayerAreOnSameWidth(rock, player)
                 && RockAndPlayerAreOnSameHeight(rock, player)*/)
            {
                return true;
            } 
            return false;
        }
        
    }
}
