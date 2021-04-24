using System;

namespace ProtoypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // if unclear check OOP October, DesignPatterns LAB 1:50:00
            Dice dice = new Dice() { Side = 7 , Colour = "Red", Player = new Player("Godi")};

            Dice dice2 = (Dice)dice.Clone();

            Console.WriteLine(dice2.Side); // side = 7

            dice2.Side = 4;

            Console.WriteLine($"Dice 1 side is : {dice.Side}");
            Console.WriteLine($"Dice 2 side is : {dice2.Side}");

            dice2.Player.Name = "Niko";

            Console.WriteLine($"Dice 1 Player name is : {dice.Player.Name}");
            Console.WriteLine($"Dice 2 Player name is : {dice2.Player.Name}");


        }
    }
}
