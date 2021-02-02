using System;
using System.Collections.Generic;
using System.Linq;

using FTG.Common;
using FTG.Models;

namespace FTG.Core
{
    public class Engine
    {
        private readonly ICollection<Team> teams;

        public Engine()
        {
            teams = new List<Team>();
        }

        public void Run()
        {
            string command;
            while ((command = Console.ReadLine())!= "END")
            {
                string[] cmdArgs = command
                    .Split(';');

                try
                {
                    List<string> list = cmdArgs.Skip(1).ToList();
                    if (cmdArgs[0] == "Team")
                    {
                        CreateTeam(list);
                    }
                    else if (cmdArgs[0] == "Add")
                    {
                        AddPlayerToTeam(list);
                    }
                    else if (cmdArgs[0] == "Remove")
                    {
                        RemovePlayerFromTeam(list);
                    }
                    else if (cmdArgs[0] == "Rating")
                    {
                        RateTeam(list);
                    }
                }
                catch (ArgumentException aex)
                {
                    Console.WriteLine(aex.Message);                  
                }
                catch (InvalidOperationException ioex)
                {
                    Console.WriteLine(ioex.Message);
                }                
            }
        }

        private void CreateTeam(IList<string> cmdArgs)
        {
            Team team = new Team(cmdArgs[0]);

            teams.Add(team);
        }

        private void AddPlayerToTeam(IList<string> cmdArgs)
        {
            string teamName = cmdArgs[0];
            string playerName = cmdArgs[1];

            ValidateTeamExistence(teamName);

            Stats stats = BuildPlayerStats(cmdArgs.Skip(2).ToArray());

            Player player = new Player(playerName, stats);

            Team team = teams.First(n => n.Name == teamName);
            team.AddPlayer(player);
        }

        private void RemovePlayerFromTeam(IList<string> cmdArgs)
        {
            string teamName = cmdArgs[0];
            string playerName = cmdArgs[1];

            ValidateTeamExistence(teamName);
            Team team = teams.First(n => n.Name == teamName);
            team.RemovePlayer(playerName);
        }

        private void RateTeam(IList<string> cmdArgs)
        {
            string teamName = cmdArgs[0];

            ValidateTeamExistence(teamName);
            Team team = teams.First(n => n.Name == teamName);
            team.Rating();
        }

        private Stats BuildPlayerStats(string[] stats)
        {
            int endurance = int.Parse(stats[0]);
            int sprint = int.Parse(stats[1]);
            int dribble = int.Parse(stats[2]);
            int passing = int.Parse(stats[3]);
            int shooting = int.Parse(stats[4]);

            Stats playerStats = new Stats(endurance, sprint, dribble, passing, shooting);
            return playerStats;
        }

        private void ValidateTeamExistence(string teamName)
        {
            if (teams.Any(n => n.Name == teamName) == false)
            {
                throw new InvalidOperationException
                    (string
                    .Format(GlobalConstants
                    .MissingTeam, teamName));
            }
        }
    }
}
