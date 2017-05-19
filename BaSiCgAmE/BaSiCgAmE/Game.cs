using System;

namespace BaSiCgAmE
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);

            try
            {
                MapLocation mapLocation = new MapLocation(20, 20, map);
            }
            catch(Exception)
            {
                Console.WriteLine("map location off map!");
            }
        }
    }
}