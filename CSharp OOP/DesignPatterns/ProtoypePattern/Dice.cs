using System;
namespace ProtoypePattern
{
    public class Dice :ICloneable
    {
        public int Side { get; set; }
        public string Colour { get; set; }
        public Player Player { get; set; }

        public object Clone()
        {
            // shallow copy, copies by reference complex entities
            //return MemberwiseClone();
            Dice newDice = MemberwiseClone() as Dice;
            newDice.Player = Player.Clone() as Player;

            return newDice;
        }
    }
}
