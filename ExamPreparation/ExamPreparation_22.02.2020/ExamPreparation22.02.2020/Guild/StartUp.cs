using System;
using System.Linq;

namespace Guild
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Player pl1 = new Player("1", "class1");
            Player pl2 = new Player("2", "class1");
            Player pl3 = new Player("3", "class2");
            Player pl4 = new Player("4", "class2");
            Player pl5 = new Player("5", "class3");

            Guild guild = new Guild("This", 4);
            guild.AddPlayer(pl1);
            guild.AddPlayer(pl2);
            guild.AddPlayer(pl3);
            guild.AddPlayer(pl4);
            guild.AddPlayer(pl5);
            Console.WriteLine(guild.Count);

            Console.WriteLine( guild.RemovePlayer("2"));
            Console.WriteLine(  guild.RemovePlayer("6"));
            guild.PromotePlayer("1");
            Console.WriteLine("-----------");
            guild.DemotePlayer("6");
            guild.DemotePlayer("3");
            guild.KickPlayersByClass("class2");

            Console.WriteLine("----------");
            Console.WriteLine(guild.Report());

        }
    }
}
