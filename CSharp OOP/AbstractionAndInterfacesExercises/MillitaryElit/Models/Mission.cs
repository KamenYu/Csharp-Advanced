using MillitaryElit.Enumerators;

namespace MillitaryElit.Models
{
    public class Mission : IMission
    {
        public Mission(string codeName, MissionStateEnum missionStateEnum)
        {
            CodeName = codeName;
            MissionStateEnum = missionStateEnum;
        }

        public string CodeName { get; }

        public MissionStateEnum MissionStateEnum { get; }

        public void CompleteMission(string missionName)
        {
           missionName = "Finished";
        }

        public override string ToString()
        {            
            return $"Code Name: {CodeName} State: {MissionStateEnum}"; // here
        }
    }
}
