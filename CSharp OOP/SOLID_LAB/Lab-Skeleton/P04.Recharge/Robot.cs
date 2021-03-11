namespace P04.Recharge
{
    public class Robot : IWorker, IRechargeable
    {
        private int capacity;
        private int currentPower;

        public Robot(string id, int capacity)
        {
            ID = id;
            this.capacity = capacity;
        }

        public string ID { get; set; }
        public int Capacity
        {
            get { return capacity; }
        }

        public int CurrentPower
        {
            get { return currentPower; }
            set { currentPower = value; }
        }


        public void Work(int hours)
        {
            if (hours > currentPower)
            {
                hours = currentPower;
            }

            currentPower -= hours;
        }

        public void Recharge()
        {
            currentPower = capacity;
        }
    }
}