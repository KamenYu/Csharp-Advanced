using MicrosoftDI.Contracts;

namespace MicrosoftDI
{
    public class Engine
    {
        private ILogger logger;
        private IMovement move;
        public Engine(ILogger logger, IMovement gameMovement) // this is DI
        {
            this.logger = logger;
            move = gameMovement;
        }

        public void Start()
        {
            logger.Log("Starting...");
            move.Move();
        }
        public void End()   { logger.Log("End!"); }
    }
}
