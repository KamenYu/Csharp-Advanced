using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.TheV_Logger
{
    class Program
    {       
        static void Main(string[] args)
        {
            // Saffrona followed EmilConrad
            List<Vlogger> vloggers = new List<Vlogger>();
            string input;

            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] tokens = input.Split();
                
                if (tokens[1] == "joined")
                {
                    Vlogger current = new Vlogger(tokens[0]);

                    if (vloggers.Any(v => v.Name == current.Name) == false)
                    {
                        vloggers.Add(current);
                    }                                                        
                }
                else // followed
                {
                    string follower = tokens[0];
                    string followed = tokens[2];

                    if (followed != follower && vloggers.Any(v =>v.Name == followed) && vloggers.Any(v => v.Name == follower))
                    {
                        Vlogger thisFollower = vloggers.Where(x => x.Name == follower).FirstOrDefault();
                            thisFollower.Following.Add(followed);                                               
                        Vlogger beingFollowed = vloggers.Where(x => x.Name == followed).FirstOrDefault();
                            beingFollowed.Followers.Add(follower);                                           
                    }
                }
            }

            int maxFollowers = int.MinValue;

            foreach (var item in vloggers)
            {
                if (item.Followers.Count > maxFollowers)
                {
                    maxFollowers = item.Followers.Count;
                }
            }
            // Vlogger famous = vloggers.Where(v => v.Followers.Count == maxFollowers).FirstOrDefault();

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
           
            int counter = 1;
            foreach (var vlogger in vloggers.OrderByDescending(v => v.Followers.Count).ThenBy(v => v.Following.Count))
            {
                Console.WriteLine($"{counter}. {vlogger.Name} : {vlogger.Followers.Count} followers, {vlogger.Following.Count} following");

                if(counter == 1)
                {
                    foreach (var item in vlogger.Followers)
                    {
                        Console.WriteLine($"*  {item}");
                    }
                }
                counter++;
            }
        }
    }

    public class Vlogger
    {
        public string Name { get; set; }
        public SortedSet<string> Followers { get; set; } = new SortedSet<string>();
        public HashSet<string> Following { get; set; } = new HashSet<string>();

        public Vlogger(string name)
        {
            Name = name;
        }
    }
}
