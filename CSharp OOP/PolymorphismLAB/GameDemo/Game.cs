using System;
namespace GameDemo
{
    public abstract class Game // here is the polyM Game takes all possible games
    {
        // also abstaction
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public abstract string GetDescprition();

        public virtual void Start()
        {
            StartDate = DateTime.Now;
        }
        public virtual void Stop()
        {
            EndDate = DateTime.Now;
        }
        // any other game can easily be added

        // if there was no polymorphism we had to create new instance of any
        // game, then the methods of Start, Stop and Description for each, and if we
        // would like to change something everywhere we have to touch it in many different classes,
        // this increasing the chanses of mistakes
    }
}
