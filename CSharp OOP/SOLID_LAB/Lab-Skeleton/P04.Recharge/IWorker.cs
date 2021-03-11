namespace P04.Recharge
{
    public interface IWorker
    {
        public string ID { get; set; }

        public void Work(int hours);
    }
}