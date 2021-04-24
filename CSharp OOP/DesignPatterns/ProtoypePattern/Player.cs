using System;

namespace ProtoypePattern
{
    public class Player : ICloneable // to make Dice to do a deep copy of Player 
    {
        public Player(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
