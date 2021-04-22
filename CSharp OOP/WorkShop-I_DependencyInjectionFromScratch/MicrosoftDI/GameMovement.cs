using System;
using MicrosoftDI.Contracts;

namespace MicrosoftDI
{
    public class GameMovement : IMovement
    {
        private ILogger logger;
        public GameMovement(ILogger logger)
        {
            this.logger = logger;
        }

        public void Move()
        {
            logger.Log("Moving");
        }
    }
}
