using MillitaryElit.Enumerators;
namespace MillitaryElit.Models
{
    public interface IMission
    {
        public string CodeName { get; }

        MissionStateEnum MissionStateEnum {get;}

        public void CompleteMission(string missionName);

    }
}
