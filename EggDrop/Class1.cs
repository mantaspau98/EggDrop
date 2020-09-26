using System;

namespace EggDrop
{
    public class Program
    {
        public static void Main()
        {
            //there is an x number of floors
            //we need to find the floor with the least amount of steps

            DropGame game = new DropGame(100,11);
            Console.WriteLine(game.FindHighestLevel());
        }
    }
}
