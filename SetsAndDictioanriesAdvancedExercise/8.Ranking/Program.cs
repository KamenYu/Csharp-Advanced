using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string contests = string.Empty;
            Dictionary<string, string> contestPass = new Dictionary<string, string>();

            while ((contests = Console.ReadLine()) != "end of contests")
            {
                string[] tokens = contests.Split(':');
                contestPass.Add(tokens[0], tokens[1]);
            }
            string submissions = string.Empty;
            Dictionary<string, Dictionary<string, int>> studentLog = new Dictionary<string, Dictionary<string, int>>();

            while ((submissions = Console.ReadLine()) != "end of submissions")  // C# Fundamentals=>fundPass=>Tanya=>350
            {
                string[] tokens = submissions.Split("=>");
                string contest = tokens[0];
                string pass = tokens[1];
                string name = tokens[2];
                int points = int.Parse(tokens[3]);

                if (contestPass.ContainsKey(contest) && contestPass[contest] == pass)
                {
                    if (studentLog.ContainsKey(name))
                    {
                        if (studentLog[name].ContainsKey(contest))
                        {
                            if (studentLog[name][contest] < points)
                            {
                                studentLog[name][contest] = points;
                            }
                        }
                        else
                        {
                            studentLog[name].Add(contest, points);
                        }
                    }
                    else
                    {
                        studentLog.Add(name, new Dictionary<string, int>());
                        studentLog[name].Add(contest, points);
                    }
                }
            }
            int currPoints = 0;
            int maxPoints = 0;
            string bestUser = string.Empty;

            foreach (var student in studentLog.Keys)
            {
                var points = studentLog[student];
                foreach (var point in points.Keys)
                {
                    currPoints += points[point];
                }
                if (maxPoints < currPoints)
                {
                    maxPoints = currPoints;
                    bestUser = student;
                }
                currPoints = 0;
            }
            Console.WriteLine($"Best candidate is {bestUser} with total {maxPoints} points.");
            Console.WriteLine("Ranking: ");
            foreach (var student in studentLog.Keys.OrderBy(x => x))
            {
                Console.WriteLine(student);
                Dictionary<string, int> finalize = studentLog[student];
                foreach (var kvp in finalize.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
