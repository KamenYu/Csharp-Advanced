using System;
using System.Collections.Generic;
using System.Linq;

using MillitaryElit.Models;
using MillitaryElit.Enumerators;
using MillitaryElit.Contracts;

namespace MillitaryElit
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // 40 / 100
            List<ISoldier> soldiers = new List<ISoldier>();

            string command;
            
            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                SoldierCorpsEnum soldierCorpsEnum;

                if (tokens[0] == "Private")
                {
                    Private priv = new Private(tokens[1], tokens[2], tokens[3], decimal.Parse(tokens[4]));
                    soldiers.Add(priv);
                }
                else if (tokens[0] == "LieutenantGeneral")
                {
                    string[] privateIDs = tokens.Skip(5).ToArray();
                    List<IPrivate> lGPrivs = new List<IPrivate>();

                    foreach (var prId in privateIDs)
                    {
                        Private priv = (Private)soldiers.FirstOrDefault(x => x.ID == prId);

                        lGPrivs.Add(priv);                        
                    }

                    LieutenantGeneral lG = new LieutenantGeneral(tokens[1], tokens[2], tokens[3], decimal.Parse(tokens[4]), lGPrivs);
                    soldiers.Add(lG);
                }
                else if (tokens[0] == "Engineer")
                {                                      
                    if (Enum.TryParse(tokens[5], out soldierCorpsEnum))
                    {
                        string[] repairs = tokens.Skip(6).ToArray();
                        List<IRepair> reps = new List<IRepair>();

                        for (int i = 0; i < repairs.Length; i += 2)
                        {
                            IRepair rep = new Repair(repairs[i], int.Parse(repairs[i + 1]));
                            reps.Add(rep);
                        }

                        Engineer eng = new Engineer(tokens[1], tokens[2], tokens[3], decimal.Parse(tokens[4]), soldierCorpsEnum, reps);
                        soldiers.Add(eng);
                    }
                }
                else if (tokens[0] == "Commando")
                {
                    MissionStateEnum missionStateEnum;

                    if (Enum.TryParse(tokens[5], out soldierCorpsEnum))
                    {
                        string[] missions = tokens.Skip(6).ToArray();
                        List<IMission> missionsL = new List<IMission>();

                        for (int i = 0; i < missions.Length; i += 2)
                        {
                            if (Enum.TryParse(missions[i+1], out missionStateEnum))
                            {
                                IMission miss = new Mission(missions[i], missionStateEnum);
                                missionsL.Add(miss);
                            }                           
                        }

                        Comando com = new Comando(tokens[1], tokens[2], tokens[3], decimal.Parse(tokens[4]), soldierCorpsEnum, missionsL);
                        soldiers.Add(com);
                    }                    
                }
                else if (tokens[0] == "Spy")
                {
                    Spy spy = new Spy(tokens[1], tokens[2], tokens[3], int.Parse(tokens[4]));
                    soldiers.Add(spy);
                }
            }

            foreach (var item in soldiers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
