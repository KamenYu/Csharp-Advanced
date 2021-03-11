using System;
namespace LS_JungleDemo
{
    public class Snake : Animal
    {
        public Snake(string name)
        {
            Name = name;
        }

        public override void Die()
        {
            
        }

        public override void Eat()
        {
            
        }
        // all animals should eat, run , sleep and die, but the snake does not sleep or die, thus violates liskov substitution
        // solution to this violation is either smaller interfaces or abstract classes
        public override void Run()
        {
            throw new NotImplementedException();
        }

        public override void Sleep()
        {
            throw new NotImplementedException();
        }
    }
}
